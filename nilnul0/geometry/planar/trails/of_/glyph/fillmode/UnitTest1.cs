using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace nilnul.geometry._planar_._TEST_.trails.of_.glyph.fillmode
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var font = new Font("Times New Roman", 300);
			var nests = nilnul.geometry.planar.cycle_.gons.of_.glyph_.retTree_._LogicEmbedX.CyclesAsTrees(
				'A'

				, font
			);

			using (var img = new Bitmap(400, 400))
			{
				using (var g = Graphics.FromImage(img))
				using (var pen = new Pen(Color.Red))
				{
					pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
					pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
					pen.CustomEndCap = new AdjustableArrowCap(3, 3);
					pen.DashStyle = DashStyle.Dash;
					pen.DashCap = DashCap.Triangle;


				

					nests.Each(
						t =>
							t.Each(
								cycle => {
									var hueNumber = 0f;
									var hue = nilnul._img.color_.hsb._ToRgbX.FromHsb(
										hueNumber
										,
										0.5f,0.5f
									);

									pen.Color = hue;

									var hueStep =(double) nilnul._img.color_._hsb.Hue.TOTAL / cycle.grads.Count();

									cycle.grads.Each(
										grad => {

											planar.grad._DrawX.Draw(
												g
												,
												grad
												,
												pen
											);

											hueNumber += (float)hueStep;
											pen.Color=nilnul._img.color_.hsb._ToRgbX.FromHsb(
												hueNumber
												,
												0.5f,0.5f
											);
											
										

										}
									);

									//g.DrawPolygon(
									//	pen
									//	,
									//	cycle.vertexes.Select(p => planar.PointX.ToPointF(p)).ToArray()

									//);
								}
							)

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
