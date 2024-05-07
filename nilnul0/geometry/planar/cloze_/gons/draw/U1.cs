using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar;
using nilnul.geometry.planar.facet_;
using nilnul.obj.str;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace nilnul.geometry.planar.cloze_.gons.draw
{
	public class U1
	{
		static public string draw(int width = 800,bool fill=false, params IEnumerable<Point4dblI>[] contour ) {


			var img = drawGons(width,fill,contour);



			var dnt = nilnul.fs.folder.dnt_.mainVered_.minVer_.Next.OvAddress(
				nilnul._img_._TEST_._this.data.dir_.my.child_.max.exclave.UnitTest1.Address()
			).address("gon.jpg");

			img.Save(dnt);
			return dnt;

		}

		static public void show(int width ,  IEnumerable<IEnumerable<Point4dblI>> contour,bool fill=false ) {

			nilnul.fs.file._ExeX.Exe(
				draw(
					width,fill,contour.ToArray()
					
				)
			);


		}
		static public void show(int width = 800,bool fill=false, params IEnumerable<Point4dblI>[] contour ) {

			nilnul.fs.file._ExeX.Exe(
				draw(width,fill,contour)
			);


		}

		static public Bitmap drawGon(Bitmap img,IEnumerable<Point4dblI> contour, int width = 800)
		{

			using (var g = Graphics.FromImage(img))
			using (var pen = new Pen(Color.Red))
			{
				pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
				pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
				pen.CustomEndCap = new AdjustableArrowCap(3, 3);
				pen.DashStyle = DashStyle.Dash;
				pen.DashCap = DashCap.Triangle;


				var hueNumber = 0f;
				var hue = nilnul._img.color_.hsb._ToRgbX.FromHsb(
					hueNumber
					,
					0.5f, 0.5f
				);

				pen.Color = hue;

				var hueStep = (double)nilnul._img.color_._hsb.Hue.TOTAL / contour.Count();

				var grads = nilnul.geometry.planar.cloze_.gon._Grads4dblX._Grads_ofStarted(contour);
				grads.Each(
					grad =>
					{

						planar.grad._DrawX.Draw(
							g
							,
							grad
							,
							pen
						);

						hueNumber += (float)hueStep;
						if (hueNumber >= 360)
						{
							hueNumber = 359.99f;
						}
						pen.Color = nilnul._img.color_.hsb._ToRgbX.FromHsb(
							hueNumber
							,
							0.5f, 0.5f
						);

					}
				);

			}
			return img;

		}

		static public Bitmap drawGons(int width,bool fill, params IEnumerable<Point4dblI>[] contour )
		{
			var boundingBox = nilnul.geometry.planar.points_.dwelt._BoundaryX._Boundary_0dwelt(
				contour.SelectMany(x => x)
			);

			var w= boundingBox.size1.width;

			var padless = width * .9d;

			var pad = width * .1d /2;

			var padAsInt = (int)pad;

			var ratio =				padless / w.realee.ee
				//w.realee.ee/padless
			;

			var aspect = boundingBox.size1.aspect();

			var height = width * aspect;//  boundingBox.size1.height.realee.ee * ratio;

			var img = new Bitmap(width, (int)height);

			using (var g=Graphics.FromImage(img) )
			{

				float ratio1 = (float)ratio;

				g.TranslateTransform(
					-(float)boundingBox.anchor.x
					,
					-(float) boundingBox.anchor.y
					//, MatrixOrder.Append
				);

				g.ScaleTransform(
					ratio1,ratio1
					, MatrixOrder.Append
				);
				g.TranslateTransform(
					padAsInt
					,
					padAsInt
					, MatrixOrder.Append
				);


				drawGons(g,fill, contour);


			}
			//contour.Each(
			//	g=>
			//	drawGon(img,g,width)
			//);
			
			return img;

		}
		static public void drawGons(Graphics g,bool fill, params IEnumerable<Point4dblI>[] contour )
		{
			//var boundingBox = nilnul.geometry.planar.points_.dwelt._BoundaryX._Boundary_0dwelt(contour.SelectMany(x => x));

			//var w= boundingBox.size1.width;

			
			
			contour.Each(
				a=>
				cloze_.gon.draw.U1.draw(
					g, a
					,
					fill
					//nilnul.geometry.planar.cloze_.gon.be_.surround_._ProwindX._Be_0started(a)
					

				)
				
			);
			
			

		}

		public static void Show(Gon4dbl facet)
		{
			show(800, facet.cycles);
		}

		public static void Show(IEnumerable<IEnumerable<Point4dblI>> zones,bool fill=false)
		{
			show(800, zones,fill);

		}

		public static void Show(IEnumerable<Point4dblI> conduit,bool fill=false)
		{
			Show([conduit] ,fill);
		}

		public static void Show((double, double)[] facet)
		{
			Show(facet.Select(t=> new Point4dbl(t.Item1,t.Item2) ));
		}
	}
}
