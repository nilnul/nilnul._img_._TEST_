using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using nilnul.num.quotient.stream_;

namespace nilnul._img_._TEST_.nilnul0._img.graphic.morph_.affine.be_.rowwise
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			///learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics.rotatetransform?view=dotnet-plat-ext-8.0
			///
			/* private void RotateTransformAngle(PaintEventArgs e)
			{

				// Set world transform of graphics object to translate.
				e.Graphics.TranslateTransform(100.0F, 0.0F);

				// Then to rotate, prepending rotation matrix.
				e.Graphics.RotateTransform(30.0F);

				// Draw rotated, translated ellipse to screen.
				e.Graphics.DrawEllipse(new Pen(Color.Blue, 3), 0, 0, 200, 80);
			}
			*/
			var img = new Bitmap(
				400, 300
			);

			using (var myGraphics = Graphics.FromImage(img))
			{

				Assert.IsTrue(
					nilnul.num.real.matrix.re_.Approx4dbl.Singleton.re(
						nilnul.num.real.matrix.of_._Element2doubleX.ElAsDouble(
							nilnul.num.real.matrix_.sq_._TertiaryX.ToArray2dimension(
								myGraphics.Transform
							)
						)
						,
						nilnul.num.real.matrix_.square_.tertiary_._CanonicX.Canonic()
					)
				);

				myGraphics.TranslateTransform(
					100, 0
				);

				myGraphics.RotateTransform(30);

				var translateMatrix = new Matrix();
				translateMatrix.Translate(100, 0);
				var rotateMatrix = new Matrix();
				rotateMatrix.Rotate(30);


				double[,] m2d(Matrix x)
				{
					return nilnul.num.real.matrix.of_._Element2doubleX.ElAsDouble(
						nilnul.num.real.matrix_.sq_._TertiaryX.ToArray2dimension(
							x
						)
					);

				}

				// it's prepended;
				Assert.IsTrue(

					nilnul.num.real.matrix.re_.Approx4dbl.Singleton.re(
						nilnul.num.real.matrix.of_._Element2doubleX.ElAsDouble(
							nilnul.num.real.matrix_.sq_._TertiaryX.ToArray2dimension(
								myGraphics.Transform
							)
						)
						,

						nilnul.num.real.matrix.co_.multible._MultiX.Multi(
							 m2d(rotateMatrix), m2d(translateMatrix)
						)
					)
				);
				Assert.IsFalse(

					nilnul.num.real.matrix.re_.Approx4dbl.Singleton.re(
						nilnul.num.real.matrix.of_._Element2doubleX.ElAsDouble(
							nilnul.num.real.matrix_.sq_._TertiaryX.ToArray2dimension(
								myGraphics.Transform
							)
						)
						,

						nilnul.num.real.matrix.co_.multible._MultiX.Multi(
							m2d(translateMatrix), m2d(rotateMatrix) 
						)
					)
				);










			}
	

		}
	}
}
