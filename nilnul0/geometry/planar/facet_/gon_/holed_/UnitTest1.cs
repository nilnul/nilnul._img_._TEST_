using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon_.holed_
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{
		

			var facet = Facet();

			nilnul.geometry.planar.cloze_.gons.draw.U1.Show(facet);
		}


		static public nilnul.geometry.planar.facet_.Gon4dbl Facet()
		{

			var hull = new (double,double)[] {
				(0,0)
				,
				(50, 0)
				,
				(80,-10)
				,
				(100,11)
				,
				(110, 110)
				,
				(90,120)
				,
				(-1,90)

			};

			var hole = new (double,double)[] {
				(20,20)
				,
				(50,15)
				,
				(70,-1)
				,
				(60,60)
				,
				(40, 20)
				,
				(30,40)
	

			}.Reverse();

			var facet = new nilnul.geometry.planar.facet_.Gon4dbl(hull,hole);

			return facet; ;
		}
	}
}
