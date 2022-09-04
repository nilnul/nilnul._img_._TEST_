using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace nilnul.num.real.func.plot_.imG_.pic
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// using y= a*e^-bx as the fontsize of article sections, where x is the order of section, for example, 0 for article, 1 for section, 2 for subsection
		/// note: the body text fontsize is the size of the minimal heading fontsize.
		/// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			const int readingBatch = 5;
			double a, b;
			double xset = 9, ySet = 10;     //a - yset  =  (xset -0)*2

			//a = 30;

			a = ySet + xset * 2;


			//b = 0.1;  //b=  ln(y/a) /-x

			b = Math.Log(ySet / a) / -xset;
			Debug.WriteLine($"a:{a}; b:{b}");



			Func<double, double> func = (double x) => a * Math.Exp(-b * x);
			var points = new List<nilnul.geometry.planar.Point4dbl>();
			for (int i = 0; i < 310; i++)
			{
				points.Add(
					new geometry.planar.Point4dbl(
						i,
						func(i)
					)
				);
			}

			//double outliner = 30;
			//points.Add(
			//	new geometry.planar.PointDbl(outliner, func(outliner))
			//);

			var bounding = nilnul.geometry.planar.points_.started._BoundBoxX.GetBoundingBox(
				points
			);
			var pointsCount = points.Count;
			var fontsize = 12;

			#region decide zoom ratio

			var fontsizeOriginal = nilnul.num.real.op_.binary_.Min.Op(
				bounding.size1.width.realee
				,
				bounding.size1.height.realee
			) /
			pointsCount;

			var fontsizeOriginalFloat = (float)fontsizeOriginal;


			#endregion





			//var sizeInt = bounding.size1.toSizeInt();


			var pointsF = points.Select(x => x.toPointF()).ToArray();


			// calc the reading unit
			double readingUnit = Math.Min(
				bounding.size1.height.realee / pointsCount
				,
				bounding.size1.width.realee / pointsCount
			);

			readingUnit = Math.Max(
				readingUnit,
				fontsizeOriginal

			);

			var readingUnitRounded = nilnul.num.real_.positive.coerce_.quotient_.unital_._FloorX.Floor_assumePositive(readingUnit);


			var readingUnitDbl = nilnul.num.quotient.to_._DblX.ByCastNumDen(readingUnitRounded);

			var lowerSccaleOfY = Math.Floor(bounding.point.y / readingUnitDbl);
			var upperScaleOfY = Math.Floor(bounding.heightEnd / readingUnitDbl);

			var widthOfReadingTxtY = nilnul.num.op_.binary_.Max.Op_assumeNums(
				nilnul.num.integer_.radix_._DecX.Width(
					(long)upperScaleOfY
				)
				,
				nilnul.num.integer_.radix_._DecX.Width(
					(long)lowerSccaleOfY
				)

			);

			var readingTxtWidthInUnitsY = widthOfReadingTxtY * fontsizeOriginal;


			var lowerReadingOfX = Math.Floor(bounding.point.x / readingUnitDbl);
			var upperReadingOfX = Math.Floor(bounding.widthEnd / readingUnitDbl);

			var widthOfScaleTxtX = nilnul.num.op_.binary_.Max.Op_assumeNums(
				nilnul.num.integer_.radix_._DecX.Width(
					(long)upperReadingOfX
				)
				,
				nilnul.num.integer_.radix_._DecX.Width(
					(long)lowerReadingOfX
				)

			);

			var readingTxtWidthInUnitsX = widthOfScaleTxtX * fontsizeOriginal;

			var zoomRatio = fontsize / fontsizeOriginal;
			var zoomRatioFloat = (float)zoomRatio;

			var zoomRatioChangeReading = fontsizeOriginal / fontsize;


			var zoomRatioChangeReadingFloat = (float)zoomRatioChangeReading;


			var img = new Bitmap(
				(int)((bounding.size1.width.realee + readingTxtWidthInUnitsY + fontsizeOriginal) * zoomRatio)
				,
				(int)((bounding.size1.height.realee + readingTxtWidthInUnitsX + fontsizeOriginal) * zoomRatio)
			);
			using (var g = Graphics.FromImage(img))
			using (var g2 = Graphics.FromImage(img))

			{

				var pointF = bounding.point.toPointF();
				//var matrix = new System.Drawing.Drawing2D.Matrix();
				//matrix.Translate(-pointF.X, -pointF.Y);
				//g.Transform = matrix;

				//g.Transform.Translate(-pointF.X, -pointF.Y);

				#region transform
				//g.TranslateTransform(
				//	0,
				//	img.Height
				//);

				//g.ScaleTransform(1, -1);

				g.ScaleTransform(
					zoomRatioFloat,
					zoomRatioFloat
				);


				//g.ScaleTransform(
				//	zoomRatioChangeReadingFloat,
				//	zoomRatioChangeReadingFloat
				//);

				g.TranslateTransform(
					-pointF.X + (float)readingTxtWidthInUnitsX
					,
					-pointF.Y + (float)readingTxtWidthInUnitsY
				);

				#endregion

				;
				Font drawFont = new Font("Arial", fontsizeOriginalFloat);


				// draw the axises

				var boundingRect = bounding.toRect();


				//draw y
				#region draw y axis
				Pen pen4y1 = new Pen(Color.Green, 2 * zoomRatioChangeReadingFloat);
				pen4y1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

				g.DrawLine(
					pen4y1,
					bounding.point.toPointF()
					,
					nilnul.geometry.planar.vect_.vertical.TranslateX.Lift(
						fontsizeOriginalFloat
						,
						bounding.point3.toPointF()
					)
				);

				#region draw readings


				// from the most important



				long readingCurrentY = (long)Math.Ceiling(bounding.point.y / readingUnitDbl);
				double readingCurrentYInDbl = readingCurrentY * readingUnitDbl;
				var readingCurrentYInDblAsFloat = (float)readingCurrentYInDbl;
				var i4y = 0;

				while (readingCurrentYInDbl <= bounding.heightEnd)
				{
					//draw the readings
					//p = ;


					var leftPoint = new PointF(
						-(float)readingTxtWidthInUnitsY
						,

						//readingCurrentY
						readingCurrentYInDblAsFloat
					);

					SolidBrush drawBrush = new SolidBrush(Color.LightGreen);

					if (i4y % readingBatch == 0)
					{
						g.DrawLine(
							pen4y1,
							pointF.X - (float)readingTxtWidthInUnitsY,
							readingCurrentYInDblAsFloat
							,
							pointF.X
							,
							readingCurrentYInDblAsFloat
						);

						g.DrawString(
							readingCurrentY.ToString()
							, drawFont
							,
							drawBrush
							, leftPoint
							,
							new StringFormat(

							)
							{ LineAlignment = StringAlignment.Far }

						);

					}
					else
					{

						g.DrawLine(
							pen4y1,
							pointF.X - (float)readingTxtWidthInUnitsY / 2,
							readingCurrentYInDblAsFloat
							,
							pointF.X
							,
							readingCurrentYInDblAsFloat
						);

					}
					i4y++;
					readingCurrentY++;
					readingCurrentYInDbl = readingCurrentY * readingUnitDbl;
					readingCurrentYInDblAsFloat = (float)readingCurrentYInDbl;

					//readingCurrentYInDbl += readingUnitDbl;

				}
				#endregion


				#endregion



				#region drawX axis
				var pen4Y = new Pen(
					Color.Red
					,
					2 * zoomRatioChangeReadingFloat

				);

				g.DrawLine(
					pen4Y,
					bounding.point.toPointF()
					,
					nilnul.geometry.planar.vect_.horizon.TranslateX.Shift(
						fontsizeOriginalFloat
						,
						bounding.point1.toPointF()
					)
				);

				///transform rotate -90degree, original
				//g.Transform.RotateAt(-90, bounding.point.toPointF());


				long readingCurrentX = (long)Math.Ceiling(bounding.point.x / readingUnitDbl);
				double readingCurrentInDblX = readingCurrentX * readingUnitDbl;
				float readingCurrentInDblX_asFloat = (float)readingCurrentInDblX;

				var i4x = 0;
				while (readingCurrentInDblX <= bounding.widthEnd)
				{
					//draw the scale
					//p = new Pen(Color.Black);



					//var leftPoint = new PointF(
					//	0
					//	,
					//	readingCurrentX
					//);


					//var rightPoint = new PointF(
					//	(float)readingTxtWidthInUnitsX
					//	,
					//	readingCurrentX
					//);




					SolidBrush drawBrush = new SolidBrush(Color.PaleVioletRed);

					if (i4x % readingBatch == 0)
					{
						g.DrawLine(
							new Pen(Color.Red, 2 * zoomRatioChangeReadingFloat),
							readingCurrentInDblX_asFloat,
							pointF.Y,
							readingCurrentInDblX_asFloat,
							pointF.Y - (float)readingTxtWidthInUnitsX
						);
						var rootPoint = new PointF(
							readingCurrentInDblX_asFloat
								- (float)fontsizeOriginal
							,
							pointF.Y - (float)readingTxtWidthInUnitsX
						);

						g.DrawString(
											readingCurrentX.ToString()
											, drawFont
											,
											drawBrush
											, rootPoint
											,
											new StringFormat()
											{
												Alignment = StringAlignment.Near
												,
												FormatFlags = StringFormatFlags.DirectionVertical
												,
												LineAlignment = StringAlignment.Near

											}

										);
					}
					else
					{
						g.DrawLine(
							new Pen(Color.Red, 2 * zoomRatioChangeReadingFloat),
							readingCurrentInDblX_asFloat,
							pointF.Y,
							readingCurrentInDblX_asFloat,
							pointF.Y - (float)readingTxtWidthInUnitsX / 2
						);

					}
					i4x++;

					readingCurrentX++;
					readingCurrentInDblX = readingCurrentX * readingUnitDbl;
					readingCurrentInDblX_asFloat = (float)readingCurrentInDblX;

				}
				#endregion

				#region draw unit

				var oldTransform = g.Transform;

				var currentTransform = g.Transform;



				//currentTransform.Translate(

				//		(float)readingTxtWidthInUnitsX
				//		,
				//		(float)readingTxtWidthInUnitsY

				//);
				//currentTransform.Translate(

				//		(float)pointF.X
				//		,
				//		(float)pointF.Y

				//); //move world (0,0)  to page (pointF)


				//currentTransform.Rotate(
				//	45
				//);  //rotate at world

				currentTransform.RotateAt(
					45,
					new PointF(
						(float)pointF.X
						,
						(float)pointF.Y
					)
				);
				g.Transform = currentTransform;

				g.DrawString(
					readingUnitRounded.toTxt()
					,
					drawFont
					,
					new SolidBrush(Color.Gray)
					,
					-(float)readingTxtWidthInUnitsX
					,
					//-(float)readingTxtWidthInUnitsY
					0
					, new StringFormat()
					{
						Alignment = StringAlignment.Near,
						LineAlignment = StringAlignment.Center
					}
				);
				g.Transform = oldTransform;

				#endregion


				g.DrawBeziers(new Pen(Color.Gray, 3 * zoomRatioChangeReadingFloat), pointsF);

			}
			var file = nilnul.fs.folder_.tmp.denote_.mainVered_._NextX.SpearTxt(".jpg");
			img.Save(
				file
			);

			nilnul.fs.file.explore_._SelX.Vod(file);
			nilnul.fs.file._ExeX.Exe(file);



		}
	}
}
