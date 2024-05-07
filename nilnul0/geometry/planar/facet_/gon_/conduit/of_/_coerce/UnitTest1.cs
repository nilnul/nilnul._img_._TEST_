using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul._img_._TEST_.facet_.gon_.conduit.of_._coerce
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			const int windowBroad = 500;
			double underWindow = 1200;
			double aboveWindow = 200;
			double WallHeight = 2900;
			double windowHeight = WallHeight - underWindow - aboveWindow;
			var windowFurther = 600;

			var win = new nilnul.geometry.planar.tope_.BlocDbl(windowBroad, windowHeight).vertexes.Select(
				p => new nilnul.geometry.planar.Point4dbl(
					nilnul.geometry.planar.morph_.affine_._ShiftX.Trans(
					(p.x, p.y), (windowFurther, underWindow)
					)
				)
			);

			var t = new nilnul.geometry.planar.facet_.Gon4dbl(
					//new nilnul.geometry.planar.cycle_.gon_.Facade4dbl(
					new nilnul.geometry.planar.tope_.BlocDbl(
						1680, 2900
					).vertexes.ToArray()
				//).vertexes
				,
				new[] {
						win.Reverse().ToArray()
				}

			);

			var c = geometry.planar.facet_.gon_.conduit.of_.coerce_._MinCuspX.Of(t);

			nilnul.geometry.planar.cloze_.gon.draw.U1.ShowFile(c,3000);



		}
	}
}
