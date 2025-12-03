namespace Bai11
{
    partial class BasicShapeDrawer
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            shapeLineCheck = new RadioButton();
            shapeRectCheck = new RadioButton();
            shapeEllipseCheck = new RadioButton();
            groupBox2 = new GroupBox();
            label1 = new Label();
            widthTextBox = new TextBox();
            colorBtn = new Button();
            groupBox3 = new GroupBox();
            solidBrushCheck = new RadioButton();
            hatchBrushCheck = new RadioButton();
            textureBrushCheck = new RadioButton();
            gradientBrushCheck = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(962, 667);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 661);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(shapeEllipseCheck);
            groupBox1.Controls.Add(shapeRectCheck);
            groupBox1.Controls.Add(shapeLineCheck);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shapes";
            // 
            // shapeLineCheck
            // 
            shapeLineCheck.AutoSize = true;
            shapeLineCheck.Location = new Point(11, 31);
            shapeLineCheck.Name = "shapeLineCheck";
            shapeLineCheck.Size = new Size(57, 24);
            shapeLineCheck.TabIndex = 0;
            shapeLineCheck.TabStop = true;
            shapeLineCheck.Text = "Line";
            shapeLineCheck.UseVisualStyleBackColor = true;
            // 
            // shapeRectCheck
            // 
            shapeRectCheck.AutoSize = true;
            shapeRectCheck.Location = new Point(11, 61);
            shapeRectCheck.Name = "shapeRectCheck";
            shapeRectCheck.Size = new Size(96, 24);
            shapeRectCheck.TabIndex = 1;
            shapeRectCheck.TabStop = true;
            shapeRectCheck.Text = "Rectangle";
            shapeRectCheck.UseVisualStyleBackColor = true;
            // 
            // shapeEllipseCheck
            // 
            shapeEllipseCheck.AutoSize = true;
            shapeEllipseCheck.Location = new Point(11, 93);
            shapeEllipseCheck.Name = "shapeEllipseCheck";
            shapeEllipseCheck.Size = new Size(73, 24);
            shapeEllipseCheck.TabIndex = 2;
            shapeEllipseCheck.TabStop = true;
            shapeEllipseCheck.Text = "Ellipse";
            shapeEllipseCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(colorBtn);
            groupBox2.Controls.Add(widthTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(9, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 142);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(78, 37);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(125, 27);
            widthTextBox.TabIndex = 1;
            widthTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // colorBtn
            // 
            colorBtn.Location = new Point(69, 90);
            colorBtn.Name = "colorBtn";
            colorBtn.Size = new Size(134, 29);
            colorBtn.TabIndex = 2;
            colorBtn.Text = "Color...";
            colorBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(gradientBrushCheck);
            groupBox3.Controls.Add(textureBrushCheck);
            groupBox3.Controls.Add(hatchBrushCheck);
            groupBox3.Controls.Add(solidBrushCheck);
            groupBox3.Location = new Point(9, 321);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(267, 285);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Brushes";
            // 
            // solidBrushCheck
            // 
            solidBrushCheck.AutoSize = true;
            solidBrushCheck.Location = new Point(14, 39);
            solidBrushCheck.Name = "solidBrushCheck";
            solidBrushCheck.Size = new Size(104, 24);
            solidBrushCheck.TabIndex = 0;
            solidBrushCheck.TabStop = true;
            solidBrushCheck.Text = "Solid Brush";
            solidBrushCheck.UseVisualStyleBackColor = true;
            // 
            // hatchBrushCheck
            // 
            hatchBrushCheck.AutoSize = true;
            hatchBrushCheck.Location = new Point(14, 80);
            hatchBrushCheck.Name = "hatchBrushCheck";
            hatchBrushCheck.Size = new Size(109, 24);
            hatchBrushCheck.TabIndex = 1;
            hatchBrushCheck.TabStop = true;
            hatchBrushCheck.Text = "Hatch Brush";
            hatchBrushCheck.UseVisualStyleBackColor = true;
            // 
            // textureBrushCheck
            // 
            textureBrushCheck.AutoSize = true;
            textureBrushCheck.Location = new Point(14, 121);
            textureBrushCheck.Name = "textureBrushCheck";
            textureBrushCheck.Size = new Size(118, 24);
            textureBrushCheck.TabIndex = 2;
            textureBrushCheck.TabStop = true;
            textureBrushCheck.Text = "Texture Brush";
            textureBrushCheck.UseVisualStyleBackColor = true;
            // 
            // gradientBrushCheck
            // 
            gradientBrushCheck.AutoSize = true;
            gradientBrushCheck.Location = new Point(14, 161);
            gradientBrushCheck.Name = "gradientBrushCheck";
            gradientBrushCheck.Size = new Size(171, 24);
            gradientBrushCheck.TabIndex = 3;
            gradientBrushCheck.TabStop = true;
            gradientBrushCheck.Text = "Linear Gradient Brush";
            gradientBrushCheck.UseVisualStyleBackColor = true;
            // 
            // BasicShapeDrawer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 667);
            Controls.Add(tableLayoutPanel1);
            Name = "BasicShapeDrawer";
            Text = "Basic Shape Drawer";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox2;
        private TextBox widthTextBox;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton shapeEllipseCheck;
        private RadioButton shapeRectCheck;
        private RadioButton shapeLineCheck;
        private Button colorBtn;
        private GroupBox groupBox3;
        private RadioButton gradientBrushCheck;
        private RadioButton textureBrushCheck;
        private RadioButton hatchBrushCheck;
        private RadioButton solidBrushCheck;
    }
}
