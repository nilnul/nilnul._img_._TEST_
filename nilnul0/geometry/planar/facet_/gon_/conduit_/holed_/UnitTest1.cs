using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon_.conduit_.holed_
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{
		

			var facet = nilnul.geometry.planar.facet_.gon_.holed_.UnitTest11.Facet();

			var conduit = nilnul.geometry.planar.facet_.gon_.conduit.of_.coerce_._MinCuspX.Of(facet);


			nilnul.geometry.planar.cloze_.gons.draw.U1.Show(conduit);
		}

		static public System.Collections.Generic.IEnumerable<Point4dblI> Conduit()
		{
		

			var facet = nilnul.geometry.planar.facet_.gon_.holed_.UnitTest11.Facet();

			var conduit = nilnul.geometry.planar.facet_.gon_.conduit.of_.coerce_._MinCuspX.Of(facet);


			return conduit;
		}

	}
}
