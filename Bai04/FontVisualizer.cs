
namespace Bai04
{
    using FontData = KeyValuePair<string, FontFamily>;
    public partial class FontVisualizer : Form
    {
        Font _currentFont;
        Color _currentColor;
        ContentAlignment _currentAlignment;

        public FontVisualizer()
        {
            InitializeComponent();
            _currentFont = new Font("Arial", 28, FontStyle.Underline);

            // Font setup
            var fontDatas = FontFamily.Families
                .Select(ff => new FontData(ff.Name, ff))
                .ToList();
            fontComboBox.DataSource = fontDatas;
            fontComboBox.DisplayMember = "Key";
            fontComboBox.ValueMember = "Value";

            fontComboBox.SelectedValue = _currentFont.FontFamily;

            List<float> defaultSizes = [
                 8f, 9f, 10f, 11f, 12f,
                14f, 16f, 18f, 20f, 22f, 24f, 26f,
                28f, 36f, 48f, 72f
            ];

            sizeComboBox.Items.AddRange([.. defaultSizes]);
            sizeComboBox.SelectedItem = _currentFont.Size;
            underlineCheck.Checked = true;
            testLabel.Font = _currentFont;

            fontComboBox.SelectedValueChanged += FontComboBox_SelectedValueChanged;
            sizeComboBox.SelectedValueChanged += SizeComboBox_SelectedValueChanged;

            // Color
            _currentColor = Color.HotPink;
            colorBtn.BackColor = _currentColor;
            testLabel.ForeColor = _currentColor;
            colorBtn.Click += ColorBtn_Click;


            // Alignment
            _currentAlignment = ContentAlignment.MiddleCenter;
            centerAlignBtn.Checked = true;
            testLabel.TextAlign = _currentAlignment;

            leftAlignBtn.Click += LeftAlignBtn_Click;
            rightAlignBtn.Click += RightAlignBtn_Click;
            centerAlignBtn.Click += CenterAlignBtn_Click;

            // Formating
            boldCheck.CheckedChanged += BoldCheck_CheckedChanged;
            italicCheck.CheckedChanged += ItalicCheck_CheckedChanged;
            underlineCheck.CheckedChanged += UnderlineCheck_CheckedChanged;


        }

        private void SizeComboBox_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (sizeComboBox.SelectedItem is not float size)
                return;

            _currentFont = new Font(_currentFont.FontFamily, size, _currentFont.Style);
            testLabel.Font = _currentFont;
        }

        private void FontComboBox_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (fontComboBox.SelectedValue is not FontFamily ff)
                return;

            _currentFont = new Font(ff, _currentFont.Size, _currentFont.Style);
            testLabel.Font = _currentFont;
        }

        private void UnderlineCheck_CheckedChanged(object? sender, EventArgs e)
        {
            var newStyle = _currentFont.Style ^ FontStyle.Underline;
            _currentFont = new Font(_currentFont.FontFamily, _currentFont.Size, newStyle);
            testLabel.Font = _currentFont;
        }

        private void ItalicCheck_CheckedChanged(object? sender, EventArgs e)
        {
            var newStyle = _currentFont.Style ^ FontStyle.Italic;
            _currentFont = new Font(_currentFont.FontFamily, _currentFont.Size, newStyle);
            testLabel.Font = _currentFont;
        }

        private void BoldCheck_CheckedChanged(object? sender, EventArgs e)
        {
            var newStyle = _currentFont.Style ^ FontStyle.Bold;
            _currentFont = new Font(_currentFont.FontFamily, _currentFont.Size, newStyle);
            testLabel.Font = _currentFont;
        }

        private void CenterAlignBtn_Click(object? sender, EventArgs e)
        {
            _currentAlignment = ContentAlignment.MiddleCenter;
            testLabel.TextAlign = _currentAlignment;
        }

        private void RightAlignBtn_Click(object? sender, EventArgs e)
        {
            _currentAlignment = ContentAlignment.MiddleRight;
            testLabel.TextAlign = _currentAlignment;
        }

        private void LeftAlignBtn_Click(object? sender, EventArgs e)
        {
            _currentAlignment = ContentAlignment.MiddleLeft;
            testLabel.TextAlign = _currentAlignment;
        }

        private void ColorBtn_Click(object? sender, EventArgs e)
        {
            colorDialog.Color = _currentColor;
            var res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                _currentColor = colorDialog.Color;
                colorBtn.BackColor = _currentColor;
                testLabel.ForeColor = _currentColor;
            }
        }
    }
}
