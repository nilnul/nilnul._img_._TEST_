using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace nilnul.img.gif_.spear.toImgs
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void t()
		{



		//	fileFolder = @"C:\Users\ep\Desktop";



			 var filePath = @"E:\170203\data\nilnul.geometry._planar_\_KEN_\shape_\parralelogram\area\201411281.gif";

			var spear = new nilnul.fs.address_.Spear(filePath);
			var fileName = spear.sprig.document.doc;


			var fileFolder = new nilnul.fs.address_.spear_.ParentDoc(spear).parent;//.shield;

			var images = nilnul.img.gif.X.GetFrames(filePath);


			var saveFolder =  Path.Combine(fileFolder.ToString() ,"spliced",fileName.ToString());

			Directory.CreateDirectory(saveFolder);  //An object that represents the directory at the specified path. This object is returned regardless of whether a directory at the specified path already exists.

			var savePrefix = "frame";
			var version = new nilnul.txt.stream.Version(savePrefix,".png");

			foreach (var item in images)
			{

				item.Save( Path.Combine(saveFolder, version.next()  ));

			}

			nilnul.fs.folder.explore_._ByExeSelfX.OfAddress(saveFolder);

		}

		private Image[] getFrames(string path) {

			return nilnul.img.gif.X.GetFrames(path);


		}



	
	}
}
