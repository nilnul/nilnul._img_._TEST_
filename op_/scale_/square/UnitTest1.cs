using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace nilnul._img_._TEST_.op_.scale_.square
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var cb = Assembly.GetExecutingAssembly().CodeBase;

			var address = nilnul.fs.address._UrlX.Unprefix(cb);

			var prjBase = nilnul.fs.address.op_.unary_._UpX._assumeUpNatural(address, 3);




			var folder1 = System.IO.Path.Combine(
				prjBase.ToString(),
				"_data(!Git"

			);

			nilnul.fs.folder._EnsureX.Void_ofAddress(folder1);

			var document4_img2test = "lena_/rect.jpg";

			var srcFile = System.IO.Path.Combine(folder1, document4_img2test);

			var dstImg = nilnul.img.op_.unary_.scale_._SquareOutX.Op(srcFile);

			



		

			var saved = System.IO.Path.Combine(folder1, @"lena_\square.bmp");


			dstImg.Save(
				saved
			);

			nilnul.fs.file._ExeX.Exe(saved);
		}
	}
}
