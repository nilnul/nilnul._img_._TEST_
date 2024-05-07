using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace nilnul.geometry._planar_._TEST_.facet_.gon_.conduit.of_.minDistanceNotWork
{
	/// <summary>
	/// /nilnul.geometry._planar_/_KEN_(Git/facet_/holed_/gon/to_/_coil/TriangulationByEarClipping.pdf
	/// the min distance method might have a bug: the point with the minimal distance might result in a connection passing thru other edges.
	///
	/// this proves the bug
	/// </summary>
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void MyTestMethod()
		{
			var width = 910;
			var height = 650;

			using (var img = new Bitmap(width, height))
			{
				using (var g = Graphics.FromImage(img))
				using (var pen = new Pen(Color.Red))
				{
					pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
					pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
					pen.CustomEndCap = new AdjustableArrowCap(3, 3);
					pen.DashStyle = DashStyle.Dash;
					pen.DashCap = DashCap.Triangle;

					var conduit = TestMethod1();
					var grads = nilnul.geometry.planar.cloze_.gon._Grads4dblX._Grads_ofStarted(conduit);

					void drawGon(IEnumerable<Point4dblI> contour)
					{
						var hueNumber = 0f;
						var hue = nilnul._img.color_.hsb._ToRgbX.FromHsb(
							hueNumber
							,
							0.5f, 0.5f
						);

						pen.Color = hue;

						var hueStep = (double)nilnul._img.color_._hsb.Hue.TOTAL / grads.Count();


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

					drawGon(conduit);

					//foreach (var item in facet.holes.ee)
					//{
					//	drawGon(item);
					//}




				}
				var file = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".jpg");

				img.Save(
					file

				);

				nilnul.fs.file._ExeX.Exe(file);
			}
		}

		/// <summary>
		/// see nilnul.img
		/// </summary>
		public System.Collections.Generic.IEnumerable<planar.Point4dblI> TestMethod1()
		{

			var facet = new nilnul.geometry.planar.facet_.Gon4dbl(
				new planar.cycle_.gon_.Facade4dbl(
						(71, 89)
						,
						(665, 52)
						,
						(840, 590)
						,
						(601, 482)
						,
						(608, 238)
						,
						(456, 253)
						,
						(474, 227)
						,
						(430, 240)
						,
						(595, 170)  //the point with the nearest angel to the ray. note y points down. so this needs to be bigger to be lower
						,
						(319, 251)
						,
						(342, 597)
						,
						(138, 572)
				)
				,
				new planar.cycle_.gon_.Antiwise4dbl(
					(292, 164)
					,
					(188, 268)
					,
					(275, 495)
				)
			);


			nilnul.geometry.planar.cloze_.gons.draw.U1.show(
				800, facet.holes.Select(h => h.vertexes).Append(facet.contour.vertexes).ToArray()

			);

			/// <see cref=" int geometry test"/>
			//var conduit = nilnul.geometry.planar.facet_.gon_.conduit.of_..coerce_._MinDistanceXpn4dblX.Of(
			//	facet
			//);

			var conduit = nilnul.geometry.planar.facet_.gon_.conduit.of_.coerce_._MinCuspX.Of(
				facet
			);


			return conduit;


		}
	}
}
