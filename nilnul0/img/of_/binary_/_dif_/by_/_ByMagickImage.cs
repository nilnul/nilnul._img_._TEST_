using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.img.of_.binary_._dif_.by_
{
	internal class _ByMagickImageX
	{
		static void Main(string[] args)
		{
			using (var img1 = new MagickImage(@"C:\test\Image1.jpg"))
			{
				using (var img2 = new MagickImage(@"C:\test\Image2.jpg"))
				{
					using (var imgDiff = new MagickImage())
					{
						double diff = img1.Compare(img2, new ErrorMetric(), imgDiff);
						imgDiff.Write(@"C:\test\Diff-Image1-Image2.jpg");
					}
				}
			}

			/*
			 * 
			 * stackoverflow.com/questions/40360921/comparing-two-images-using-imagemagick-and-c-sharp
			  
But when you are working with jpeg images (they are lossy) you probably also want to set the ColorFuzz on the first image:

img1.ColorFuzz = new Percentage(5); // adjust this value for your situation
This will make it so that pixels that are almost the same will also match.			 

Don’t edit a *.png with a transparent background in Windows paint and expect a good compare. 
			Just make sure that when you are testing out the first time that the second image (which you modified) didn’t get unintentionally modified by the image editor that you use. This is a general warning for when you are testing out any image compare tool for the first time to see if you want to use it or not.


			 */
		}
	}
}
