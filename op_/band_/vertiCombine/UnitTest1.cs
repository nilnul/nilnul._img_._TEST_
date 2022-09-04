using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._img_._TEST_.co.band_.vertiCombine
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var first = @"D:\170203\data\wyt._biz_\org_\nilnulCom\_finance_\borrow_\y20m4\WeChat Image_20200421151439.jpg";
			var b = @"D:\170203\data\wyt._biz_\org_\nilnulCom\_finance_\borrow_\y20m4\WeChat Image_20200421151445.jpg";
			var folder = nilnul.fs.address_.spear._ContainerX.Shield(first);


			var combined = nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next.OvAddress(folder.ToString()).address("combined.jpg");
			nilnul.img.co.band_._VertiCombineX.Address(
				first, b, combined
			);
			nilnul.fs.file.explore_._SelX.Vod(combined);
			nilnul.fs.file._ExeX.Exe(combined);
		}
	}
}
