using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Drawing;

namespace nilnul.img._test.zip_.over
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Over()
		{



			var underImageFolder = $@"C:\160803\data\wyt.research\_PreData\prj.approved\教育厅人文社科16";

			var underImageDoc = $"budgetFroHbue-0.png";
			var underImageFile = System.IO.Path.Combine(underImageFolder,underImageDoc);

			var overImageFolder = $@"C:\160803\data\wyt\sinature 签名";

			var overImageDoc = $"signature20061029 2303.gif";
			var overImageFile = System.IO.Path.Combine(overImageFolder,overImageDoc);


			//var underImageFile = System.IO.Path.GetFileName(overImageFile);

			var nameExt = nilnul.win.storage._location.file.Fullname._ToNameExt(underImageFile);

			var newName = nilnul.win.storage._location.file.Fullname.FroNameExt(
				nameExt[0] + ".signed"
				,
				nameExt[1]
				);


			var underImgFolder = System.IO.Path.GetDirectoryName(underImageFile);


			//var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "_testOutput");

			//Directory.CreateDirectory(folder);

			var fileSavePath = System.IO.Path.Combine(underImgFolder, newName);




			var imgUnder = System.Drawing.Image.FromFile(underImageFile);

			var imgOver = System.Drawing.Image.FromFile(overImageFile);

			Bitmap imgOverTransparent = new Bitmap( overImageFile);
			imgOverTransparent.MakeTransparent( Color.White);

			var positionLeft = 0.2f;
			var positionTop = .97f;

			var newWidth = imgUnder.Width * .2f;

			var newHeight = imgUnder.Height * .06f;

			var overRatio = 0.59f;

			newWidth *= overRatio;
			newHeight *= overRatio;

			Graphics g = Graphics.FromImage(imgUnder);
			g.DrawImage(
				imgOverTransparent
				,
				new RectangleF((imgUnder.Width * positionLeft), (imgUnder.Height * positionTop),newWidth, newHeight
				)
				,
				new RectangleF(
					0, 0, imgOver.Width, imgOver.Height

					)
					, GraphicsUnit.Pixel
			);
			imgUnder.Save(fileSavePath);








		}
	}
}
