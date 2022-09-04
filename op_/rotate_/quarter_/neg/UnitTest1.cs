using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;

namespace nilnul.img._test.trans_.rotate_.quarter_.nega
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void rotate_quarter()
		{


			var folder = nilnul.fs.address_.Folder.Parse(@"E:\\data\\_PreData\cert_\teacher_");

			var doc = nilnul.fs._address.DocNameA.Parse( @"cert.jpg");
			var file1 = new nilnul.fs.address_.File(folder, doc);

			//var file = @"C:\160803\data\wyt.finance(sln\ken\bank\spd\IMG_20160730_134204.cropped.jpg";

			var file = file1.ToString();

			var src = Image.FromFile(file);

			nilnul.img.trans_.rotate_.QuarterNega.Eval(src);




			var srcFile = nilnul.fs.address_.File.Parse(file);

			var newNameMain = srcFile.doc.main + ".negQuartered";

			var newExt = srcFile.doc.ext;

			var newDocName = new nilnul.fs._address.doc_.Dotted(newNameMain, newExt);






			Directory.CreateDirectory(srcFile.folder.ToString());

			var fileSavePath = new nilnul.fs.address_.File(srcFile.folder, newDocName);


			src.Save(fileSavePath.ToString());

			nilnul.fs.file._OpenX.Open(fileSavePath.ToString());



		}
	}
}
