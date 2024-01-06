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
4. Wiener Filtering

## *NL Means* algoritma blokshēma (ar iespējamu veikstpējas uzlabojumu)
![NLMeans_flowchart_light](https://github.com/AEF1551s/IAA_image_noise_reduction/assets/65708516/43812530-e97f-4ccf-b314-a4f716a428b3)

## *Total Variation Denoising* algoritma galvenie soļi

![image](https://github.com/AEF1551s/IAA_image_noise_reduction/assets/89861525/cd844f05-355c-4494-882b-55acb514b1a3)

Total Variation Denoising is a digital image processing algorithm designed to reduce noise in images while preserving important features and edges. The algorithm follows a series of key steps to achieve effective denoising.

1. Load Noisy Image:

2. Start by loading the noisy image that contains unwanted artifacts or disturbances.
Convert to Grayscale Array:

3. Convert the noisy image into a 2D array of grayscale values. Each element in the array represents the intensity of the corresponding pixel in the original image.
Total Variation Denoising:

4. Initialize an estimate of the denoised image, often starting with the grayscale array derived from the noisy image.
Iterative Optimization:

5. Iteratively update the estimate of the denoised image over a specified number of iterations (e.g., 100 iterations).
Utilize an iterative algorithm, such as Chambolle's method, to minimize a cost function that includes a data fidelity term and a Total Variation regularization term.
Total Variation Regularization:

6. The Total Variation regularization term promotes smoothness in the image, effectively suppressing noise while preserving edges and essential details.
Convert to Bitmap:

7. Once the denoising process is complete, convert the resulting 2D array of grayscale values back into a bitmap image format.
Save Denoised Image:

Save the denoised image to a file for further analysis, presentation, or integration into other applications.
Total Variation Denoising is particularly valuable in applications where image clarity is crucial, such as medical imaging, computer vision, and various scientific fields. By balancing noise reduction with the preservation of image structure, this algorithm contributes to enhancing the overall visual quality of images affected by unwanted disturbances.

## Gaussian blur
### Apraksts
Metodes mērķis ir izkliedēt attēlu tā, lai samazinās attēla troksnis, kontrastā tas arī zaudē attēla detaļas. Metode izmanto [Gausa funkciju](https://en.wikipedia.org/wiki/Gaussian_function), lai aprēķinātu izmaiņas katram pikselim. Metodei piemīt divi veida vienādojumi: vienas vai divas dimensijas vienādojumi.

Abi vienādojumi:
![vienas_dimensijas_vienadojums](https://i.stack.imgur.com/lXRKO.png)
</n>
</n>
x - attālums no sākuma punkta horizontālajā asī
y - attālums no sākuma punkta vertikālajā asī
σ - gausa sadalijuma standartnovirze = ievada lietotājs

Trokšņa uzlabošanas piemērs:
</n>
</n>
![gaussian_blur_example](https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Halftone%2C_Gaussian_Blur.jpg/220px-Halftone%2C_Gaussian_Blur.jpg)

### Implemetācija
Ir divi iespējami veidi kā Gausa izkliedēšanu implementēt, jo ir divi vienādojumi. 
        
Vienas dimensijas vienādojumam attēlam tiek pāriets   horizontāli vai vertikāli, kas izkliedē attēlu attiecīgajā virzienā, tad tas tiek darīts atkal ar atlikušo virzienu.

Divas dimensijas vienādojumam attēlam tiek pāriets pāri tikai vienu reizi.

Pāris avotos,[piemēram](https://www.w3.org/Talks/2012/0125-HTML-Tehran/Gaussian.xhtml),  ir teikts, ka pirmais variants ir ātrāks, jo veic mazāk aprēķinus. 

## *Wiener Filter* for Image Deconvolution

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
