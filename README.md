Rasterbator-NG 1.0
==================

If it doesn't work...
---------------------

Please ensure the following:

-   You have extracted **entire** contents of the zip file
-   [.NET Core 3.1](javascript:;) or [Mono](javascript:;) is
    installed to your computer

Introduction
------------

To see what's new in version 1.1, see the changelog.

Rasterbator-NG is an application which creates rasterized versions of
images. The rasterized images can be printed and assembled into enormous
(or smaller, if you prefer) posters. Enter the online [Rasterbation
Gallery](javascript:;) to see what the images look like.

Rasterbator-NG originated as a [web application](javascript:;) at
[homokaasu.org](javascript:;), but it has gained so much popularity that
the web server occassionally cannot handle the load and a standalone
version was in place.

The standalone version is the same as the web version, except that
downloading images from the web and image cropping are not supported,
and you have to set the output size numerically (number of pages
wide/high) rather than using a fancy drag handle. The results are
exactly the same.

Download
--------

The zip file includes the application, its source code and MonoDevelop
project files. The program is licensed under the [GPL](javascript:;).

The application requires [.NET Core 3.1](javascript:;).To print the
posters, you need a pdf reader such as [Adobe Reader](javascript:;). The
application might also work with .NET Core 3.0 and [Mono](javascript:;) 
(available for many platforms, such as Linux or Mac), but the 
compatibility has not been tested. If you manage to run it on Mac, 
please tell me!

Rasterbator-NG uses [iTextSharp](javascript:;) and
[SharpZipLib](javascript:;) libraries. These are included in the file.

Instructions
------------

### Installation

No installation is needed. Just unzip the file contents and run the
included Rasterbator.exe application. The application is wizard-like,
which means it asks you questions and you click Continue button (or Back
if you want to change what you previously answered). There are five
screens with different options.

### 1. Select source image

In this phase you need to select the image you wish to rasterbate from
your hard disk. Either enter the file name (with path, such as
c:\\images\\snowman.jpg) in the box, or click Browse... to open the
standard file dialog, which you can use to select the file. Note that
the Continue button will be disabled if the file does not exist.

### 2. Select paper size

The rasterbated image will automatically be split onto several pages and
in this screen you select the size of the paper you wish to use. Either
use one of the predefined paper sizes (such as A4 or US Letter) and
choose either portait or landscape printing (horizontal or vertical
alignment of the paper), or use custom paper size. In the latter case,
you need to input the paper width and height in millimeters.

### ![](docfiles/rast-3.jpg)3. Define output size

Using the paper size you selected, choose the size of the rasterbated
poster you wish to use. You can define a specific amount of papers to
both dimensions: width and height. The other dimension will be
calculated automatically from the dimensions of the source image. The
image size and paper consumption will be displayed on the page. Also,
the preview image will show how the image will be distributed to
different pages.

### 4. Set rasterbation options

In this screen you set up the preferred output options. The options are
the following:

-   **Draw cutout line around rasterbated area** (default value: on)\
     This option wil draw a dim rectangle around the rasterbation
    graphic of each page. The border will make it considerably easier to
    cut away the empty margins. If you plan not to cut out the margins,
    you should uncheck this.
-   **Dot size** (default value: 10 mm)\
     Dot size defines the maximum size of the dots of the rasterbation.
    As a general rule, select small dot size for small output images and
    larger dot size for bigger output images. For a typical rasterbation
    job, good values are between 5 and 25 mm. Please note that dot size
    is not the distance between centers of adjacent dots, as the dots
    may overlap.
-   **Color mode** (default value: black)\
     The color mode affects the color of the dots in the poster. Black
    and custom color mean one-colored dots: the brightness is conveyed
    by using smaller or bigger dots. Multi-color includes the original
    color from the source image to the rasterbated poster.

### 5. Save rasterbation as

This should be pretty easy. The default value for the output file is the
file name and directory of the source file, except that the file suffix
(such as .jpg) is replaced with .pdf. If a file of the similar name
exists, the suggested output file name will be suffixed with such a
number that there exists no file the name.

### ![](docfiles/rast-6.jpg)Rasterbate!

Then, click the Rasterbate! button. The program will produce the output
image. If you want to use other programs while rasterbating, check the
"Rasterbate on low priority" option. This will slow down the
rasterbating, but it makes other programs more responsive.

When the rasterbation is completed, you have the option to automatically
open the produced image file (requires that you have a pdf reader in
your computer system).\

If you like it...
-----------------

Rasterbator-NG is free, but surprisingly many users of the web version
would have liked to make a contribution. Please consider making a
donation to, for example, the following organisations instead of me:

-   [Electronic Frontier Finland ry.](javascript:;)
-   [Electronic Frontier Foundation](javascript:;)
-   [Downhill Battle](javascript:;)
-   [Foundation for a Free Information Infrastructure](javascript:;)
-   [Amnesty International](javascript:;)
-   [Independent Media Center](javascript:;)

Language files
--------------

The language files for different languages are located in subdirectory
*languages*. To translate the program into a new language, just make a
copy of an existing file and edit it with a text editor. The file looks
like this:

\<language englishname="English" nativename="English"
TwoLetterISOLanguageName="en"\>\
 \<!-- Welcome --\>\
   \<item name="WelcomeTitle"\>Welcome to Rasterbator-NG\</item\>\
   \<item name="WelcomeInfo"\>Rasterbator-NG creates huge, rasterized,
multi-page images from any picture. The rasterized images can be printed
and assembled into extremely cool posters.\</item\>\
 ...

Then edit the areas marked with green. If the file is located in
*languages*, it should be available in the list of languages
automatically when the application is started the next time. Make sure
the file is valid xml and encoded using UTF-8.

Change log
----------
### 12.1.2022 - version 1.1 released

-   Fixed bug opening the PDF file on Windows
-   Added header image
-   Ported to .Net Core 3.1
-   Code cleanup
-   New solution file for VS2019

### 6.7.2008 - version 1.0 released

-   Removed platform specific code
-   Automatic selection of the language
-   Creation of smaller PDF files

Change log from "The Rasterbator"
---------------------------------

### 28.7.2005 - version 1.21 released

-   New languages: Croatian, Czech, Danish, Norwegian, Romanian
-   Minor bug fixes, especially in handling of nonexistent directories

### 6.3.2005 - version 1.2 released

-   The installation package includes now the following translations:
    Dutch, English, Finnish, French, German, Italian and Spanish. Thanks
    for everyone who sent language files!
-   A little better error handling: on failed rasterbation an error
    message will be shown instead of silent failure
-   Optimized bitmap reading speeds up the rasterbation of jpeg, png and
    tiff images.
-   Optimized rasterbation algorithm.

### 12.2.2005 - version 1.1 released

-   Support for multiple languages
-   Finnish and German translations. Special thanks to Dominik
    Zirkelbach for the German translation. Visit his German Rasterbator
    support site at
    [http://www.rasterbator.de.vu/](http://www.rasterbator.de.vu/).
-   Output dot size was smaller than selected (bug in the conversion
    from mm to pdf units)
-   If the required dll files aren't available an a error dialog box was
    shown instead of a silent failure
-   Symbols depicting portrait and landscape paper alignment
-   Resizable window (enables bigger preview output image)

### 6.2.2005 - version 1.0 released

-   Initial version

Rasterbator on the web
----------------------

-   [Rasterbation-NG Homepage](https://github.com/supertobi/rasterbator-ng)
-   [Rasterbator on the web](http://homokaasu.org/rasterbator/)
