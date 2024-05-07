using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon.to_.zones
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		

			var facet = gon_.holed_.UnitTest11.Facet();

			var zones = nilnul.geometry.planar.facet_.gon.to_._SplitToAdjacentZonesX.ToAdjacentZones(facet);



			nilnul.geometry.planar.cloze_.gons.draw.U1.Show(zones);
		}
	}
}
