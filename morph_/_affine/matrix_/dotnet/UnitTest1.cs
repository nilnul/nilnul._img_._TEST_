using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace nilnul._img_._TEST_.morph_._affine.matrix_.dotnet
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var m = new System.Drawing.Drawing2D.Matrix(
				1,2,3,4,5,6
			);

			var els = m.Elements;

			//Assert.AreEqual(
			//	m[2,0],5

			//);
		}

		[TestMethod]
		public void MyTestMethod()
		{

			var pointsA = new Point[1];
			pointsA[0].X = 1;
			pointsA[0].Y = 1;
			var pointsB = new Point[1];
			pointsB[0].X = 1;
			pointsB[0].Y = 1;

			// Transform PointsA using Matrix
			Matrix m = new Matrix(1, 1, 0, 1, 0, 0);
			
			m.TransformPoints(pointsA);
			Assert.IsTrue(pointsA[0].X == 1);
			Assert.IsTrue(pointsA[0].Y ==2);



 // Transform PointsB using Elements.
         var elements = m.Elements;

         var m11 = elements[0];
         var m12 = elements[1];
         var m21 = elements[2];
         var m22 = elements[3];
         var dx  = elements[4];
         var dy  = elements[5];

         var pointB = pointsB[0];

   //      var x = m11 * pointB.X + m21 * pointB.Y + dx;
   //      var y = m12 * pointB.X + m22 * pointB.Y + dy;

			//Assert.IsFalse(x == 1);
			//Assert.IsFalse(y ==2);

         // Correct answer but had to transpose positions of m12 and m21 from what would be the normal matrix x vector multiplication.
         var x1 = m11*pointB.X + m21*pointB.Y + dx;
         var y1 = m12*pointB.X + m22*pointB.Y + dy;
			Assert.IsTrue(x1 == 1);
			Assert.IsTrue(y1 ==2);


			var matrix = new Matrix(1, 0, 0, 1, 100, 200);
			var p = new Point(100, 200);// 1);

			 matrix.TransformPoints(new[] { p });

			var transformed = p;


		}
	}
}
