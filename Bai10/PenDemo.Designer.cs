namespace Bai10
{
    partial class PenDemo
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            endCapComboBox = new ComboBox();
            label6 = new Label();
            startCapComboBox = new ComboBox();
            label5 = new Label();
            dashCapComboBox = new ComboBox();
            label4 = new Label();
            dashWidthComboBox = new ComboBox();
            label3 = new Label();
            lineJoinComboBox = new ComboBox();
            label2 = new Label();
            dashStyleComboBox = new ComboBox();
            label1 = new Label();
            drawingPanel = new Panel();
            widthTooltip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.625F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(drawingPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 410);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(endCapComboBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(startCapComboBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dashCapComboBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dashWidthComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lineJoinComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dashStyleComboBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 404);
            panel1.TabIndex = 0;
            // 
            // endCapComboBox
            // 
            endCapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            endCapComboBox.FormattingEnabled = true;
            endCapComboBox.Location = new Point(96, 334);
            endCapComboBox.Name = "endCapComboBox";
            endCapComboBox.Size = new Size(165, 28);
            endCapComboBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 337);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 10;
            label6.Text = "End Cap:";
            // 
            // startCapComboBox
            // 
            startCapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            startCapComboBox.FormattingEnabled = true;
            startCapComboBox.Location = new Point(96, 263);
            startCapComboBox.Name = "startCapComboBox";
            startCapComboBox.Size = new Size(165, 28);
            startCapComboBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 266);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "Start Cap:";
            // 
            // dashCapComboBox
            // 
            dashCapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dashCapComboBox.FormattingEnabled = true;
            dashCapComboBox.Location = new Point(96, 192);
            dashCapComboBox.Name = "dashCapComboBox";
            dashCapComboBox.Size = new Size(165, 28);
            dashCapComboBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 195);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Dash Cap:";
            // 
            // dashWidthComboBox
            // 
            dashWidthComboBox.FormattingEnabled = true;
            dashWidthComboBox.Location = new Point(96, 73);
            dashWidthComboBox.Name = "dashWidthComboBox";
            dashWidthComboBox.Size = new Size(165, 28);
            dashWidthComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 76);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Width:";
            // 
            // lineJoinComboBox
            // 
            lineJoinComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lineJoinComboBox.FormattingEnabled = true;
            lineJoinComboBox.Location = new Point(96, 131);
            lineJoinComboBox.Name = "lineJoinComboBox";
            lineJoinComboBox.Size = new Size(165, 28);
            lineJoinComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 134);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Line Join:";
            // 
            // dashStyleComboBox
            // 
            dashStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dashStyleComboBox.FormattingEnabled = true;
            dashStyleComboBox.Location = new Point(96, 15);
            dashStyleComboBox.Name = "dashStyleComboBox";
            dashStyleComboBox.Size = new Size(165, 28);
            dashStyleComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Dash Style:";
            // 
            // drawingPanel
            // 
            drawingPanel.Dock = DockStyle.Fill;
            drawingPanel.Location = new Point(294, 3);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(503, 404);
            drawingPanel.TabIndex = 1;
            // 
            // PenDemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 410);
            Controls.Add(tableLayoutPanel1);
            Name = "PenDemo";
            Text = "PenDemo";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox dashStyleComboBox;
        private Label label1;
        private ComboBox endCapComboBox;
        private Label label6;
        private ComboBox startCapComboBox;
        private Label label5;
        private ComboBox dashCapComboBox;
        private Label label4;
        private ComboBox dashWidthComboBox;
        private Label label3;
        private ComboBox lineJoinComboBox;
        private Label label2;
        private Panel drawingPanel;
        private ToolTip widthTooltip;
    }
}
