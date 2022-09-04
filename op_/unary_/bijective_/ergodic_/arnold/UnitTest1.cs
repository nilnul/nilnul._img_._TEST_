using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Reflection;

namespace nilnul._img_._TEST_.op_.unary_.bijective_.ergodic_.arnold
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

			var vered = System.IO.Path.Combine(folder1, document4_img2test);

			var dot =  new Bitmap(vered);

			var img=nilnul.img.op_.unary_.bijective_._ArnoldCatMapX._AssumeSquare( dot);



			var tmpFolder = nilnul.fs.folder_.tmp.denote_.ver_.next._CreateFolderX.Folder_ofVered(
				"arnold"
			);

			var saved= nilnul.fs.folder.denote_.mainVered_.minVer_.Next.OvAddress(tmpFolder.ToString()).address(
				"aa.jpg"
			);

			
			img.Save(
				saved
			);

			nilnul.fs.file._ExeX.Exe(saved);
		}
	}
}
