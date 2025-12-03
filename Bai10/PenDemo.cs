using System.Drawing.Drawing2D;
using System.Reflection;

namespace Bai10
{
    internal record LineInfo
    {
        public DashStyle DashStyle { get; init; }
        public float Width { get; init; }
        public LineJoin LineJoin { get; init; }
        public DashCap DashCap { get; init; }
        public LineCap StartCap { get; init; }
        public LineCap EndCap { get; init; }

        public PointF StartPos { get; init; }
        public PointF EndPos { get; init; }
    }

    public partial class PenDemo : Form
    {
        List<LineInfo> lines = [];
        bool drawing = false;

        PointF? startPos, endPos;
        public PenDemo()
        {
            InitializeComponent();

            PropertyInfo? doubleBuffered = typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            doubleBuffered?.SetValue(drawingPanel, true);

            drawingPanel.Paint += DrawingPanel_Paint;

            var styles = Enum.GetNames<DashStyle>();
            dashStyleComboBox.Items.AddRange(styles.Take(styles.Length - 1).ToArray());
            dashStyleComboBox.SelectedIndex = 0;

            lineJoinComboBox.Items.AddRange(Enum.GetNames<LineJoin>());
            lineJoinComboBox.SelectedIndex = 0;

            var dashCaps = Enum.GetNames<DashCap>();
            dashCapComboBox.Items.AddRange(dashCaps);
            dashCapComboBox.SelectedIndex = 0;

            startCapComboBox.Items.AddRange(dashCaps);
            startCapComboBox.SelectedIndex = 0;

            endCapComboBox.Items.AddRange(dashCaps);
            endCapComboBox.SelectedIndex = 0;

            List<float> sizes = [.. Enumerable.Range(1, 24)];
            dashWidthComboBox.Items.AddRange([.. sizes]);
            dashWidthComboBox.SelectedIndex = 0;


            dashStyleComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            lineJoinComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            dashCapComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            startCapComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            endCapComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            dashWidthComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();


            dashWidthComboBox.KeyDown += DashWidthComboBox_KeyDown;

            // mouse
            drawingPanel.MouseDown += DrawingPanel_MouseDown;
            drawingPanel.MouseUp += DrawingPanel_MouseUp;
            drawingPanel.MouseMove += DrawingPanel_MouseMove;
            drawingPanel.Invalidate();
            
            //tooltip
            widthTooltip.SetToolTip(dashWidthComboBox, "Nhập số và nhấn Enter để thêm kích thước tùy chỉnh");

        }

        private void DashWidthComboBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (float.TryParse(dashWidthComboBox.Text, out var value))
            {
                if (value <= 0)
                {
                    value = Math.Abs(value);
                }

                if (!dashWidthComboBox.Items.Contains(value))
                {
                    // insert sorted
                    
                    int index = 0;
                    while (index < dashWidthComboBox.Items.Count && (float?)dashWidthComboBox.Items[index] < value)
                    {
                        index++;
                    }

                    dashWidthComboBox.Items.Insert(index, value);
                }

                dashWidthComboBox.SelectedItem = value;
                drawingPanel.Invalidate();
            }
        }

        private void DrawingPanel_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!drawing || IsDrawBlocked() || startPos is null)
                return;

            endPos = e.Location;
            drawingPanel.Invalidate();


        }

        private void DrawingPanel_MouseUp(object? sender, MouseEventArgs e)
        {
            if (startPos is null)
                return;

            drawing = false;
            endPos = e.Location;

            lines.Add(new LineInfo
            {
                DashCap = GetSettingFromComboBox<DashCap>(dashCapComboBox) ?? DashCap.Flat,
                DashStyle = GetSettingFromComboBox<DashStyle>(dashStyleComboBox) ?? DashStyle.Solid,
                EndCap = GetSettingFromComboBox<LineCap>(endCapComboBox) ?? LineCap.Flat,
                LineJoin = GetSettingFromComboBox<LineJoin>(lineJoinComboBox) ?? LineJoin.Miter,
                StartCap = GetSettingFromComboBox<LineCap>(startCapComboBox) ?? LineCap.Flat,
                Width = GetSettingFromComboBox(dashWidthComboBox) ?? 1,
                StartPos = startPos.Value,
                EndPos = endPos.Value
            });

            startPos = null;
            endPos = null;

            drawingPanel.Invalidate();
        }

        private void DrawingPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lines.Clear();
                drawingPanel.Invalidate();
            }

            drawing = true;
            startPos = e.Location;
        }

        private bool IsDrawBlocked()
        {

            return dashStyleComboBox.SelectedIndex == -1 ||
                lineJoinComboBox.SelectedIndex == -1 ||
                dashCapComboBox.SelectedIndex == -1 ||
                startCapComboBox.SelectedIndex == -1 ||
                endCapComboBox.SelectedIndex == -1 ||
                dashWidthComboBox.SelectedIndex == -1;
        }
        private void DrawingPanel_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            MainDraw(g);
            LineDraw(g);
        }

        private void MainDraw(Graphics g)
        {
            if (IsDrawBlocked())
                return;

            if (startPos is null || endPos is null)
                return;

            using var pen = new Pen(Color.DarkBlue, 10);

            pen.DashStyle = GetSettingFromComboBox<DashStyle>(dashStyleComboBox) ?? pen.DashStyle;
            pen.LineJoin = GetSettingFromComboBox<LineJoin>(lineJoinComboBox) ?? pen.LineJoin;
            pen.DashCap = GetSettingFromComboBox<DashCap>(dashCapComboBox) ?? pen.DashCap;
            pen.StartCap = GetSettingFromComboBox<LineCap>(startCapComboBox) ?? pen.StartCap;
            pen.EndCap = GetSettingFromComboBox<LineCap>(endCapComboBox) ?? pen.EndCap;
            pen.Width = GetSettingFromComboBox(dashWidthComboBox) ?? pen.Width;

            g.DrawLine(pen, startPos.Value, endPos.Value);
        }

        private void LineDraw(Graphics g)
        {
            // line drawing
            foreach (var line in lines)
            {
                using var drawPen = new Pen(Color.DarkBlue, line.Width);
                drawPen.DashStyle = line.DashStyle;
                drawPen.LineJoin = line.LineJoin;
                drawPen.DashCap = line.DashCap;
                drawPen.StartCap = line.StartCap;
                drawPen.EndCap = line.EndCap;
                g.DrawLine(drawPen, line.StartPos, line.EndPos);
            }
        }

        private T? GetSettingFromComboBox<T>(ComboBox box) where T : struct
        {
            if (box.SelectedItem is null)
                return null;
            return Enum.Parse<T>(box.SelectedItem.ToString()!);
        }

        private float? GetSettingFromComboBox(ComboBox box)
        {
            if (box.SelectedItem is null)
                return null;

            if (float.TryParse(box.SelectedItem.ToString(), out var value))
            {
                return value;
            }
            return null;
        }
    }
}
