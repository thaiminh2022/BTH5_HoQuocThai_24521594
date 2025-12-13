
namespace Bai06
{
    public partial class FontView : Form
    {
        public FontView()
        {
            InitializeComponent();


            foreach (var item in FontFamily.Families)
            {
                var font = new Font(item, 14f);
                var size = TextRenderer.MeasureText(item.Name, font);
                size.Height = font.Height;
                var label = new Label
                {
                    Text = $@".{item.Name}",
                    Font = font,
                    Size = size,
                    MinimumSize = size,
                    Margin = new Padding(0, 3, 0, 3),

                };
                flowLayout.Controls.Add(label);
            }
        }
    }
}
