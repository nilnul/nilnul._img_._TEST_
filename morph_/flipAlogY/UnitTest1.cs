using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._img_._TEST_.trans_.flipAlogY
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var doc1 = nilnul.img_._SvgX.GenDoc(
				new obj.mesh.Tile(
					-50,-50,100,100
				)
			);

			var textdraw = nilnul.img_.svg.draw_.txt_._CenteredX.CreateNodeTxt(0, 0, "of")
				;
			var g = new XElement(
				"g"
				,
				new XAttribute(
					"transform"
					,
					//"translate(-50,-50) scale(-1,1) translate(50,50)"
					//"scale(-1,1) scale(1,-1)"
					//"scale(-1,1) "
					" scale(1,-1) "
					)
			); 

			doc1.Root.Add(g);
			g.Add(textdraw);



			nilnul.img_._SvgX.RemoveEmptyNs(doc1);

			var tgtFile = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.Spear(".svg");
			System.IO.File.WriteAllText(tgtFile.ToString(), doc1.ToString());

			//nilnul.fs.file.explore_._SelX.Vod(tgtFile);

			nilnul.fs.file._ExeX.Exe(tgtFile);
			nilnul.win.prog_.notepad.run_.shell_.NewWin.Singleton.run(tgtFile.ToString());

		}
	}
}
