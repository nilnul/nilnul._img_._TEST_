using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.img.co_.isosize
{
	/// <summary>
	/// 
	/// </summary>
	///

	internal class _SimilarityX
	{
		static public double Difference(Bitmap a, Bitmap b) {
			var r = 0d;
			for (int i = 0; i < a.Width; i++)
			{
				for (int j = 0; j < a.Height; j++)
				{
					var colorDiff= nilnul._img.color.co._DifX.Dif(
					a.GetPixel(i, j),b.GetPixel(i,j)
					);
					r += colorDiff;
				}
			}
			return r;
		}

		static public double Difference(Image a, Image b) {
			return Difference(new Bitmap(a),new Bitmap(b));
		}

	}
}
