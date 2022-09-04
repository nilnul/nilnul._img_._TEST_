using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace nilnul.img.gif._test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void GifFrames()
		{

			var fileFolder = @"E:\170203\data\nilnul.img\_test_dir";


		//	fileFolder = @"C:\Users\ep\Desktop";
			var fileName = "6b66a2795006494e8285920f4970417820170329214324.gif";

			 var filePath= Path.Combine( AppDomain.CurrentDomain.BaseDirectory ,fileName);

			  filePath= Path.Combine( fileFolder,fileName);
			filePath = @"E:\170203\_temp\4.gif";



			var images = nilnul.img.gif.X.GetFrames(filePath);


			var saveFolder =  Path.Combine(fileFolder ,"spliced",fileName);

			Directory.CreateDirectory(saveFolder);  //An object that represents the directory at the specified path. This object is returned regardless of whether a directory at the specified path already exists.

			var savePrefix = "frame";
			var version = new nilnul.txt.stream.Version(savePrefix,".png");

			foreach (var item in images)
			{

				item.Save( Path.Combine(saveFolder, version.next()  ));

			}

		}

		private Image[] getFrames(string path) {

			return nilnul.img.gif.X.GetFrames(path);


		}



		[TestMethod]
		public void SaveGif()
		{

			var fileFolder = @"D:\wyt\data\nilnul.img\_test_dir";
			var fileName = "mengbi.gif";

			 var filePath= Path.Combine( AppDomain.CurrentDomain.BaseDirectory ,fileName);

			  filePath= Path.Combine( fileFolder,fileName);

			var images = nilnul.img.gif.X.GetFrames(filePath);

			var gif = new nilnul.img.Gif_1_();

			foreach (var item in images)
			{
				gif.AddFrame(item, 1);
				
			}

			var saveFolder = Path.Combine(fileFolder, "gifGenerated");

			Directory.CreateDirectory(saveFolder);  //An object that represents the directory at the specified path. This object is returned regardless of whether a directory at the specified path already exists.

			var savePath = Path.Combine(saveFolder,"a.gif");
			gif.save(savePath);





		}
	}
}
