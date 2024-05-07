using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.XFeatures2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace nilnul._img_._TEST_.co_.isowide.stitch_
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// 
		/// </summary>
		/// https://stackoverflow.com/questions/63056321/image-stitching-with-opencvsharp
		///
		/// https://colab.research.google.com/drive/11Md7HWh2ZV6_g3iCYSUw76VNr4HzxcX5#scrollTo=ww8t8MhAE9gY
		///
		/// https://stackoverflow.com/questions/10730794/having-some-difficulty-in-image-stitching-using-opencv?rq=4
		///
		/// stackoverflow.com/questions/6017943/opencv-image-stitching?rq=4
		/// 
		[TestMethod]
		public void TestMethod1()
		{
			var img = @"D:\170203\data\wyt._living_\house_.binhu1hao(Git\resell(Git\litigation\_WEB_\article_\_evidence_\sect_\weixin_\_beike\136.jpg";

			var img1 = @"D:\170203\data\wyt._living_\house_.binhu1hao(Git\resell(Git\litigation\_WEB_\article_\_evidence_\sect_\weixin_\_beike\259.jpg";

			var folder = @"D:\170203\data\wyt._living_\house_.binhu1hao(Git\resell(Git\litigation\_WEB_\article_\_evidence_\sect_\weixin_\_beike\";

			var outNext = nilnul.fs.folder.dir_.exclave_.next_._Min8timestampX._Enclave_1ensure4enclave(
				folder
				, "combined"
			);



			Form1_Load(img, img1, System.IO.Path.Combine(folder, outNext));

		}

		private void Form1_Load(string img, string img1, string locationFolder)
		{
			bool debugImages = true;
			//string locationFolder = "";

			//locationFolder = Path.GetDirectoryName(dlg.FileNames[0]) + "\\output\\";

			List<Mat> imagesMat = new List<Mat>();
			Bitmap fromFile = new Bitmap(img);

			Mat source = BitmapConverter.ToMat(fromFile);
			imagesMat.Add(source);

			Bitmap fromFile1 = new Bitmap(img1);

			Mat source1 = BitmapConverter.ToMat(fromFile1);
			imagesMat.Add(source1);




			//if (imagesMat.Count != 2)
			//	throw new Exception("Select only 2 images!!!");

			int imageCounter = 0;
			Mat trainImg = imagesMat[0];
			Mat queryImg = imagesMat[1];

			Mat trainImg_gray = new Mat();
			Mat queryImg_gray = new Mat();
			Cv2.CvtColor(trainImg, trainImg_gray, ColorConversionCodes.BGRA2GRAY);
			Cv2.CvtColor(queryImg, queryImg_gray, ColorConversionCodes.BGRA2GRAY);

			// detecting keypoints
			// FastFeatureDetector, StarDetector, SIFT, SURF, ORB, BRISK, MSER, GFTTDetector, DenseFeatureDetector, SimpleBlobDetector
			string method = "SURF";
			string feature_matching = "bf"; //bf, knn
			var descriptor = SURF.Create(500, 4, 2, true);

			Mat descriptors1 = new Mat();
			Mat descriptors2 = new Mat();
			KeyPoint[] kpsA;
			KeyPoint[] kpsB;
			descriptor.DetectAndCompute(trainImg_gray, null, out kpsA, descriptors1);
			descriptor.DetectAndCompute(queryImg_gray, null, out kpsB, descriptors2);

			// Match descriptor vectors 
			//var flannMatcher = new FlannBasedMatcher();
			DMatch[] matches;
			if (feature_matching == "bf")
				matches = matchKeyPointsBF(descriptors1, descriptors2, method);
			else
				matches = matchKeyPointsKNN(descriptors1, descriptors2, 0.75, method);

			var bfView = new Mat();
			Cv2.DrawMatches(trainImg, kpsA, queryImg, kpsB, matches, bfView, null, flags: DrawMatchesFlags.NotDrawSinglePoints);
			if (debugImages)
			{
				using (Bitmap resultBitmap = BitmapConverter.ToBitmap(bfView))
					resultBitmap.Save(locationFolder + (imageCounter++).ToString().PadLeft(3, '0') + ".png", ImageFormat.Png); //1
			}

			Mat H = getHomography(kpsA, kpsB, descriptors1, descriptors2, matches, 4);
			if (H == null)
				throw new Exception("No Homography!!!");
			//for (var i = 0; i < H.Cols; i++)
			//{
			//    for (var j = 0; j < H.Rows; j++)
			//        Console.Write(H.At<float>(i, j) + " ");
			//    Console.WriteLine("");
			//}

			double width = trainImg.Size().Width + queryImg.Size().Width;
			double height = trainImg.Size().Height + queryImg.Size().Height;

			Mat result = new Mat();
			Cv2.WarpPerspective(trainImg, result, H, new OpenCvSharp.Size(width, height));
			if (debugImages)
			{
				using (Bitmap resultBitmap = BitmapConverter.ToBitmap(result))
					resultBitmap.Save(locationFolder + (imageCounter++).ToString().PadLeft(3, '0') + ".png", ImageFormat.Png); //1
			}

			result[new Rect(new OpenCvSharp.Point(0, 0), new OpenCvSharp.Size(queryImg.Size().Width, queryImg.Size().Height))] = queryImg;
			if (debugImages)
			{
				using (Bitmap resultBitmap = BitmapConverter.ToBitmap(result))
					resultBitmap.Save(locationFolder + (imageCounter++).ToString().PadLeft(3, '0') + ".png", ImageFormat.Png); //2
			}

			//# transform the panorama image to grayscale and threshold it 
			Mat gray = result.Clone();
			Cv2.CvtColor(result, gray, ColorConversionCodes.BGR2GRAY);
			Mat thresh = new Mat();
			double thresh2 = Cv2.Threshold(gray, thresh, 0, 255, ThresholdTypes.Binary);
			//# Finds contours from the binary image
			OpenCvSharp.Point[][] cnts;
			HierarchyIndex[] hierarchy;
			Cv2.FindContours(thresh, out cnts, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
			OpenCvSharp.Point[] cnts2 = new OpenCvSharp.Point[cnts[0].Length];
			for (var k = 0; k < cnts[0].Length; k++)
				cnts2[k] = cnts[0][k];
			//InputArray ptsA = InputArray.Create(cnts2);
			//var c = Cv2.ContourArea(ptsA, true);
			OpenCvSharp.Rect xywh = Cv2.BoundingRect(cnts2);
			result = result[new Rect(new OpenCvSharp.Point(xywh.X, xywh.Y), new OpenCvSharp.Size(xywh.Width, xywh.Height))];
			//result = result[new Rect(new OpenCvSharp.Point(0, 0), new OpenCvSharp.Size(256, 256))];
			Bitmap endResultBitmap = BitmapConverter.ToBitmap(result);
			endResultBitmap.Save(locationFolder + (imageCounter++).ToString().PadLeft(3, '0') + ".png", ImageFormat.Png); //4


			Environment.Exit(-1);

		}

		private BFMatcher createMatcher(string method, bool crossCheck)
		{
			//"Create and return a Matcher Object"
			if (method == "SURF" || method == "SIFT")
				return new BFMatcher(NormTypes.L2, crossCheck);
			else //if (method == "ORB" || method == "BRISK")
				return new BFMatcher(NormTypes.Hamming, crossCheck);
		}

		private DMatch[] matchKeyPointsBF(Mat featuresA, Mat featuresB, string method)
		{
			BFMatcher bf = createMatcher(method, crossCheck: true);
			// # Match descriptors.
			DMatch[] bfMatches = bf.Match(featuresA, featuresB);
			//# Sort the features in order of distance.
			//# The points with small distance (more similarity) are ordered first in the vector
			DMatch[] rawMatches = bfMatches.OrderBy(a => a.Distance).ToArray();
			if (rawMatches.Length > 100)
				Array.Resize(ref rawMatches, 100);
			return rawMatches;
		}

		private DMatch[] matchKeyPointsKNN(Mat featuresA, Mat featuresB, double ratio, string method)
		{
			BFMatcher bf = createMatcher(method, crossCheck: false);
			// # compute the raw matches and initialize the list of actual matches
			DMatch[][] rawMatches = bf.KnnMatch(featuresA, featuresB, 2);
			List<DMatch> rawMatches2 = new List<DMatch>();
			//# loop over the raw matches
			DMatch prevmatchN = rawMatches[0][0];
			rawMatches2.Add(prevmatchN);
			for (int m = 0; m < rawMatches.Length; m++)
			{
				for (int n = 0; n < rawMatches[m].Length; n++)
				{
					//# ensure the distance is within a certain ratio of each
					//# other (i.e. Lowe's ratio test)
					DMatch matchN = rawMatches[m][n];
					if (n == 0)
						prevmatchN = matchN;
					if (prevmatchN.Distance < matchN.Distance * (ratio))
						rawMatches2.Add(matchN);
					if (rawMatches2.Count >= 100)
						break;
				}
			}
			return rawMatches2.ToArray();
		}

		private Mat getHomography(KeyPoint[] kpsA, KeyPoint[] kpsB, Mat featuresA, Mat featuresB, DMatch[] matches, int reprojThresh)
		{
			//# convert the keypoints to numpy arrays
			Point2f[] PtA = new Point2f[matches.Length];
			Point2f[] PtB = new Point2f[matches.Length];
			for (int i = 0; i < matches.Length; i++)
			{
				KeyPoint kpsAI = kpsA[matches[i].QueryIdx];
				KeyPoint kpsBI = kpsB[matches[i].TrainIdx];

				PtA[i] = new Point2f(kpsAI.Pt.X, kpsAI.Pt.Y);
				PtB[i] = new Point2f(kpsBI.Pt.X, kpsBI.Pt.Y);
			}
			InputArray ptsA = InputArray.Create(PtA);
			InputArray ptsB = InputArray.Create(PtB);
			if (matches.Length > 4)
			{
				//You get the homography matrix usin
				Mat H = Cv2.FindHomography(ptsA, ptsB, HomographyMethods.Ransac, reprojThresh);
				//and then to get any point on the target picture from the original picture:
				//Mat targetPoint = new Mat();
				//Cv2.PerspectiveTransform(ptsA, targetPoint, H);
				return H;
			}
			else
				return null;
		}
	}
}
