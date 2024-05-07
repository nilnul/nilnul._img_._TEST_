using nilnul.img.fro_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.complex.collection_.mandelbrot._BoundingX;

namespace nilnul.geometry.planar.curve_.polar_.rhodon
{
	static public class _DrawX
	{
		static public Bitmap Draw(this Rhodonea rhodon, int widthTotal, int strokeWidth=2)
		{
			/// for img that is rasterized, we set the width and height first.
			///

			var heightTotal = widthTotal;


			var widthGeometry = widthTotal - strokeWidth;


			var heightGeometry = widthGeometry;


			//var ratio = widthGeometry/ rhodon.amplitude * 2 ;

			//var ratioAsFloat = (float)ratio;


			var blocWorld = new nilnul.geometry.planar.zone_.Bloc8dbl(
				new Point4dbl(
				-rhodon.amplitude
				,
				-rhodon.amplitude
				)
								,
				rhodon.amplitude*2
								,
				rhodon.amplitude*2


			);
			var blocPage = new nilnul.geometry.planar.tope_.BlocDbl(
				new Point4dbl(
					strokeWidth/2d
					,
					strokeWidth/2d
				
				)
								,
				widthGeometry
								,
				heightGeometry


			);




			var morph1 = nilnul.geometry.planar.morph_.affine_.Shearless4Dbl.OfBlok2bloc(
				blocWorld
				,
				blocPage
			);


			//var morph = new System.Drawing.Drawing2D.Matrix();

			//morph.Scale(ratioAsFloat,ratioAsFloat, System.Drawing.Drawing2D.MatrixOrder.Prepend);

			//morph.Translate(
			//	widthTotal/2
			//	,
			//	widthTotal/2
			//	, System.Drawing.Drawing2D.MatrixOrder.Append
			//);

	

			var imageAsBitmap = new Bitmap(widthTotal, heightTotal);

			/// x = r cos(t);
			/// dx / dt  = - r sin(t)
			/// dx = -r sin(t) dt
			/// |dx| = r |sin(t)| dt
			/// for |dx| le 1, we need :
			///		r sin(t) dt le 1
			///		(===  dt le 1/r
			///
			var ample = rhodon.amplitude;

			var curvature = 1 / ample / morph1.horizon.scale;




			for (double i = 0; i < nilnul.num.real_.eg_._Tau4dblX.FULL; i += curvature)
			{
				//if (i>Math.PI)
				//{
				//	continue;
				//}

				var hue = (float)(i / nilnul.num.real_.eg_._Tau4dblX.FULL * 360);
				var saturation = 1;

				var brightness = 0.5f;

				var r = rhodon.op(i);


				(double x, double y) p = morph1.morph(
										(r * Math.Cos(i))
										,
										(r * Math.Sin(i))
									);
				imageAsBitmap.SetPixel(

					(int)(p.x)
					,
					(int)(p.y)
					,
					nilnul._img.color_.hsb._ToRgbX.FromHsb(hue, saturation, brightness)
				);
			}
			return imageAsBitmap;
		}
	}
}
