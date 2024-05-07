using Colourful;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._img.color.op_
{
	static public class _FormatX
	{
		static public readonly IColorConverter<RGBColor, LabColor> Converter = new ConverterBuilder().FromRGB(RGBWorkingSpaces.sRGB)
	.ToLab(Illuminants.D65)
	.Build();

		static public LabColor Lab(RGBColor rgbColor) {
			var xyzColor = Converter.Convert(rgbColor); 
			return xyzColor;
		}

		static public LabColor Lab(Color rgbColor) {
			return Lab(new RGBColor(rgbColor));
			
		}





	}
}
