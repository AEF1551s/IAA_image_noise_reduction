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
        private void show_groupbox(int box) //0 for NL Means, 1 for TV regularization, 3 for Gaussian Blur, 4 for Weiner filter
        {
            switch (box)
            {
                case 0:
                    nl_group_box.Visible = true;
                    //ALL other groupbox.Visible = false;
                    break;
                case 1:
                    //tv reg box.Visible = true;
                    //ALL other groupbox.Visible = false;
                    break;
                case 2:
                    //Gaussianblur_box.Visible = true;
                    //ALL other groupbox.Visible = false;
                    break;
                case 3:
                    //Weiner filter.Visible = true;
                    //ALL other groupbox.Visible = false;
                    break;
                default:
                    break;

            }
            return;
        }
        //NL Means
        private void button_nlmeans_Click(object sender, EventArgs e)
        {
            nl_group_box.Visible = true;
            button_denoise_apply.Enabled = true;
        }

        //Total variation regularization

        //Gaussian blur

        //Wiener Filtering
    }
}