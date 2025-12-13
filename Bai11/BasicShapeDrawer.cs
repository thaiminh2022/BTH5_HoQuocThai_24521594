using System.Drawing.Drawing2D;
using System.Reflection;
namespace Bai11
{
    enum DrawShape
    {
        None,
        Line,
        Rectangle,
        Ellipse
    }

    enum BrushData
    {
        None,
        Solid,
        Hatch,
        Texture,
        Gradient
    }
    record ShapeData
    {
        public DrawShape Shape { get; init; }
        public BrushData Brush { get; init; }
        public Color Color { get; init; }
        public Color SecondaryColor { get; init; }
        public float Width { get; init; }

        public PointF Start { get; init; }
        public PointF End { get; init; }
    }


    public partial class BasicShapeDrawer : Form
    {
        private DrawShape _currentShape = Bai11.DrawShape.None;
        private BrushData _currentBrush = BrushData.None;
        private Color _currentColor = Color.Black;
        private Color _secondaryColor = Color.White;
        private float _currentWith = 10f;

        //
        bool _isDrawing = false;
        private PointF? _startPoint, _endPoint;

        //
        private readonly List<ShapeData> _shapes = [];

        public BasicShapeDrawer()
        {
            InitializeComponent();

            PropertyInfo? dp = typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            dp?.SetValue(drawingPanel, true);

            // Color
            colorBtn.Click += ColorBtn_Click;
            secColorBtn.Click += SecColorBtn_Click;

            colorBtn.BackColor = _currentColor;
            secColorBtn.BackColor = _secondaryColor;

            // default settings
            widthTextBox.Text = _currentWith.ToString();
            widthTextBox.TextChanged += WidthTextBox_TextChanged;
            clearBtn.Click += ClearBtn_Click;

            // shape checkboxes
            shapeLineCheck.Click += (_, _) => ShapeClick(Bai11.DrawShape.Line);
            shapeRectCheck.Click += (_, _) => ShapeClick(Bai11.DrawShape.Rectangle);
            shapeEllipseCheck.Click += (_, _) => ShapeClick(Bai11.DrawShape.Ellipse);

            // brush checkboxes
            solidBrushCheck.Click += (_, _) => BrushClick(BrushData.Solid);
            hatchBrushCheck.Click += (_, _) => BrushClick(BrushData.Hatch);
            textureBrushCheck.Click += (_, _) => BrushClick(BrushData.Texture);
            gradientBrushCheck.Click += (_, _) => BrushClick(BrushData.Gradient);

            drawingPanel.Paint += DrawingPanel_Paint;

            // mouses
            drawingPanel.MouseDown += DrawingPanel_MouseDown;
            drawingPanel.MouseUp += DrawingPanel_MouseUp;
            drawingPanel.MouseMove += DrawingPanel_MouseMove;
        }

        private void SecColorBtn_Click(object? sender, EventArgs e)
        {
            secColorDialog.Color = _secondaryColor;
            if (secColorDialog.ShowDialog() == DialogResult.OK)
            {
                _secondaryColor = secColorDialog.Color;
                secColorBtn.BackColor = _secondaryColor;
            }
        }

        private void ClearBtn_Click(object? sender, EventArgs e)
        {
            _shapes.Clear();
            drawingPanel.Invalidate();
            _isDrawing = false;
        }

        private void DrawingPanel_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            _endPoint = e.Location;
            drawingPanel.Invalidate();
        }

        private void DrawingPanel_MouseUp(object? sender, MouseEventArgs e)
        {
            if (_startPoint is null) return;

            _isDrawing = false;
            _endPoint = e.Location;

            if (CanDraw())
            {
                _shapes.Add(new ShapeData
                {
                    Shape = _currentShape,
                    Brush = _currentBrush,
                    Color = _currentColor,
                    SecondaryColor = _secondaryColor,
                    Width = _currentWith,
                    Start = _startPoint.Value,
                    End = _endPoint.Value
                });
            }

            _endPoint = null;
            _startPoint = null;

            drawingPanel.Invalidate();
        }

