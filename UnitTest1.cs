using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			//read the text file.
			//read as xml



			XDocument document = XDocument.Load(@"D:\wyt\360yun\work130918\sln\nilnul.img\svg._web\borders\certificate\blanked\blanked.svg");
            XElement svg_Element = document.Root;
            var gg = (from svg_path in svg_Element.Descendants("{http://www.w3.org/2000/svg}path")
                     select svg_path).ToList();

            //If you want to get one element, please change the index
            //gg[index].ToString();

			//txtSelect.Text = gg[0].ToString();
			////Get all path Elements
			//StringBuilder sb = new StringBuilder();
			//foreach (var item in gg)
			//{
			//	sb.Append(item.ToString());
			//}
			//txtAll.Text = sb.ToString();

			var path = gg.First();

			var pathD = path.Attribute("d");

			var pathDVal = pathD.Value;

			var zCount = pathDVal.ToCharArray().Count(x => x == 'z');

			var charArry = pathDVal.ToCharArray();


			for (int i = 0; i < charArry.Length; i++)
			{
				if (charArry[i] == 'z' || charArry[i] == 'z')
				{
					if (i==charArry.Length-1)
					{
						break;
						
					}
					if (!(charArry[i+1]=='m' || charArry[i+1]=='M'))
					{
						throw new Exception(i.ToString() + charArry[i].ToString()+charArry[i+1].ToString());
					}
				}
			}

			var doc = new XDocument();
			var loadRoot=
			XElement.Load(new StringReader("<svg width=\"893.60645\" height=\"1254.8467\" xmlns=\"http://www.w3.org/2000/svg\"></svg>"));

			var svgElement = new XElement("svg");
			svg_Element.Value = "<svg width=\"893.60645\" height=\"1254.8467\" xmlns=\"http://www.w3.org/2000/svg\">";

			doc.Add(loadRoot);



			var pathSplit = pathDVal.Split('z');

			var pathSegmentedS=new List<XElement>();
				var elementName = XName.Get("path", "http://www.w3.org/2000/svg");

			foreach (var item in pathSplit)
			{

				var pathSegmentted = new XElement(elementName);
//				var pathSegmentted = new XElement("path");
				
				XName attrD=XName.Get("d");


				pathSegmentted.Add(new XAttribute( attrD,item+"z") );
				//pathSegmentted.Attribute("d").Value = item + "z";
				pathSegmentedS.Add(pathSegmentted);
				loadRoot.Add(pathSegmentted);
			}

			doc.Save(@"D:\data\nilnul.img\_dir\borders\certificate\blanked\blanked_segmented_local.svg");












		}
	}
}
