using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace IAA_image_noise_reduction
{
    public partial class Form1 : Form
    {
        private ImageClass ImageClass = new ImageClass();

        public Form1()
        {
            InitializeComponent();

            //Sets all groupbox to top of each other
            Point groupbox_locations = new Point(955, 185);
            nl_groupbox.Location = groupbox_locations;
            tvreg_groupbox.Location = groupbox_locations;   
            gblur_groupbox.Location = groupbox_locations;
            wfilter_groupbox.Location = groupbox_locations;
        }

        //Menu strip functions
        //File Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) { return; }
            //Pirmais attēls tiek nokopēts 
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //Otrais attēls tiek ievietots kā pikseļu komponentu masīvs
            Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            ImageClass.ReadImage(bmp);
            pictureBox2.Image = ImageClass.DrawImage(ImageClass.img_original);
        }

        //Algoritmu parametru attēlošana
        //Helper metode

        /// <summary>
        /// Displays the specified group box based on the given parameter representing different image processing techniques or filters.
        /// </summary>
        /// <param name="box">An integer value representing the type of group box to be displayed:
        /// 0 - NL Means,
        /// 1 - TV Regularization,
        /// 2 - Gaussian Blur,
        /// 3 - Weiner Filter. </param>
        private void show_groupbox(int box)
        {
            nl_groupbox.Visible = false;
            tvreg_groupbox.Visible = false;
            gblur_groupbox.Visible = false;
            wfilter_groupbox.Visible = false;

            switch (box)
            {
                case 0:
                    nl_groupbox.Visible = true;
                    break;
                case 1:
                    tvreg_groupbox.Visible = true;
                    break;
                case 2:
                    gblur_groupbox.Visible = true;
                    break;
                case 3:
                    wfilter_groupbox.Visible = true;
                    break;
                default:
                    break;

            }
            return;
        }

        //Helper function, to enable Apply button, when all algorithm parameters are valid
        private bool enable_apply_button(int mode)
        {
            bool enable = false;

            //Check if picture is loaded
            if (pictureBox2.Image == null)
            { 
                return false; 
            }
            //Check if all mode parameters are valid
            //TODO: Fill all algorithm paramter checks
            switch (mode)
            {
                case 0:
                    enable = true;
                    break;
                case 1:
                    enable = true;
                    break;
                case 2:
                    enable = true;
                    break;
                case 3:
                    enable = true;
                    break;
                default:
                    break;

            }

            return enable;
        }
        //NL Means
        //TODO: Add check (arrow and cross) for valid chosen parameter values
        private void button_nlmeans_Click(object sender, EventArgs e)
        {

            show_groupbox(0);
            button_denoise_apply.Enabled = enable_apply_button(0);
        }
        //Total variation regularization
        private void button_tvreg_Click(object sender, EventArgs e)
        {
            show_groupbox(1);
            button_denoise_apply.Enabled = enable_apply_button(1);
        }

        //Gaussian blur
        private void button_gblur_Click(object sender, EventArgs e)
        {
            show_groupbox(2);
            button_denoise_apply.Enabled = enable_apply_button(2);
        }

        //Wiener Filtering
        private void button_wfilter_Click(object sender, EventArgs e)
        {
            show_groupbox(3);
            button_denoise_apply.Enabled = enable_apply_button(3);
        }



    }
}