using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;

namespace nilnul.img._test.clip
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void clip()
		{
			var folder =  nilnul.fs.address_.Shield.FroAddress(@"E:\170203\data\wyt\_PreData\cert_\diploma_\doctor_");

			var doc = new nilnul.fs._address.Doc(@"degree1.rotated-0.9918993.jpg");


			var file1 = new nilnul.fs.address_.spear_.ParentDoc(folder, doc);


			var file = file1.ToString();

			var src = Image.FromFile(file);


			var left = src.Width *.0182192432123225 //.232
				;

			var remainedWidth = (int)(src.Width - left);
			
			var width=(int)( src.Width *.91895423541536//.65//.64// .66 // .67
			);

			var top = src.Height * .14851903135255// .05// .042//.06//.08//.1 //.175 
				;

			var remainedHeight = (int)(src.Height - top);//  *.9273285314//.32// .33//.3//

			var height = (int)(src.Height - top);//  *.9273285314//.32// .33//.3//
				
				

			


			var target = new Bitmap(
				width,
				height
			);

			var rect = new Rectangle(
						(int)left,
						(int)top
						,
						width
						,
						height
				
				);
			using (var g=Graphics.FromImage(target))
			{
				g.DrawImage(src,
					new Rectangle( 
						0,
						0
						,
						width
						,
						height
						
					)
					,rect
					,GraphicsUnit.Pixel
					
				);
			}


			var srcFile = nilnul.fs.address_.File.Parse(file);

			

			var newNameMain = srcFile.doc.main +".cropped";

			var newExt = srcFile.doc.ext;

			var newDocName = new nilnul.fs._address.doc_.Dotted(newNameMain, newExt);

			


			

			Directory.CreateDirectory(srcFile.folder.ToString());

			var fileSavePath =new nilnul.fs.address_.File(srcFile.folder, newDocName);

			target.Save(
				fileSavePath.ToString()
			);

			nilnul.fs.file._OpenX.Open(fileSavePath.ToString());
		}
	}
}
