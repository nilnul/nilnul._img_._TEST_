using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul._img_._TEST_.nilnul0.geometry.planar.coil_.gon_.hex_.hexagram.draw
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{


			var zones = nilnul.geometry.planar.coil_.gon_.hex_._HexagramX.WithinUnialDisk().Select(c => c * 100);



			nilnul.geometry.planar.zone_.gons.draw.U1.Show(zones,true);

		}
	}
}