        private void DrawingPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _startPoint = e.Location;
        }

        private void DrawingPanel_Paint(object? sender, PaintEventArgs e)
        {
            foreach (var shape in _shapes)
            {
                using Brush shapeBrush = GetBrush(shape.Brush, shape.Start, shape.End, shape.Color, shape.SecondaryColor);
                DrawShape(e.Graphics, shapeBrush, shape);
            }

            if (CanDraw() && _isDrawing && _startPoint is not null && _endPoint is not null)
            {
                if (_startPoint == _endPoint)
                    return;

                using Brush br = GetBrush(_currentBrush, _startPoint.Value, _endPoint.Value, _currentColor, _secondaryColor);
                DrawShape(e.Graphics, br, new ShapeData
                {
                    Brush = _currentBrush,
                    Color = _currentColor,
                    SecondaryColor = _secondaryColor,
                    Width = _currentWith,
                    Shape = _currentShape,
                    Start = _startPoint.Value,
                    End = _endPoint.Value
                });
            }
        }

        private void DrawShape(Graphics g, Brush br, ShapeData data)
        {
            if (br is TextureBrush txtBr)
            {
                using var path = new GraphicsPath();
                if (data.Shape == Bai11.DrawShape.Line)
                {
                    path.AddLine(data.Start, data.End);
                }
                else if (data.Shape == Bai11.DrawShape.Rectangle)
                {
                    var rect = new RectangleF(
                        MathF.Min(data.Start.X, data.End.X),
                        MathF.Min(data.Start.Y, data.End.Y),
                        MathF.Abs(data.End.X - data.Start.X),
                        MathF.Abs(data.End.Y - data.Start.Y)
                    );
                    path.AddRectangle(rect);
                }
                else if (data.Shape == Bai11.DrawShape.Ellipse)
                {
                    var rect = new RectangleF(
                        MathF.Min(data.Start.X, data.End.X),
                        MathF.Min(data.Start.Y, data.End.Y),
                        MathF.Abs(data.End.X - data.Start.X),
                        MathF.Abs(data.End.Y - data.Start.Y)
                    );
                    path.AddEllipse(rect);
                }
                
                var bounds = new RectangleF(
                    MathF.Min(data.Start.X, data.End.X),
                    MathF.Min(data.Start.Y, data.End.Y),
                    MathF.Abs(data.End.X - data.Start.X),
                    MathF.Abs(data.End.Y - data.Start.Y)
                );
                g.SetClip(path);
                g.DrawImage(txtBr.Image, bounds);

                g.ResetClip();
                return;
            }

            if (data.Shape == Bai11.DrawShape.Line)
            {
                using Pen pen = new Pen(br, data.Width);
                g.DrawLine(pen, data.Start, data.End);
            }
            else if (data.Shape == Bai11.DrawShape.Rectangle)
            {
                RectangleF rect = new RectangleF(
                    MathF.Min(data.Start.X, data.End.X),
                    MathF.Min(data.Start.Y, data.End.Y),
                    MathF.Abs(data.End.X - data.Start.X),
                    MathF.Abs(data.End.Y - data.Start.Y)
                );
                g.FillRectangle(br, rect);
            }
            else if (data.Shape == Bai11.DrawShape.Ellipse)
            {
                RectangleF rect = new RectangleF(
                    MathF.Min(data.Start.X, data.End.X),
                    MathF.Min(data.Start.Y, data.End.Y),
                    MathF.Abs(data.End.X - data.Start.X),
                    MathF.Abs(data.End.Y - data.Start.Y)
                );
                g.FillEllipse(br, rect);
            }
        }

        private Brush GetBrush(BrushData br, PointF start, PointF end, Color color, Color secondary)
        {
            // Avoid zero-length gradient (start == end) – GDI+ will throw OutOfMemory
            if ((br == BrushData.Gradient) && start == end)
            {
                // Nudge the end point by 1 pixel
                end = new PointF(start.X + 1, start.Y + 1);
            }

            return br switch
            {
                BrushData.Solid => new SolidBrush(color),
                BrushData.Hatch => new HatchBrush(HatchStyle.DiagonalCross, color, secondary),
                BrushData.Texture => new TextureBrush(Image.FromFile("uia-uia-cat.png"), WrapMode.Clamp),
                BrushData.Gradient => new LinearGradientBrush(start, end, color, secondary),
                _ => throw new NotImplementedException()
            };
        }

        private void BrushClick(BrushData solid)
        {
            _currentBrush = solid;
        }

        private void ShapeClick(DrawShape shape)
        {
            _currentShape = shape;
        }


        private void WidthTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (float.TryParse(widthTextBox.Text, out float width))
            {
                if (width < 0)
                {
                    width = MathF.Abs(width);
                    widthTextBox.Text = width.ToString();
                    return;
                }
                _currentWith = width;
            }
        }

        private void ColorBtn_Click(object? sender, EventArgs e)
        {
            colorDialog.Color = _currentColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _currentColor = colorDialog.Color;
                colorBtn.BackColor = _currentColor;
            }
        }

        private bool CanDraw()
        {
            return _currentShape != Bai11.DrawShape.None &&
                _currentBrush != BrushData.None &&
                _currentWith > 0;
        }
    }
}
