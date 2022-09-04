using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;

namespace nilnul.num.real.func.plot
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{


			var xDoc = XDocument;

			var tgtFile = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.Spear(".svg").ToString();
			System.IO.File.WriteAllText(tgtFile, xDoc.ToString());

			//nilnul.fs.file.explore_._SelX.Vod(tgtFile);

			nilnul.fs.file._ExeX.Exe(tgtFile);
			//nilnul.fs.file._ExeX.Exe(f);
			//nilnul.win.prog_.notepad.run_.shell_.NewWin.Singleton.run(tgtFile);

		}
	}
}
