using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.facet_.gon_.conduit_._trihole.disord_.to_.zones
{
	[TestClass]
	public class UnitTest1img
	{

		[ExpectedException(typeof(System.InvalidOperationException))]
		[TestMethod]

		public void TestMethod1()
		{


			var conduit = gon_.conduit_._trihole.disord_.UnitTest11.Conduit();


			try
			{

				var zones = nilnul.geometry.planar.facet_.gon_.conduit.to_._CrackToAdjacentZonesX._ToAdjacentZones_0conduit(conduit);

				throw new Exception();

				nilnul.geometry.planar.zone_.gons.draw.U1.Show(zones);


			}
			catch (Exception)
			{

				/*
				 System.InvalidOperationException
  HResult=0x80131509
  Message=Nullable object must have a value.
  Source=mscorlib
  StackTrace:
   at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
   at System.Nullable`1.get_Value()
   at nilnul.geometry.planar.facet_.gon_.conduit.to_._CrackToAdjacentZonesX._CutHole(IEnumerable`1 _conduit, Point4dblI leftmost, Point4dblI[] hull) in D:\170203\data\nilnul.geometry._planar_\_LIB_(Git\facet_\gon_\conduit\to_\_CrackToZonesX.cs:line 77
   at nilnul.geometry.planar.facet_.gon_.conduit.to_._CrackToAdjacentZonesX.<ToAdjacentZones>g__splitRecur|1_0(IEnumerable`1 conduit) in D:\170203\data\nilnul.geometry._planar_\_LIB_(Git\facet_\gon_\conduit\to_\_CrackToZonesX.cs:line 266
   at nilnul.geometry.planar.facet_.gon_.conduit.to_._CrackToAdjacentZonesX.<ToAdjacentZones>g__splitRecur|1_0(IEnumerable`1 conduit) in D:\170203\data\nilnul.geometry._planar_\_LIB_(Git\facet_\gon_\conduit\to_\_CrackToZonesX.cs:line 276
   at nilnul.geometry.planar.facet_.gon_.conduit.to_._CrackToAdjacentZonesX.<ToAdjacentZones>g__splitRecur|1_0(IEnumerable`1 conduit) in D:\170203\data\nilnul.geometry._planar_\_LIB_(Git\facet_\gon_\conduit\to_\_CrackToZonesX.cs:line 276
   at nilnul.geometry.planar.facet_.gon_.conduit.to_._CrackToAdjacentZonesX.ToAdjacentZones(IEnumerable`1 gon) in D:\170203\data\nilnul.geometry._planar_\_LIB_(Git\facet_\gon_\conduit\to_\_CrackToZonesX.cs:line 239
   at nilnul.geometry.planar.facet_.gon_.conduit_._trihole.disord_.to_.zones.UnitTest1.TestMethod1() in D:\170203\data\nilnul._img_\_TEST_(Git\nilnul0\geometry\planar\facet_\gon_\conduit_\_trihole\disord\to_\zones\UnitTest1.cs:line 18

				 */

				throw;
			}




		}
	}
}
