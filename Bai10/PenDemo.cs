using System.Drawing.Drawing2D;
using System.Reflection;

namespace Bai10
{

    public partial class PenDemo : Form
    {
        public PenDemo()
        {
            InitializeComponent();

            PropertyInfo? doubleBuffered = typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            doubleBuffered?.SetValue(drawingPanel, true);

            drawingPanel.Paint += DrawingPanel_Paint;

            var styles = Enum.GetNames<DashStyle>();
            dashStyleComboBox.Items.AddRange(styles.Take(styles.Length - 1).ToArray<object>());
            dashStyleComboBox.SelectedIndex = 0;

            lineJoinComboBox.Items.AddRange([..Enum.GetNames<LineJoin>()]);
            lineJoinComboBox.SelectedIndex = 0;

            object[] dashCaps = [..Enum.GetNames<DashCap>()];
            dashCapComboBox.Items.AddRange(dashCaps);
            dashCapComboBox.SelectedIndex = 0;

            startCapComboBox.Items.AddRange(dashCaps);
            startCapComboBox.SelectedIndex = 0;

            endCapComboBox.Items.AddRange(dashCaps);
            endCapComboBox.SelectedIndex = 0;

            List<float> sizes = [.. Enumerable.Range(1, 24)];
            dashWidthComboBox.Items.AddRange([.. sizes]);
            dashWidthComboBox.SelectedIndex = 15;


            dashStyleComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            lineJoinComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            dashCapComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            startCapComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            endCapComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();
            dashWidthComboBox.SelectedIndexChanged += (_, _) => drawingPanel.Invalidate();


            dashWidthComboBox.KeyDown += DashWidthComboBox_KeyDown;

            
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
        }

        private void MainDraw(Graphics g)
        {
            if (IsDrawBlocked())
                return;

            using var pen = new Pen(Color.Red, 10);

            pen.DashStyle = GetSettingFromComboBox<DashStyle>(dashStyleComboBox) ?? pen.DashStyle;
            pen.LineJoin = GetSettingFromComboBox<LineJoin>(lineJoinComboBox) ?? pen.LineJoin;
            pen.DashCap = GetSettingFromComboBox<DashCap>(dashCapComboBox) ?? pen.DashCap;
            pen.StartCap = GetSettingFromComboBox<LineCap>(startCapComboBox) ?? pen.StartCap;
            pen.EndCap = GetSettingFromComboBox<LineCap>(endCapComboBox) ?? pen.EndCap;
            pen.Width = GetSettingFromComboBox(dashWidthComboBox) ?? pen.Width;

            g.DrawLine(pen,30, 30, 200, 250);

            using var path = new GraphicsPath();
            path.AddLine(30, 300, 250, 350);
            path.AddLine(250, 350, 400, 100);


            g.DrawPath(pen, path);

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
