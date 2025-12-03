namespace Bai04
{
    partial class FontVisualizer
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
            label1 = new Label();
            label2 = new Label();
            fontComboBox = new ComboBox();
            sizeComboBox = new ComboBox();
            boldCheck = new CheckBox();
            italicCheck = new CheckBox();
            underlineCheck = new CheckBox();
            alignmentGroup = new GroupBox();
            rightAlignBtn = new RadioButton();
            centerAlignBtn = new RadioButton();
            leftAlignBtn = new RadioButton();
            label3 = new Label();
            colorDialog = new ColorDialog();
            colorBtn = new Button();
            testLabel = new Label();
            alignmentGroup.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(24, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 35);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(424, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 35);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // fontComboBox
            // 
            fontComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fontComboBox.FormattingEnabled = true;
            fontComboBox.Location = new Point(101, 52);
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(255, 28);
            fontComboBox.TabIndex = 2;
            // 
            // sizeComboBox
            // 
            sizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizeComboBox.FormattingEnabled = true;
            sizeComboBox.Location = new Point(488, 52);
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(105, 28);
            sizeComboBox.TabIndex = 3;
            // 
            // boldCheck
            // 
            boldCheck.AutoSize = true;
            boldCheck.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            boldCheck.Location = new Point(24, 100);
            boldCheck.Name = "boldCheck";
            boldCheck.Size = new Size(64, 50);
            boldCheck.TabIndex = 4;
            boldCheck.Text = "B";
            boldCheck.UseVisualStyleBackColor = true;
            // 
            // italicCheck
            // 
            italicCheck.AutoSize = true;
            italicCheck.Font = new Font("Segoe UI", 20F, FontStyle.Italic);
            italicCheck.Location = new Point(94, 100);
            italicCheck.Name = "italicCheck";
            italicCheck.Size = new Size(51, 50);
            italicCheck.TabIndex = 5;
            italicCheck.Text = "I";
            italicCheck.UseVisualStyleBackColor = true;
            // 
            // underlineCheck
            // 
            underlineCheck.AutoSize = true;
            underlineCheck.Font = new Font("Segoe UI", 20F, FontStyle.Underline);
            underlineCheck.Location = new Point(151, 100);
            underlineCheck.Name = "underlineCheck";
            underlineCheck.Size = new Size(65, 50);
            underlineCheck.TabIndex = 6;
            underlineCheck.Text = "U";
            underlineCheck.UseVisualStyleBackColor = true;
            // 
            // alignmentGroup
            // 
            alignmentGroup.Controls.Add(rightAlignBtn);
            alignmentGroup.Controls.Add(centerAlignBtn);
            alignmentGroup.Controls.Add(leftAlignBtn);
            alignmentGroup.Location = new Point(24, 178);
            alignmentGroup.Name = "alignmentGroup";
            alignmentGroup.Size = new Size(287, 144);
            alignmentGroup.TabIndex = 7;
            alignmentGroup.TabStop = false;
            alignmentGroup.Text = "Align Text";
            // 
            // rightAlignBtn
            // 
            rightAlignBtn.AutoSize = true;
            rightAlignBtn.Location = new Point(30, 97);
            rightAlignBtn.Name = "rightAlignBtn";
            rightAlignBtn.Size = new Size(65, 24);
            rightAlignBtn.TabIndex = 2;
            rightAlignBtn.TabStop = true;
            rightAlignBtn.Text = "Right";
            rightAlignBtn.UseVisualStyleBackColor = true;
            // 
            // centerAlignBtn
            // 
            centerAlignBtn.AutoSize = true;
            centerAlignBtn.Location = new Point(30, 67);
            centerAlignBtn.Name = "centerAlignBtn";
            centerAlignBtn.Size = new Size(73, 24);
            centerAlignBtn.TabIndex = 1;
            centerAlignBtn.TabStop = true;
            centerAlignBtn.Text = "Center";
            centerAlignBtn.UseVisualStyleBackColor = true;
            // 
            // leftAlignBtn
            // 
            leftAlignBtn.AutoSize = true;
            leftAlignBtn.Location = new Point(30, 37);
            leftAlignBtn.Name = "leftAlignBtn";
            leftAlignBtn.Size = new Size(55, 24);
            leftAlignBtn.TabIndex = 0;
            leftAlignBtn.TabStop = true;
            leftAlignBtn.Text = "Left";
            leftAlignBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(407, 94);
            label3.Name = "label3";
            label3.Size = new Size(75, 35);
            label3.TabIndex = 8;
            label3.Text = "Color";
            // 
            // colorBtn
            // 
            colorBtn.Location = new Point(488, 100);
            colorBtn.Name = "colorBtn";
            colorBtn.Size = new Size(58, 29);
            colorBtn.TabIndex = 9;
            colorBtn.UseVisualStyleBackColor = true;
            // 
            // testLabel
            // 
            testLabel.BackColor = Color.White;
            testLabel.Location = new Point(331, 178);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(359, 144);
            testLabel.TabIndex = 10;
            testLabel.Text = "Hello";
            // 
            // FontVisualizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 349);
            Controls.Add(testLabel);
            Controls.Add(colorBtn);
            Controls.Add(label3);
            Controls.Add(alignmentGroup);
            Controls.Add(underlineCheck);
            Controls.Add(italicCheck);
            Controls.Add(boldCheck);
            Controls.Add(sizeComboBox);
            Controls.Add(fontComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FontVisualizer";
            Text = "Font Visualizer";
            alignmentGroup.ResumeLayout(false);
            alignmentGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox fontComboBox;
        private ComboBox sizeComboBox;
        private CheckBox boldCheck;
        private CheckBox italicCheck;
        private CheckBox underlineCheck;
        private GroupBox alignmentGroup;
        private RadioButton rightAlignBtn;
        private RadioButton centerAlignBtn;
        private RadioButton leftAlignBtn;
        private Label label3;
        private ColorDialog colorDialog;
        private Button colorBtn;
        private Label testLabel;
    }
}
