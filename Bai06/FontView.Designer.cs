namespace Bai06
{
    partial class FontView
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
            flowLayout = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayout
            // 
            flowLayout.AutoScroll = true;
            flowLayout.BackColor = Color.White;
            flowLayout.Dock = DockStyle.Fill;
            flowLayout.FlowDirection = FlowDirection.TopDown;
            flowLayout.Location = new Point(0, 0);
            flowLayout.Name = "flowLayout";
            flowLayout.Size = new Size(603, 688);
            flowLayout.TabIndex = 0;
            flowLayout.WrapContents = false;
            // 
            // FontView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 688);
            Controls.Add(flowLayout);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FontView";
            Text = "All Fonts";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayout;
    }
}
