using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.img.co_.isosize.be_._similar.by_
{
	/// <summary>
	/// 
	/// </summary>
	///

	static public class _DigestX
	{
		static private bool _Re(BitArray left, BitArray right)
		{
			var equalsCount = 0;
			for (int i = 0; i < left.Length; i++)
			{
				var leftValue = left[i];
				var rightValue = right[i];
				if (leftValue == rightValue)
				{
					equalsCount++;
				}
			}
			return equalsCount >= (left.Length*.9);
		}
		private static BitArray _Digest(Bitmap bmpSource, int width=16,int height=16)
		{
			int length = width * height;
			BitArray array = new BitArray(length);
			//create new image with 16x16 pixel
			Bitmap bmpMin = new Bitmap(bmpSource, new Size(width, height));
			var counter = 0;
			var median = 0.0f;
			for (int j = 0; j < height; j++)
				for (int i = 0; i < width; i++)
				{
					//reduce colors to true / false                
					median+= bmpMin.GetPixel(i, j).GetBrightness() ;
					
				}
			median /= length;


			for (int j = 0; j < height; j++)
				for (int i = 0; i < width; i++)
				{
					//reduce colors to true / false                
					array.Set(counter, bmpMin.GetPixel(i, j).GetBrightness() < median);
					counter++;
				}
			return array;
		}
		static public bool Re(Bitmap a, Bitmap b) {
			
			return _Re(_Digest(a),_Digest(b));
		}

		static public bool Re(Image a, Image b) {
			return Re(new Bitmap(a),new Bitmap(b));
		}

	}
}
