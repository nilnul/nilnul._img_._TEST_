using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar;
using System;
using System.Drawing;

namespace nilnul._img_._TEST_.nilnul0.num.complex.collection_.mandelbrot.draw.clip
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			
				T();
			
		}
		 void T()
		{

			var size = 1024;
			
			var img =nilnul.num.complex.collection_.mandelbrot._DrawX.Draw(
				size
				,
				.4
				,
				.6
				,
				.5
				,
				.6
			); 

			
			var file = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".jpg");

			img.Save(
				file

			);

			nilnul.fs.file._ExeX.Exe(file);
		}
	}
}
