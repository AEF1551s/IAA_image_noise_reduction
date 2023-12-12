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
4. Wiener Filtering:

NL Means algoritma blokshēma (ar iespējamu veikstpējas uzlabojumu)
![NLMeans_flowchart_light](https://github.com/AEF1551s/IAA_image_noise_reduction/assets/65708516/43812530-e97f-4ccf-b314-a4f716a428b3)

Wiener Filter for Image Deconvolution

1. Image and Degradation Understanding:
Select a degraded image and understand the degradation process, identifying the Point Spread Function (PSF) and analyzing noise characteristics.

2. Preprocessing:
Load the image and consider color space conversion if necessary.

3. Fourier Transform Operations:
Apply Fourier Transform to the degraded image and PSF to obtain frequency domain representations.

4. Wiener Filter Transfer Function:
Calculate the Wiener filter transfer function based on the image and PSF in the frequency domain.

5. Image Deconvolution:
Multiply the degraded image's frequency domain representation by the Wiener filter transfer function and apply the
Inverse Fourier Transform.

6. Evaluation:
Visually assess the deconvoluted image, comparing it with the original and degraded versions.
