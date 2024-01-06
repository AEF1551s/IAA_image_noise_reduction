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
            saveToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pictureToolStripMenuItem = new ToolStripMenuItem();
            logToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            nl_groupbox = new GroupBox();
            comboBox_nl_area = new ComboBox();
            comboBox_nl_sigma = new ComboBox();
            comboBox_nl_patchsize = new ComboBox();
            label_nl_tresh = new Label();
            label_nl_area = new Label();
            label_nl_sigma = new Label();
            label_nl_patchsize = new Label();
            comboBox_nl_tresh = new ComboBox();
            tvreg_groupbox = new GroupBox();
            label_tvreg_params = new Label();
            gblur_groupbox = new GroupBox();
            label_gblur_params = new Label();
            wfilter_groupbox = new GroupBox();
            label_wfilter_params = new Label();
            button_denoise_apply = new Button();
            button_nlmeans = new Button();
            button_gblur = new Button();
            button_tvreg = new Button();
            button_wfilter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            nl_groupbox.SuspendLayout();
            tvreg_groupbox.SuspendLayout();
            gblur_groupbox.SuspendLayout();
            wfilter_groupbox.SuspendLayout();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, pictureToolStripMenuItem, logToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1234, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, aboutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(107, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(107, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(107, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // pictureToolStripMenuItem
            // 
            pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            pictureToolStripMenuItem.Size = new Size(47, 20);
            pictureToolStripMenuItem.Text = "Reset";
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem1 });
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(39, 20);
            logToolStripMenuItem.Text = "Log";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(107, 22);
            viewToolStripMenuItem.Text = "View";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(107, 22);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // nl_groupbox
            // 
            nl_groupbox.Controls.Add(comboBox_nl_area);
            nl_groupbox.Controls.Add(comboBox_nl_sigma);
            nl_groupbox.Controls.Add(comboBox_nl_patchsize);
            nl_groupbox.Controls.Add(label_nl_tresh);
            nl_groupbox.Controls.Add(label_nl_area);
            nl_groupbox.Controls.Add(label_nl_sigma);
            nl_groupbox.Controls.Add(label_nl_patchsize);
            nl_groupbox.Controls.Add(comboBox_nl_tresh);
            nl_groupbox.Location = new Point(955, 185);
            nl_groupbox.Name = "nl_groupbox";
            nl_groupbox.Size = new Size(252, 248);
            nl_groupbox.TabIndex = 7;
            nl_groupbox.TabStop = false;
            nl_groupbox.Text = "Algoritma parametri";
            nl_groupbox.Visible = false;
            // 
            // comboBox_nl_area
            // 
            comboBox_nl_area.FormattingEnabled = true;
            comboBox_nl_area.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            comboBox_nl_area.Location = new Point(20, 151);
            comboBox_nl_area.Name = "comboBox_nl_area";
            comboBox_nl_area.Size = new Size(121, 23);
            comboBox_nl_area.TabIndex = 6;
            comboBox_nl_area.Text = "10";
            // 
            // comboBox_nl_sigma
            // 
            comboBox_nl_sigma.FormattingEnabled = true;
            comboBox_nl_sigma.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            comboBox_nl_sigma.Location = new Point(19, 96);
            comboBox_nl_sigma.Name = "comboBox_nl_sigma";
            comboBox_nl_sigma.Size = new Size(121, 23);
            comboBox_nl_sigma.TabIndex = 5;
            comboBox_nl_sigma.Text = "1";
            // 
            // comboBox_nl_patchsize
            // 
            comboBox_nl_patchsize.FormattingEnabled = true;
            comboBox_nl_patchsize.Items.AddRange(new object[] { "3", "5", "7", "9", "11" });
            comboBox_nl_patchsize.Location = new Point(19, 41);
            comboBox_nl_patchsize.Name = "comboBox_nl_patchsize";
            comboBox_nl_patchsize.Size = new Size(121, 23);
            comboBox_nl_patchsize.TabIndex = 4;
            comboBox_nl_patchsize.Text = "3";
            // 
            // label_nl_tresh
            // 
            label_nl_tresh.AutoSize = true;
            label_nl_tresh.Location = new Point(19, 188);
            label_nl_tresh.Name = "label_nl_tresh";
            label_nl_tresh.Size = new Size(103, 15);
            label_nl_tresh.TabIndex = 3;
            label_nl_tresh.Text = "Similarity Treshold";
            // 
            // label_nl_area
            // 
            label_nl_area.AutoSize = true;
            label_nl_area.Location = new Point(19, 133);
            label_nl_area.Name = "label_nl_area";
            label_nl_area.Size = new Size(69, 15);
            label_nl_area.TabIndex = 2;
            label_nl_area.Text = "Search Area";
            // 
            // label_nl_sigma
            // 
            label_nl_sigma.AutoSize = true;
            label_nl_sigma.Location = new Point(19, 78);
            label_nl_sigma.Name = "label_nl_sigma";
            label_nl_sigma.Size = new Size(40, 15);
            label_nl_sigma.TabIndex = 1;
            label_nl_sigma.Text = "Sigma";
            // 
            // label_nl_patchsize
            // 
            label_nl_patchsize.AutoSize = true;
            label_nl_patchsize.Location = new Point(19, 23);
            label_nl_patchsize.Name = "label_nl_patchsize";
            label_nl_patchsize.Size = new Size(60, 15);
            label_nl_patchsize.TabIndex = 0;
            label_nl_patchsize.Text = "Patch Size";
            // 
            // comboBox_nl_tresh
            // 
            comboBox_nl_tresh.FormattingEnabled = true;
            comboBox_nl_tresh.Items.AddRange(new object[] { "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "0.10", "0.11", "0.12", "0.13", "0.14", "0.15", "0.16", "0.17", "0.18", "0.19", "0.20", "0.21", "0.22", "0.23", "0.24", "0.25", "0.26", "0.27", "0.28", "0.29", "0.30", "0.31", "0.32", "0.33", "0.34", "0.35", "0.36", "0.37", "0.38", "0.39", "0.40", "0.41", "0.42", "0.43", "0.44", "0.45", "0.46", "0.47", "0.48", "0.49", "0.50", "0.51", "0.52", "0.53", "0.54", "0.55", "0.56", "0.57", "0.58", "0.59", "0.60", "0.61", "0.62", "0.63", "0.64", "0.65", "0.66", "0.67", "0.68", "0.69", "0.70", "0.71", "0.72", "0.73", "0.74", "0.75", "0.76", "0.77", "0.78", "0.79", "0.80", "0.81", "0.82", "0.83", "0.84", "0.85", "0.86", "0.87", "0.88", "0.89", "0.90", "0.91", "0.92", "0.93", "0.94", "0.95", "0.96", "0.97", "0.98", "0.99", "0.100" });
            comboBox_nl_tresh.Location = new Point(19, 206);
            comboBox_nl_tresh.Name = "comboBox_nl_tresh";
            comboBox_nl_tresh.Size = new Size(121, 23);
            comboBox_nl_tresh.TabIndex = 7;
            comboBox_nl_tresh.Text = "0.5";
            // 
            // tvreg_groupbox
            // 
            tvreg_groupbox.Controls.Add(label_tvreg_params);
            tvreg_groupbox.Location = new Point(83, 168);
            tvreg_groupbox.Name = "tvreg_groupbox";
            tvreg_groupbox.Size = new Size(252, 248);
            tvreg_groupbox.TabIndex = 9;
            tvreg_groupbox.TabStop = false;
            tvreg_groupbox.Text = "Algoritma parametri";
            tvreg_groupbox.Visible = false;
            // 
            // label_tvreg_params
            // 
            label_tvreg_params.AutoSize = true;
            label_tvreg_params.Location = new Point(19, 23);
            label_tvreg_params.Name = "label_tvreg_params";
            label_tvreg_params.Size = new Size(142, 15);
            label_tvreg_params.TabIndex = 0;
            label_tvreg_params.Text = "TV Regulation Parameters";
            // 
            // gblur_groupbox
            // 
            gblur_groupbox.Controls.Add(label_gblur_params);
            gblur_groupbox.Location = new Point(359, 168);
            gblur_groupbox.Name = "gblur_groupbox";
            gblur_groupbox.Size = new Size(252, 248);
            gblur_groupbox.TabIndex = 8;
            gblur_groupbox.TabStop = false;
            gblur_groupbox.Text = "Algoritma parametri";
            gblur_groupbox.Visible = false;
            // 
            // label_gblur_params
            // 
            label_gblur_params.AutoSize = true;
            label_gblur_params.Location = new Point(19, 23);
            label_gblur_params.Name = "label_gblur_params";
            label_gblur_params.Size = new Size(140, 15);
            label_gblur_params.TabIndex = 0;
            label_gblur_params.Text = "Gaussian Blur Parameters";
            // 
            // wfilter_groupbox
            // 
            wfilter_groupbox.Controls.Add(label_wfilter_params);
            wfilter_groupbox.Location = new Point(628, 168);
            wfilter_groupbox.Name = "wfilter_groupbox";
            wfilter_groupbox.Size = new Size(252, 248);
            wfilter_groupbox.TabIndex = 10;
            wfilter_groupbox.TabStop = false;
            wfilter_groupbox.Text = "Algoritma parametri";
            wfilter_groupbox.Visible = false;
            // 
            // label_wfilter_params
            // 
            label_wfilter_params.AutoSize = true;
            label_wfilter_params.Location = new Point(19, 23);
            label_wfilter_params.Name = "label_wfilter_params";
            label_wfilter_params.Size = new Size(133, 15);
            label_wfilter_params.TabIndex = 0;
            label_wfilter_params.Text = "Weiner filter parameters";
            // 
            // button_denoise_apply
            // 
            button_denoise_apply.Enabled = false;
            button_denoise_apply.Location = new Point(974, 447);
            button_denoise_apply.Name = "button_denoise_apply";
            button_denoise_apply.Size = new Size(216, 23);
            button_denoise_apply.TabIndex = 8;
            button_denoise_apply.Text = "Apply";
            button_denoise_apply.UseVisualStyleBackColor = true;
            // 
            // button_nlmeans
            // 
            button_nlmeans.Location = new Point(955, 70);
            button_nlmeans.Name = "button_nlmeans";
            button_nlmeans.Size = new Size(124, 46);
            button_nlmeans.TabIndex = 8;
            button_nlmeans.Text = "NL Means";
            button_nlmeans.UseVisualStyleBackColor = true;
            button_nlmeans.Click += button_nlmeans_Click;
            // 
            // button_gblur
            // 
            button_gblur.Location = new Point(1085, 70);
            button_gblur.Name = "button_gblur";
            button_gblur.Size = new Size(122, 46);
            button_gblur.TabIndex = 9;
            button_gblur.Text = "Gaussian Blur ";
            button_gblur.UseVisualStyleBackColor = true;
            button_gblur.Click += button_gblur_Click;
            // 
            // button_tvreg
            // 
            button_tvreg.Location = new Point(955, 125);
            button_tvreg.Name = "button_tvreg";
            button_tvreg.Size = new Size(124, 46);
            button_tvreg.TabIndex = 10;
            button_tvreg.Text = "TV Regulation";
            button_tvreg.UseVisualStyleBackColor = true;
            button_tvreg.Click += button_tvreg_Click;
            // 
            // button_wfilter
            // 
            button_wfilter.Location = new Point(1085, 125);
            button_wfilter.Name = "button_wfilter";
            button_wfilter.Size = new Size(122, 46);
            button_wfilter.TabIndex = 11;
            button_wfilter.Text = "Wiener Filtering";
            button_wfilter.UseVisualStyleBackColor = true;
            button_wfilter.Click += button_wfilter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 512);
            Controls.Add(wfilter_groupbox);
            Controls.Add(tvreg_groupbox);
            Controls.Add(gblur_groupbox);
            Controls.Add(nl_groupbox);
            Controls.Add(button_denoise_apply);
            Controls.Add(button_wfilter);
            Controls.Add(button_tvreg);
            Controls.Add(button_gblur);
            Controls.Add(button_nlmeans);
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
            nl_groupbox.ResumeLayout(false);
            nl_groupbox.PerformLayout();
            tvreg_groupbox.ResumeLayout(false);
            tvreg_groupbox.PerformLayout();
            gblur_groupbox.ResumeLayout(false);
            gblur_groupbox.PerformLayout();
            wfilter_groupbox.ResumeLayout(false);
            wfilter_groupbox.PerformLayout();
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
        private GroupBox nl_groupbox;
        private Button button_nlmeans;
        private Button button_gblur;
        private Button button_tvreg;
        private Button button_wfilter;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem pictureToolStripMenuItem;
        private Label label_nl_tresh;
        private Label label_nl_area;
        private Label label_nl_sigma;
        private Label label_nl_patchsize;
        private ComboBox comboBox_nl_patchsize;
        private ComboBox comboBox_nl_tresh;
        private ComboBox comboBox_nl_area;
        private ComboBox comboBox_nl_sigma;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button button_denoise_apply;
        private GroupBox gblur_groupbox;
        private Label label_gblur_params;
        private GroupBox tvreg_groupbox;
        private Label label_tvreg_params;
        private GroupBox wfilter_groupbox;
        private Label label_wfilter_params;
    }
}