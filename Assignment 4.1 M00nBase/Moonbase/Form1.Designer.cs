namespace Moonbase
{
    partial class MoonbaseAssignment1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoonbaseAssignment1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.luxuryPackage1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minMassageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minFacialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manicurePedicureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.elegantPackage2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minMassageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minFacialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.comfortPackage3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minMassageToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshPackage4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minFacialToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(1361, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(16, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 231);
            this.panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(27, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(419, 189);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(509, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luxuryPackage1ToolStripMenuItem,
            this.toolStripSeparator1,
            this.elegantPackage2ToolStripMenuItem,
            this.toolStripSeparator2,
            this.comfortPackage3ToolStripMenuItem,
            this.toolStripSeparator3,
            this.refreshPackage4ToolStripMenuItem,
            this.toolStripSeparator4});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(121, 24);
            this.toolStripDropDownButton1.Text = "Select Package";
            // 
            // luxuryPackage1ToolStripMenuItem
            // 
            this.luxuryPackage1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minMassageToolStripMenuItem,
            this.minFacialToolStripMenuItem,
            this.manicurePedicureToolStripMenuItem});
            this.luxuryPackage1ToolStripMenuItem.Name = "luxuryPackage1ToolStripMenuItem";
            this.luxuryPackage1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.luxuryPackage1ToolStripMenuItem.Text = "Luxury Package 1";
            // 
            // minMassageToolStripMenuItem
            // 
            this.minMassageToolStripMenuItem.Name = "minMassageToolStripMenuItem";
            this.minMassageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.minMassageToolStripMenuItem.Text = "Min Massage";
            // 
            // minFacialToolStripMenuItem
            // 
            this.minFacialToolStripMenuItem.Name = "minFacialToolStripMenuItem";
            this.minFacialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.minFacialToolStripMenuItem.Text = "Min Facial";
            // 
            // manicurePedicureToolStripMenuItem
            // 
            this.manicurePedicureToolStripMenuItem.Name = "manicurePedicureToolStripMenuItem";
            this.manicurePedicureToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manicurePedicureToolStripMenuItem.Text = "Manicure Pedicure";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // elegantPackage2ToolStripMenuItem
            // 
            this.elegantPackage2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minMassageToolStripMenuItem1,
            this.minFacialToolStripMenuItem1});
            this.elegantPackage2ToolStripMenuItem.Name = "elegantPackage2ToolStripMenuItem";
            this.elegantPackage2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.elegantPackage2ToolStripMenuItem.Text = "Elegant Package 2";
            // 
            // minMassageToolStripMenuItem1
            // 
            this.minMassageToolStripMenuItem1.Name = "minMassageToolStripMenuItem1";
            this.minMassageToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.minMassageToolStripMenuItem1.Text = "Min Massage";
            // 
            // minFacialToolStripMenuItem1
            // 
            this.minFacialToolStripMenuItem1.Name = "minFacialToolStripMenuItem1";
            this.minFacialToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.minFacialToolStripMenuItem1.Text = "Min Facial";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // comfortPackage3ToolStripMenuItem
            // 
            this.comfortPackage3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minMassageToolStripMenuItem2});
            this.comfortPackage3ToolStripMenuItem.Name = "comfortPackage3ToolStripMenuItem";
            this.comfortPackage3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comfortPackage3ToolStripMenuItem.Text = "Comfort Package 3";
            // 
            // minMassageToolStripMenuItem2
            // 
            this.minMassageToolStripMenuItem2.Name = "minMassageToolStripMenuItem2";
            this.minMassageToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.minMassageToolStripMenuItem2.Text = "Min Massage";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // refreshPackage4ToolStripMenuItem
            // 
            this.refreshPackage4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minFacialToolStripMenuItem2});
            this.refreshPackage4ToolStripMenuItem.Name = "refreshPackage4ToolStripMenuItem";
            this.refreshPackage4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.refreshPackage4ToolStripMenuItem.Text = "Refresh Package 4";
            // 
            // minFacialToolStripMenuItem2
            // 
            this.minFacialToolStripMenuItem2.Name = "minFacialToolStripMenuItem2";
            this.minFacialToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.minFacialToolStripMenuItem2.Text = "Min Facial";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moonbase Healing Station";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(357, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 322);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click here for 20% off treatment!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(42, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Nav Device";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(136, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "South";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(210, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "East";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(43, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "West";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(136, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "North";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MoonbaseAssignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 977);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MoonbaseAssignment1";
            this.Text = "Moonbase Assignment 1";
            this.Load += new System.EventHandler(this.MoonbaseAssignment1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem luxuryPackage1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minMassageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minFacialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manicurePedicureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem elegantPackage2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minMassageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minFacialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem comfortPackage3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minMassageToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem refreshPackage4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minFacialToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
