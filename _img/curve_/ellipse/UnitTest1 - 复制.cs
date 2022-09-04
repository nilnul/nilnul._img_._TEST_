using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Drawing.Drawing2D;

namespace nilnul.img._test._img.curve_.ellipse
{
	[TestClass]
	public class UnitTest12
	{
		[TestMethod]
		public void ArcEllipse()
		{

			Bitmap dot = new Bitmap(400, 400);
			Graphics flagGraphics = Graphics.FromImage(dot);



			RectangleF Rect = new RectangleF(0, 0, dot.Width,dot.Height);


			GraphicsPath GraphPath = nilnul._img.closure_._roundedRect.GeneratePath.GetClosure(Rect, 0.2f);
			flagGraphics.DrawPath(
				new Pen(Color.Blue, 5),

				GraphPath	
			);
 
 
			var pa = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
			var p1 = AppDomain.CurrentDomain.BaseDirectory;
			string codeBase = Assembly.GetExecutingAssembly().Location;
			
			var cc=Assembly.GetExecutingAssembly().CodeBase;
			cc = AppDomain.CurrentDomain.RelativeSearchPath;
			cc = AppDomain.CurrentDomain.BaseDirectory;



			var p3=  System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); // this may be global cache.



			//dot.Save(
			//	System.IO.Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,"_testOutput", "ellipseArc.png") , ImageFormat.Bmp);
			dot.Save(img.FileInstanceSPath.GeneratePath("t--l.png"), ImageFormat.Png);

		}
	}
}
