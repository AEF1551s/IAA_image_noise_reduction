using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAA_image_noise_reduction
{
    public class NL_Means
    {
        //Algorithm attributes
        private int patch_size;
        private int search_area;
        private float sigma;
        private float threshold;

        //Image attributes
        private int height;
        private int width;

        //Image copy
        //width/height from image

        /// <summary>
        /// Update NL Means parameters
        /// </summary>
        public void update(int patch_size, int search_area, float sigma, float threshold)
        {
            this.patch_size = patch_size;
            this.search_area = search_area;
            this.sigma = sigma;
            this.threshold = threshold;
        }
        
        /// <summary>
        /// Create patch array for loaded image
        /// </summary>
        private void patch_array()
        {
            //Based on patch size, create array of patches.
        }

        private float guassian_weight(float sigma) 
        {
            float weight = 0;
            //Calculate gaussian weight for patch
            return weight;
        }

        private void compare_weights()
        {
            //compare wrights to reference weight, return list of tuples for the array indexes
        }
        
        private void patch_means()
        {
            //return mean value for similar patches in RGB
        }

        private void assign_color()
        {
            //assign new calculated mean value to reference pixel. 
        }
    }
}
