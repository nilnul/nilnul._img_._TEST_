using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._img_._TEST_.fro_.screen
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var jpgFile = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.Txt(".jpg");

			nilnul.img.fro_._ScreenX._PrimaryToFile(
				jpgFile
			);
			nilnul.fs.file.explore_._SelX.Vod(jpgFile);
		}
	}
}
