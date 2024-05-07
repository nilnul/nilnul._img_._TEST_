using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace nilnul._img_._TEST_.graphic.twice
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			void m1()
			{
				var img = new Bitmap(
					400, 300
				);

				var eGraphics = Graphics.FromImage(img);

				var eGraphics2 = Graphics.FromImage(img);

				//get twice

				Assert.IsFalse(eGraphics==eGraphics2);




			}
			m1();
		}
	}
}
