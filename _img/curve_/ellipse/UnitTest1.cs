using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.IO;

namespace nilnul.img._test._img.curve_.ellipse
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Arc()
		{

			Bitmap dot = new Bitmap(400, 400);
			Graphics flagGraphics = Graphics.FromImage(dot);


			var path=nilnul.geometry.planar.ellipse.Extensions.CreateQuarter(
				5,5, 200,300 
					
			);


			var path1=nilnul.geometry.planar.ellipse.Extensions.CreateQuarter(
				 200,300 ,5,5
					
			);
			flagGraphics.DrawPath(Pens.Red , path );

			flagGraphics.DrawPath(Pens.Green , path1 );

			var pa = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
			var p1 = AppDomain.CurrentDomain.BaseDirectory;
			string codeBase = Assembly.GetExecutingAssembly().Location;
			
			var cc=Assembly.GetExecutingAssembly().CodeBase;
			cc = AppDomain.CurrentDomain.RelativeSearchPath;
			cc = AppDomain.CurrentDomain.BaseDirectory;



			var p3=  System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); // this may be global cache.

			var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "_testOutput");

			Directory.CreateDirectory(folder);

			var fileSavePath = System.IO.Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "_testOutput", "ellipseArc.png");

			dot.Save(
				fileSavePath, ImageFormat.Png);
			dot.Save(img.FileInstanceSPath.GeneratePath("t--l.png"), ImageFormat.Png);

		}
	}
}
