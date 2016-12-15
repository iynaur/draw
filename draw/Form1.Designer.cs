namespace draw
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ellipseButton = new System.Windows.Forms.ToolStripButton();
            this.rectButton = new System.Windows.Forms.ToolStripButton();
            this.lineButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipseButton,
            this.rectButton,
            this.lineButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(551, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ellipseButton
            // 
            this.ellipseButton.AccessibleName = "EllipseButton";
            this.ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseButton.Image")));
            this.ellipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(23, 22);
            this.ellipseButton.Text = "EllipseButton";
            this.ellipseButton.Click += new System.EventHandler(this.ellipsepButton_Click);
            // 
            // rectButton
            // 
            this.rectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectButton.Image = ((System.Drawing.Image)(resources.GetObject("rectButton.Image")));
            this.rectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(23, 22);
            this.rectButton.Text = "toolStripButton2";
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
            this.lineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(23, 22);
            this.lineButton.Text = "toolStripButton3";
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 393);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private void Panel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //throw new System.NotImplementedException();
            endPoint = e.Location;
            Refresh();
            isDraw = false;
        }

        private void Panel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //throw new System.NotImplementedException();
            endPoint = e.Location;
            if (isDraw) Refresh();
        }

        private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //throw new System.NotImplementedException();
            startPoint = e.Location;
            isDraw = true;
        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ellipseButton;
        private System.Windows.Forms.ToolStripButton rectButton;
        private System.Windows.Forms.ToolStripButton lineButton;
        private System.Windows.Forms.Panel panel1;
        private System.Drawing.Point startPoint, endPoint;
        private System.Boolean isDraw;
        Category shape;
    }
}

