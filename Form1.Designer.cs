namespace IAA_image_noise_reduction
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            algoritm_group_box = new GroupBox();
            button_nlmeans = new Button();
            button_gausblur = new Button();
            button_tvreg = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(60, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(523, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 400);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1234, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // algoritm_group_box
            // 
            algoritm_group_box.Location = new Point(955, 177);
            algoritm_group_box.Name = "algoritm_group_box";
            algoritm_group_box.Size = new Size(252, 293);
            algoritm_group_box.TabIndex = 7;
            algoritm_group_box.TabStop = false;
            algoritm_group_box.Text = "Algoritma parametri";
            // 
            // button_nlmeans
            // 
            button_nlmeans.Location = new Point(955, 70);
            button_nlmeans.Name = "button_nlmeans";
            button_nlmeans.Size = new Size(124, 46);
            button_nlmeans.TabIndex = 8;
            button_nlmeans.Text = "NL Means";
            button_nlmeans.UseVisualStyleBackColor = true;
            // 
            // button_gausblur
            // 
            button_gausblur.Location = new Point(1085, 70);
            button_gausblur.Name = "button_gausblur";
            button_gausblur.Size = new Size(122, 46);
            button_gausblur.TabIndex = 9;
            button_gausblur.Text = "Gaussian blur ";
            button_gausblur.UseVisualStyleBackColor = true;
            button_gausblur.Click += button_gausblur_Click;
            // 
            // button_tvreg
            // 
            button_tvreg.Location = new Point(955, 125);
            button_tvreg.Name = "button_tvreg";
            button_tvreg.Size = new Size(124, 46);
            button_tvreg.TabIndex = 10;
            button_tvreg.Text = "TV Regulation";
            button_tvreg.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1085, 125);
            button4.Name = "button4";
            button4.Size = new Size(122, 46);
            button4.TabIndex = 11;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 512);
            Controls.Add(button4);
            Controls.Add(button_tvreg);
            Controls.Add(button_gausblur);
            Controls.Add(button_nlmeans);
            Controls.Add(algoritm_group_box);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "IAA Noise Reduction Algorithms";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private GroupBox algoritm_group_box;
        private Button button_nlmeans;
        private Button button_gausblur;
        private Button button_tvreg;
        private Button button4;
    }
}