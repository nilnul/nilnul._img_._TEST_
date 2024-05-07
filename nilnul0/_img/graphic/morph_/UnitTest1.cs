using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.img.fro_;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace nilnul._img_._TEST_.morph_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Matrix myMatrix =
				 
				new Matrix(1, 0, 0, -1, 0, 0);
			var img = new Bitmap(
				400, 300
			);

			using (var myGraphics = Graphics.FromImage(img))
			{
				myGraphics.DrawRectangle( new Pen(Color.Green),new Rectangle(0,0, img.Width,img.Height));

				myGraphics.Transform = myMatrix;
				myGraphics.TranslateTransform(200, 150, MatrixOrder.Append);

				// Create the path.
				GraphicsPath myGraphicsPath = new GraphicsPath();
				Rectangle myRectangle = new Rectangle(0, 0, 60, 60);
				myGraphicsPath.AddRectangle(myRectangle);


				// Fill the path on the new coordinate system.
				// No local transformation

				Brush mySolidBrush1 = new SolidBrush(Color.Blue);


				myGraphics.FillPath(mySolidBrush1, myGraphicsPath);



				// Set the local transformation of the GraphicsPath object.
				Matrix myPathMatrix = new Matrix();
				myPathMatrix.Scale(2, 1);
				myPathMatrix.Rotate(30, MatrixOrder.Append);
				myGraphicsPath.Transform(myPathMatrix);

				Brush mySolidBrush2 =  new SolidBrush(Color.Red);
				// Fill the transformed path on the new coordinate system.
				myGraphics.FillPath(mySolidBrush2, myGraphicsPath);




			}
			var t = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt("a.jpg");

			img.Save(
				t
			);

			nilnul.fs.file._ExeX.Exe(t);

				

		}
	}
}
