using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;

namespace nilnul.img._test.op_.flip
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Flip()
		{
			var filePath = $@"C:\160803\data(wyt\wyt.app_.fx(missile rocket fanxin ls-dyna lsdyna\_win" + @"\big_thumb_dab3.jpg";

			var fileName = Path.GetFileName(filePath);

			var nameExt = nilnul.win.storage._location.file.Fullname._ToNameExt(fileName);

			var newName = nilnul.win.storage._location.file.Fullname.FroNameExt(
				nameExt[0]+".fliped" 
				,
				nameExt[1]
				);
			var originFolder = Path.GetDirectoryName(filePath);


			var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "_testOutput");

			Directory.CreateDirectory(folder);

			var fileSavePath = System.IO.Path.Combine(originFolder, newName);


		

			var image = Image.FromFile(filePath);

			nilnul.img.op_.Flip.Eval(image);
			image.Save(
				fileSavePath
				
			);


		



		}
	}
}
