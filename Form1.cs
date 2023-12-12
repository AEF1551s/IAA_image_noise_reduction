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

        private void button_gausblur_Click(object sender, EventArgs e)
        {

        }
    }
}