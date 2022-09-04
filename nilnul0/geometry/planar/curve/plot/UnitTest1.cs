using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.geometry.planar.curve.plot
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{


			var curve = new nilnul.geometry.planar.curve_.eg_.AppleDbl(300);

			var points = new List<nilnul.geometry.planar.point_.Polar4dbl>();


			var denom = 100;
			for (int i = 0; i < denom; i++)
			{
				var theta = (double)i / denom * nilnul.num.real_.TauX.IntoDouble;
				var polarPoint = new nilnul.geometry.planar.point_.Polar4dbl(
					curve.rhou(
						theta
					)
					,
					theta
				);

				points.Add(polarPoint);
			}
			var pointsStraight = points.Select(
					p => p.toStraight()
				);

			var pointsF = pointsStraight.Select(x => x.toPointF()).ToArray();
			var bounding = nilnul.geometry.planar.points_.started._BoundBoxX.GetBoundingBox(
				pointsStraight
			);

			var sizeInt = bounding.size.toSizeInt();

			var img = new Bitmap(sizeInt.Width + 3, sizeInt.Height + 3);



			using (var g = Graphics.FromImage(img))
			{
				var pointF = bounding.point.toPointF();
				var matrix = new System.Drawing.Drawing2D.Matrix();



				//var scale = nilnul.num.real.co.band_.MinDbl.Singleton.band(
				//	new num.real.CoDbl(
				//	img.Width / bounding.size.width.realee.ee

				//	,
				//	img.Height
				//	/
				//	bounding.size.height.realee.ee
				//	)
				//);
				//matrix.Scale(
				//	(float)scale
				//	,
				//	(float)scale

				//);
				matrix.Translate(-pointF.X, -pointF.Y);
				g.Transform = matrix;
				;
				g.DrawBeziers(new Pen(Color.Red, 3), pointsF);


			}
			var file = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".jpg");
			img.Save(
				file
			);

			nilnul.fs.file._ExeX.Exe(file);
		}
	}
}
