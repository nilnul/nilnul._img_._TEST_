using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;

namespace nilnul.img._test.trans_.rotate
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Rotate()
		{
			var folder = nilnul.fs.address_.Folder.Parse(@"E:\170203\data\wyt\_PreData\cert_\diploma_\doctor_");

			var doc = nilnul.fs._address.DocNameA.Parse(@"degree1.jpg");

			var file1 = new nilnul.fs.address_.File(folder, doc);

			var file = file1.ToString();

			var src = Image.FromFile(file);
			var rotateDegree =-.991899254398f;
			//-1.1899254398f; 
			
			//-.1899254398f;//-.1599254398f;//-.069254398f; //-.06254398f;

			//nilnul.img.convert_.Rotate._EvalByDegree(src,rotateDegree);

			var srcFile = nilnul.fs.address_.File.Parse(file);

			var newNameMain = srcFile.doc.main + ".rotated"+rotateDegree;

			var newExt = srcFile.doc.ext;

			var newDocName = new nilnul.fs._address.doc_.Dotted(newNameMain, newExt);

			Directory.CreateDirectory(srcFile.folder.ToString());
			var fileSavePath = new nilnul.fs.address_.File(srcFile.folder, newDocName);

			var target = nilnul.img.convert_.Rotate._EvalByDegree(src, rotateDegree);

			target.Save(fileSavePath.ToString());

			nilnul.fs.file._OpenX.Open(fileSavePath.ToString());

		}
	}
}
