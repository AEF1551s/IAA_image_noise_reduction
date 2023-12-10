# IAA trokšņu noņemšana attēlos  
Grupas darbs kas veikts kā kursa darbs priekšmetā "Ievads attēlu apstrādē" 3. kursā DITF.

## Izstrādātāji
* Krišjānis Ivbulis - AEF1551s
* Artis Čevers - NomadBBY
* Māris Vītols - likaiZnazis
* Dāvis Stepanskis - Robokops1

## Realizētie algoritmi
Kopā tiek realizēti 4 dažādi trokšņu noņemšanas algoritmi attēliem:
1. Non-Local means
2. Total variation regularization
3. Gaussian blur
4. tiek izvēlets..

NL Means algoritma blokshēma (ar iespējamu veikstpējas uzlabojumu)
![NLMeans_flowchart_light](https://github.com/AEF1551s/IAA_image_noise_reduction/assets/65708516/43812530-e97f-4ccf-b314-a4f716a428b3)

##Ideja TotalVariationDenoise
Load Noisy Image:

1. Begin by loading the noisy image that you want to denoise. This image has unwanted noise that you aim to reduce while preserving important features.
Convert to Grayscale Array:

2. Convert the noisy image to a 2D array of grayscale values. Each pixel in the array represents the intensity of the corresponding pixel in the image.
Total Variation Denoising:

3. Initialize an estimate of the denoised image. This can be done by starting with the grayscale array from the noisy image.

4. Iterate through a specified number of iterations (e.g., 100 iterations):

5. Update the estimate of the denoised image using an iterative algorithm like Chambolle's method. This algorithm minimizes a cost function that includes a data fidelity term and a Total Variation regularization term.

6. The Total Variation regularization term encourages smoothness in the image, suppressing noise while preserving edges and details.

7. Convert to Bitmap:

8. Once the denoising process is complete, convert the resulting 2D array of grayscale values back into a bitmap image.
Save Denoised Image:

9. Save the denoised image to a file for further analysis or presentation.
