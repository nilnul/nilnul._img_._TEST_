using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon_.conduit_._trihole.disord.cure.to_.zones
{
	[TestClass]
	public class UnitTest1
	{

		//[ExpectedException(typeof(System.InvalidOperationException))]
		[TestMethod]

		public void TestMethod1()
		{


			var conduit = gon_.conduit_._trihole.disord_.UnitTest11.Conduit();

			nilnul.geometry.planar.cloze_.gons.draw.U1.Show(conduit);


			var cured = planar.facet_.gon_._conduit.disord.to_._MinCuspX._RollForward_0twirl(conduit);

			nilnul.geometry.planar.cloze_.gons.draw.U1.Show(cured.Select(g=>g.basis));


			var zones = nilnul.geometry.planar.facet_.gon_.conduit.to_._CrackToAdjacentZonesX._ToAdjacentZones_0conduit(cured.Select(g => g.basis));

			nilnul.geometry.planar.cloze_.gons.draw.U1.Show(zones);



			nilnul.geometry.planar.zone_.gons.draw.U1.Show(zones);





		}
	}
}
