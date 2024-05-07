using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul.geometry.planar.cloze_.gon_.nonshortcut.of_._points_.by_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var ps = planar.points.of_.rnd.UnitTest1.TestMethod1().ToArray();


			planar.cloze_.gon.draw.U1.ShowFile(ps);

			planar.cloze_.gon.draw.U1.ShowFile(
				nonshortcut.of_._points_.by_._ByDirectionX._OfPoints_0dwelt(ps)
			);
			planar.cloze_.gon.draw.U1.ShowFile(
				nonshortcut.of_._points_.by_._ByBisectX._OfPoints_0dwelt(ps)
			);

		}
	}
}
