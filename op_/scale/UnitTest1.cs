using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;

namespace nilnul.img._test.op_.scale
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void scale()
		{
		

			var inputPath = nilnul.fs.location_.File.Parse(@"C:\160803\data\wyt.photo\mugshot\77152241313.jpg");

			var dpi = 150;

			var outputPath = new nilnul.fs.address_.File(
				inputPath.avowed.folder
				,
				 nilnul.fs._address.doc_.Dotted.Parse(
				(inputPath.avowed.doc).main +$".scaled{dpi}dpi" ,inputPath.avowed.doc.ext
				)
			);

			var outputFormat = nilnul.img.io.Format.FroExt(
				outputPath.doc.ext
			);



			var stream = File.Create(

				outputPath.ToString()
			);


			nilnul.img.op_.Scale.Eval(
				Image.FromFile(inputPath.ToString())
				, nilnul.geometry.Length1.CreatgeMm(25), nilnul.geometry.Length1.CreatgeMm(32),
				dpi
				,
				stream,
				outputFormat
			
				);



		}
	}
}
