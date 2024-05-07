using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using nilnul.num.quotient.stream_;

namespace nilnul._img_._TEST_.nilnul0._img.graphic.morph_.affine.of_.binary_.mult.be_.prepend
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			/*
https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/why-transformation-order-is-significant?view=netframeworkdesktop-4.8



			*/
			var img = new Bitmap(
				400, 300
			);

			var eGraphics = Graphics.FromImage(img);


			Rectangle rect = new Rectangle(0, 0, 50, 50);
			Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
			eGraphics.ResetTransform();
			eGraphics.ScaleTransform(1.75f, 0.5f);
			eGraphics.RotateTransform(28, MatrixOrder.Append);
			eGraphics.TranslateTransform(150, 150, MatrixOrder.Append);
			eGraphics.DrawRectangle(pen, rect);


			var m0 = eGraphics.Transform;


			Matrix m1()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				eGraphics = Graphics.FromImage(img);



				Rectangle rect = new Rectangle(0, 0, 50, 50);
				Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
				eGraphics.ResetTransform();
				eGraphics.TranslateTransform(150, 150, MatrixOrder.Append);
				eGraphics.RotateTransform(28, MatrixOrder.Append);
				eGraphics.ScaleTransform(1.75f, 0.5f);
				eGraphics.DrawRectangle(pen, rect);
				return eGraphics.Transform;

			}
			Matrix m1_explicitPrepend()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				eGraphics = Graphics.FromImage(img);



				Rectangle rect = new Rectangle(0, 0, 50, 50);
				Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
				eGraphics.ResetTransform();
				eGraphics.TranslateTransform(150, 150, MatrixOrder.Append);
				eGraphics.RotateTransform(28, MatrixOrder.Append);
				eGraphics.ScaleTransform(1.75f, 0.5f,MatrixOrder.Prepend);
				eGraphics.DrawRectangle(pen, rect);
				return eGraphics.Transform;

			}

			Matrix m1_explicitAppend2change()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				eGraphics = Graphics.FromImage(img);



				Rectangle rect = new Rectangle(0, 0, 50, 50);
				Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
				eGraphics.ResetTransform();
				eGraphics.TranslateTransform(150, 150, MatrixOrder.Append);
				eGraphics.RotateTransform(28, MatrixOrder.Append);
				eGraphics.ScaleTransform(1.75f, 0.5f,MatrixOrder.Append);
				eGraphics.DrawRectangle(pen, rect);
				return eGraphics.Transform;

			}

			Matrix m1_reshuffle()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				eGraphics = Graphics.FromImage(img);



				Rectangle rect = new Rectangle(0, 0, 50, 50);
				Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
				eGraphics.ResetTransform();
				eGraphics.ScaleTransform(1.75f, 0.5f);
				eGraphics.TranslateTransform(150, 150, MatrixOrder.Append);
				eGraphics.RotateTransform(28, MatrixOrder.Append);
				eGraphics.DrawRectangle(pen, rect);
				return eGraphics.Transform;

			}


			Matrix m_missedPrepend()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				eGraphics = Graphics.FromImage(img);



				Rectangle rect = new Rectangle(0, 0, 50, 50);
				Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
				eGraphics.ResetTransform();
				eGraphics.TranslateTransform(150, 150, MatrixOrder.Prepend);
				eGraphics.RotateTransform(28, MatrixOrder.Prepend);
				eGraphics.ScaleTransform(1.75f, 0.5f);
				eGraphics.DrawRectangle(pen, rect);
				return eGraphics.Transform;

			}
			Matrix m3()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				eGraphics = Graphics.FromImage(img);



				Rectangle rect = new Rectangle(0, 0, 50, 50);
				Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
				eGraphics.ResetTransform();
				eGraphics.TranslateTransform(150, 150);
				eGraphics.RotateTransform(28, MatrixOrder.Prepend);
				eGraphics.ScaleTransform(1.75f, 0.5f, MatrixOrder.Prepend);
				eGraphics.DrawRectangle(pen, rect);
				return eGraphics.Transform;

			}
			Matrix m4()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				eGraphics = Graphics.FromImage(img);



				Rectangle rect = new Rectangle(0, 0, 50, 50);
				Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
				eGraphics.ResetTransform();
				eGraphics.TranslateTransform(150, 150, MatrixOrder.Prepend);
				eGraphics.RotateTransform(28, MatrixOrder.Prepend);
				eGraphics.ScaleTransform(1.75f, 0.5f, MatrixOrder.Prepend);
				eGraphics.DrawRectangle(pen, rect);
				return eGraphics.Transform;

			}
			Matrix m5()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				eGraphics = Graphics.FromImage(img);



				Rectangle rect = new Rectangle(0, 0, 50, 50);
				Pen pen = new Pen(Color.FromArgb(128, 200, 0, 200), 2);
				eGraphics.ResetTransform();
				eGraphics.TranslateTransform(150, 150, MatrixOrder.Append);
				eGraphics.RotateTransform(28, MatrixOrder.Prepend);
				eGraphics.ScaleTransform(1.75f, 0.5f, MatrixOrder.Prepend);
				eGraphics.DrawRectangle(pen, rect);
				return eGraphics.Transform;

			}



			double[,] m2d(Matrix x)
			{
				return nilnul.num.real.matrix.of_._Element2doubleX.ElAsDouble(
					nilnul.num.real.matrix_.sq_._TertiaryX.ToArray2dimension(
						x
					)
				);
			}


			void v(Matrix x, Matrix y,bool r=true)
			{
				Assert.IsTrue(
					nilnul.num.real.matrix.re_.Approx4dbl.Singleton.re(
						m2d(x)
						,
						m2d(y)
					)==r
				);

			}

			var m01 = m1();
			v(m0, m01,false);


			v(m01, m1_explicitPrepend());

			v(m01, m1_reshuffle());
			v(m01, m1_explicitAppend2change(),false);



			var m_missedPrepend2 = m_missedPrepend();
			v(m0, m_missedPrepend2);

			var m03 = m3();

			v(m0, m03);

			var m04 = m4();
			v(m0,m04);

			var m05 = m5();
			v(m0,m05);













		}


	}
}
