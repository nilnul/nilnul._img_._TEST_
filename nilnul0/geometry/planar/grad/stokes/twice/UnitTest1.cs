using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace nilnul._img_._TEST_.nilnul0.geometry.planar.grad.stokes.twice
{

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var v1 = new nilnul.geometry.planar.Vect4dbl(
				61
				,
				13
			);

			var v2 = new nilnul.geometry.planar.Vect4dbl(24, 53)

				;

			var sum = v1 + v2;

			var amplitude = 1.1;
			var _width = sum.x*amplitude;
			var width = (int)_width;
			var height = sum.y * amplitude;
			var heightAsInt = (int)height;



			using (var img = new Bitmap(width, heightAsInt))
			{
				using (var g = Graphics.FromImage(img))
				using (var pen = new Pen(Color.Red))
				{

					pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
					pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
					pen.CustomEndCap = new AdjustableArrowCap(3, 3);
					//pen.DashStyle = DashStyle.Dash;
					//pen.DashCap = DashCap.Triangle;
					g.DrawEllipse(
						pen, new RectangleF(-1,-1 ,1,1)
					);

					nilnul.geometry.planar.grad._DrawX.Draw
					(
						g,
						v1
						,
						pen
					);

					nilnul.geometry.planar.grad._DrawX.Draw
					(
						g,
						v2
						,
						pen
					);









				}
				var file = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".jpg");

				img.Save(
					file

				);

				nilnul.fs.file._ExeX.Exe(file);


			}


			

		}
	}
}
