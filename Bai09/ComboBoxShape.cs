namespace Bai09
{
    using ShapeItem = KeyValuePair<string, DrawOption>;
    enum DrawOption
    {
        Circle,
        Square,
        Ellipse,
        Pie,
        FilledCircle,
        FilledSquare,
        FilledEllipse,
        FilledPie,
    }



    public partial class ComboBoxShape : Form
    {

        DrawOption _currentOption = DrawOption.Circle;

        public ComboBoxShape()
        {
            InitializeComponent();

            var items = Enum.GetValues<DrawOption>()
                .Select(opt => new ShapeItem(opt.ToString(), opt))
                .ToList();

            shapeComboBox.DataSource = items;
            shapeComboBox.DisplayMember = "Key";
            shapeComboBox.ValueMember = "Value";

            shapeComboBox.SelectedValue = _currentOption;
            shapeComboBox.SelectedValueChanged += ShapeComboBox_SelectedValueChanged;

            Paint += ComboBoxShape_Paint;
            Resize += ComboBoxShape_Resize;
        }

        private void ComboBoxShape_Resize(object? sender, EventArgs e)
        {
            Invalidate();
        }

        private void ShapeComboBox_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (shapeComboBox.SelectedValue is not DrawOption op) return;
            _currentOption = op;
            Invalidate();
        }

        private void ComboBoxShape_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            var center = new PointF(ClientSize.Width / 2f - 100, ClientSize.Height / 2f - 100);
            var rect = new RectangleF(center, new SizeF(200, 200));
            using var pen = new Pen(Color.DarkRed, 5);

            switch (_currentOption)
            {
                case DrawOption.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
                case DrawOption.Square:
                    g.DrawRectangle(pen, rect);
                    break;
                case DrawOption.Ellipse:
                    rect.Size = new SizeF(300, 200);
                    g.DrawEllipse(pen, rect);
                    break;
                case DrawOption.Pie:
                    g.DrawPie(pen, rect, 0, 120);
                    break;
                case DrawOption.FilledCircle:
                    g.FillEllipse(Brushes.DarkRed, rect);
                    break;
                case DrawOption.FilledSquare:
                    g.FillRectangle(Brushes.DarkRed, rect);
                    break;
                case DrawOption.FilledEllipse:
                    rect.Size = new SizeF(300, 200);
                    g.FillEllipse(Brushes.DarkRed, rect);
                    break;
                case DrawOption.FilledPie:
                    g.FillPie(Brushes.DarkRed, rect, 0, 256);
                    break;
                default:
                    throw new NotImplementedException();
            }

        }
    }
}
