using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace nilnul.geometry._planar_._TEST_.facet_.gon.nest
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{
			var width = 400;
			var font = new Font("Times New Roman", (int) (width*.95));
			var nests = nilnul.geometry.planar.cycle_.gons.of_.glyph_._RetCyclesX.Cycles(
				'.'
				//'6'
				//'泳'
				//'A'

				,font
			);



			var nestsAsArr = nests.ToArray();


			using (var img = new Bitmap(width, width))
			{
				using (var g = Graphics.FromImage(img))
				using (var pen = new Pen(Color.Red))
				{
					pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
					pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
					pen.CustomEndCap = new AdjustableArrowCap(3, 3);
					//pen.DashStyle = DashStyle.Dash;
					//pen.DashCap = DashCap.Triangle;



					nests.Each(
						nest =>
							 {

									void drawGon(planar.cycle_.Polygon4dblI contour) {
										var hueNumber = 0f;
										var hue = nilnul._img.color_.hsb._ToRgbX.FromHsb(
											hueNumber
											,
											0.5f, 0.5f
										);

										pen.Color = hue;

										var hueStep = (double)nilnul._img.color_._hsb.Hue.TOTAL / nest.grads.Count();

									contour.grads.Each(
										grad => {

											planar.grad._DrawX.Draw(
												g
												,
												grad
												,
												pen
											);

											hueNumber += (float)hueStep;
											if (hueNumber>=360)
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

									drawGon(nest);

									



								
								}
							

					);
				}
				var file = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".jpg");

				img.Save(
					file

				);

				nilnul.fs.file._ExeX.Exe(file);


			}


			

		}
	}
}
