using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Reflection;

namespace nilnul._img_._TEST_.op_.unary_.bijective_.ergodic_.arnold.stream
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

			var document4_img2test = @"lena_\square.bmp";

			var srcImg = System.IO.Path.Combine(folder1, document4_img2test);

			var srcImg1 = new Bitmap(srcImg);
			nilnul.fs.Folder tmpFolder=null;
				//var
					tmpFolder = nilnul.fs.folder_.tmp.denote_.ver_.next._CreateFolderX.Folder_ofVered(
					"arnold"
				);

			for (int i = 0; i < 3 * srcImg1.Width; i++)
			{

				var img = nilnul.img.op_.unary_.bijective_._ArnoldCatMapX._AssumeSquare(srcImg1);




				var saved = nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next.OvAddress(tmpFolder.ToString()).address(
					"aa.jpg"
				);

				//#186 is the upside down img
				img.Save(
					saved
				);

				srcImg1 = img;
			}



			nilnul.fs.folder.explore_._ByExeSelfX.Exe(tmpFolder);
		}
	}
}
