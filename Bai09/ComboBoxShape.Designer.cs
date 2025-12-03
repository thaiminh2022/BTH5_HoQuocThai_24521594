namespace Bai09
{
    partial class ComboBoxShape
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shapeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // shapeComboBox
            // 
            shapeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shapeComboBox.FormattingEnabled = true;
            shapeComboBox.Location = new Point(27, 43);
            shapeComboBox.Name = "shapeComboBox";
            shapeComboBox.Size = new Size(285, 28);
            shapeComboBox.TabIndex = 0;
            // 
            // ComboBoxShape
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(shapeComboBox);
            DoubleBuffered = true;
            Name = "ComboBoxShape";
            Text = "ComboBoxShape";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox shapeComboBox;
    }
}
