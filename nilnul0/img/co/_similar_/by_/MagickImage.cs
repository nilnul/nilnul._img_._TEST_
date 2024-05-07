using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.img.co._similar_.by_
{

	internal class ByMagickImage
	{
		static void Main(string[] args)
		{
			MagickImage img1 = new MagickImage(@"C:\test\Image1.jpg");
			MagickImage img2 = new MagickImage(@"C:\test\Image2.jpg");
			double diff = img1.Compare(img2, new ErrorMetric());
		}
	}
}
