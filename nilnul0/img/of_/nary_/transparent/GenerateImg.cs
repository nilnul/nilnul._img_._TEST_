using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;

namespace nilnul.img._test
{
	[TestClass]
	public class GenerateImg_test
	{
		[TestMethod]
		public void GenerateImg()
		{
			var cb = Assembly.GetExecutingAssembly().CodeBase;

			var address = nilnul.fs.address._UrlX.Unprefix(cb);

			var prjBase = nilnul.fs.address.op_.unary_._UpX._assumeUpNatural(address, 3);




			var folder1 = System.IO.Path.Combine(
				prjBase.ToString(),
				"_data(!Git"

			);

			nilnul.fs.folder._EnsureX.Void_ofAddress(folder1);

			var vered = nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next.OvAddress(folder1).address("transparentPixel",".png");

			Bitmap dot = new Bitmap(1, 1);
			Graphics flagGraphics = Graphics.FromImage(dot);
			flagGraphics.FillRectangle(Brushes.Transparent, 0, 0, 1, 1);
			dot.Save(
				vered
				,

				ImageFormat.Png);


		}
	}
}
