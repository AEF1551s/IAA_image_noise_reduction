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

## Gaussian blur
# Apraksts
Metodes mērķis ir izkliedēt attēlu tā, lai samazinās attēla troksnis, kontrastā tas arī zaudē attēla detaļas. Metode izmanto [Gausa funkciju](https://en.wikipedia.org/wiki/Gaussian_function), lai aprēķinātu izmaiņas katram pikselim. Metodei piemīt divi veida vienādojumi: vienas vai divas dimensijas vienādojumi.

        Abi vienādojumi:
![vienas_dimensijas_vienadojums](https://i.stack.imgur.com/lXRKO.png)
</n>
x - attālums no sākuma punkta horizontālajā asī
y - attālums no sākuma punkta vertikālajā asī
σ - gausa sadalijuma standartnovirze = ievada lietotājs

Trokšņa uzlabošanas piemērs:
![gaussian_blur_example](https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Halftone%2C_Gaussian_Blur.jpg/220px-Halftone%2C_Gaussian_Blur.jpg)

# Impemetācija
Ir divi iespējami veidi kā Gausa izkliedēšanu implementēt, jo ir divi vienādojumi. 
        
Vienas dimensijas vienādojumam attēlam tiek pāriets   horizontāli vai vertikāli, kas izkliedē attēlu attiecīgajā virzienā, tad tas tiek darīts atkal ar atlikušo virzienu.

Divas dimensijas vienādojumam attēlam tiek pāriets pāri tikai vienu reizi.

Pāris avotos,[piemēram],(https://www.w3.org/Talks/2012/0125-HTML-Tehran/Gaussian.xhtml)  ir teikts, ka pirmais variants ir ātrāks, jo veic mazāk aprēķinus. 