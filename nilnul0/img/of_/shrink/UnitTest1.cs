using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;

namespace nilnul.img._test.op_.shrink
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void shrinkImage()
		{
			var fileName = "untitled.png";

			var nameExt = nilnul.win.storage._location.file.Fullname._ToNameExt(fileName);

			var newName = nilnul.win.storage._location.file.Fullname.FroNameExt(
				nameExt[0]+".shrinked" 
				,
				nameExt[1]
				);
			var filePath = System.IO.Path.Combine(Cfg.TEST_DIR, "untitled.png");

			var stream = File.Create(

				System.IO.Path.Combine(Cfg.TEST_DIR,

				newName
				
				)
			);


			nilnul.img.op_.Scale.ShrinkOnly(
				Image.FromFile(filePath)
				,50,80,stream
			
				);



		}
	}
}
