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
            button_algo1 = new Button();
            button_algo2 = new Button();
            button_algo3 = new Button();
            button_algo4 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
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
            // button_algo1
            // 
            button_algo1.Location = new Point(940, 162);
            button_algo1.Name = "button_algo1";
            button_algo1.Size = new Size(212, 51);
            button_algo1.TabIndex = 2;
            button_algo1.Text = "algo1";
            button_algo1.UseVisualStyleBackColor = true;
            // 
            // button_algo2
            // 
            button_algo2.Location = new Point(940, 219);
            button_algo2.Name = "button_algo2";
            button_algo2.Size = new Size(212, 51);
            button_algo2.TabIndex = 3;
            button_algo2.Text = "algo2";
            button_algo2.UseVisualStyleBackColor = true;
            // 
            // button_algo3
            // 
            button_algo3.Location = new Point(940, 276);
            button_algo3.Name = "button_algo3";
            button_algo3.Size = new Size(212, 51);
            button_algo3.TabIndex = 4;
            button_algo3.Text = "algo3";
            button_algo3.UseVisualStyleBackColor = true;
            // 
            // button_algo4
            // 
            button_algo4.Location = new Point(940, 333);
            button_algo4.Name = "button_algo4";
            button_algo4.Size = new Size(212, 51);
            button_algo4.TabIndex = 5;
            button_algo4.Text = "algo4";
            button_algo4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1164, 24);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 561);
            Controls.Add(button_algo4);
            Controls.Add(button_algo3);
            Controls.Add(button_algo2);
            Controls.Add(button_algo1);
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
        private Button button_algo1;
        private Button button_algo2;
        private Button button_algo3;
        private Button button_algo4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
    }
}