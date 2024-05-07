using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.img._test.op_.rotate_.quarter_.neg.of_.folder.documents.names
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var container = nilnul.fs.address_.volRoute_.Container.Parse(@"E:\\data\\_PreData\cert_\diploma_\");
			var folder = new nilnul.fs.folder_.VolRoute(container);


			var dirs = nilnul.fs.folder_.volRoute.Dirs.Enumerate(folder);

			var folders = dirs.Select(

				dir => nilnul.fs.folder_.volRoute.Dir.Join(folder, dir)

			);

			var files = folders.SelectMany(
				f =>
				nilnul.fs.folder_.volRoute.docs.Elements.Enumerate(f)
			).Where(
				fi =>
					 fi.ed.deckedDocument.document.doc.main.ToString().ToUpper().Contains("DEGREE")
					 ||
					 fi.ed.deckedDocument.document.doc.main.ToString().ToUpper().Contains("GRADUATION")
			);

			foreach (var item in files)
			{






				var fileAddress = item.ToString();

				var src = Image.FromFile(fileAddress);

				nilnul.img.trans_.rotate_.QuarterNega.Eval(src);




				var srcFile = nilnul.fs.address_.File.Parse(fileAddress);

				var newNameMain = srcFile.doc.main + ".negQuartered";

				var newExt = srcFile.doc.ext;

				var newDocName = new nilnul.fs._address.doc_.Dotted(newNameMain, newExt);



				System.IO.Directory.CreateDirectory(srcFile.folder.ToString());

				var fileSavePath = new nilnul.fs.address_.File(srcFile.folder, newDocName);


				src.Save(fileSavePath.ToString());

				nilnul.fs.file._OpenX.Open(fileSavePath.ToString());
			}



		}

	}
}
