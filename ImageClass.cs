using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IAA_image_noise_reduction
{
    public class ImageClass
    {
        public PixelRGB[,] img_original;
        public PixelRGB[,] img_rgb;

        //All algorithms
        public NL_Means NL_Means = new NL_Means();

   

        public void ReadImage(Bitmap bmp)
        {
            img_original = new PixelRGB[bmp.Width, bmp.Height];
            img_rgb = new PixelRGB[bmp.Width, bmp.Height];

            var bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);

            IntPtr ptr = IntPtr.Zero;
            int pixelComponents;

            if (bmpData.PixelFormat == PixelFormat.Format24bppRgb) pixelComponents = 3;
            else if (bmpData.PixelFormat == PixelFormat.Format32bppArgb) pixelComponents = 4;
            else pixelComponents = 0;

            var row = new byte[bmp.Width * pixelComponents];

            for (int y = 0; y < bmp.Height; y++)
            {
                ptr = bmpData.Scan0 + y * bmpData.Stride;
                Marshal.Copy(ptr, row, 0, row.Length);

                for (int x = 0; x < bmp.Width; x++)
                {
                    img_original[x, y] = new PixelRGB(row[pixelComponents * x + 2],
                                                   row[pixelComponents * x + 1],
                                                   row[pixelComponents * x]);

                    img_rgb[x, y] = new PixelRGB(row[pixelComponents * x + 2],
                                                row[pixelComponents * x + 1],
                                                row[pixelComponents * x]);
                }
            }
            bmp.UnlockBits(bmpData);
        }

        public Bitmap DrawImage(PixelRGB[,] img)
        {
            IntPtr ptr = IntPtr.Zero;

            var bmp = new Bitmap(img.GetLength(0), img.GetLength(1),
                                    PixelFormat.Format24bppRgb);
            var bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                        ImageLockMode.WriteOnly, bmp.PixelFormat);
            var row = new byte[bmp.Width * 3];

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    row[3 * x + 2] = img[x, y].R;
                    row[3 * x + 1] = img[x, y].G;
                    row[3 * x] = img[x, y].B;
                }
                ptr = bmpData.Scan0 + y * bmpData.Stride;
                Marshal.Copy(row, 0, ptr, row.Length);
            }
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        
        //NL Means

        //Total variation regularization

        //Gaussian blur

        //Wiener Filtering
    }
}
