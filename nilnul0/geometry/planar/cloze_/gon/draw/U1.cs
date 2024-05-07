﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar;
using nilnul.obj.str;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Windows.Documents;

namespace nilnul.geometry.planar.cloze_.gon.draw
{
	public class U1
	{
		/// <summary>
		/// show the file, an img;
		/// </summary>
		/// <param name="contour"></param>
		/// <param name="width"></param>
		static public void ShowFile(IEnumerable<Point4dblI> contour, int width = 800) {

			nilnul.fs.file._ExeX.Exe(
				draw2file(contour,width)
			);


		}
		static public void ShowFile(IEnumerable<Complex> contour, int width = 800) {

			nilnul.fs.file._ExeX.Exe(
				draw2file(contour,width)
			);


		}


		static public string draw2file(IEnumerable<Complex> contour, int width = 800) {

			var img = draw2img(contour,width);

			var dnt = nilnul.fs.folder.dnt_.mainVered_.minVer_.Next.OvAddress(
				nilnul._img_._TEST_._this.data.dir_.my.child_.max.exclave.UnitTest1.Address()
			).address("gon.jpg");

			img.Save(dnt);
			return dnt;

		}
		static public string draw2file(IEnumerable<Point4dblI> contour, int width = 800) {

			var img = draw2img(contour,width);

			var dnt = nilnul.fs.folder.dnt_.mainVered_.minVer_.Next.OvAddress(
				nilnul._img_._TEST_._this.data.dir_.my.child_.max.exclave.UnitTest1.Address()
			).address("gon.jpg");

			img.Save(dnt);
			return dnt;

		}

		static public Bitmap draw2img(IEnumerable<Complex> contour, int width = 800, bool fill =false)
		{

			return draw2img(
				contour.Select( x=>(Point4dbl)(x)),width,fill
			);

		

		}

		static public Bitmap draw2img(IEnumerable<Point4dblI> contour, int width = 800, bool fill =false)
		{
			var boundingBox = nilnul.geometry.planar.points_.dwelt._BoundaryX._Boundary_0dwelt(
				contour
			);

			var w= boundingBox.size1.width;

			const double mainWide = .9d;
			var padless = width * mainWide;

			var padOneSide = width * (1-mainWide) /2;

			var padAsInt = (int)padOneSide;

			var ratio =				padless / w.realee.ee
				//w.realee.ee/padless
			;

			var aspect = boundingBox.size1.aspect();

			var height = width * aspect;//  boundingBox.size1.height.realee.ee * ratio;

			var img = new Bitmap(width, (int)height);


			using (var g = Graphics.FromImage(img))
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
				draw(g, contour, fill);



			}
			return img;

		}

		static public void draw(Graphics g,IEnumerable<Point4dblI> contour,bool fill=false)
		{
			var pS = contour.Select(p=> ( planar.PointX.ToPointF(p) )).ToArray();

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
				if (fill)
				{
					//var pen4fill = new Pen(Color.Red);
					g.FillPolygon(new SolidBrush(Color.FromArgb(20,Color.Gray) ), pS, FillMode.Alternate);
				}
				

			}
			

		}

	}
}
