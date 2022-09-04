using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._img_._TEST_.eg_.jpg.convert_.reduceBlob
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var original = @"D:\170203\data\wyt._biz_\org_\nilnulCom\_finance_\borrow_\y20m4\infoCollect.jpg";
			var container = nilnul.fs.address_.spear._ContainerX.TxtUptoLastSep(original);

			var main = nilnul.fs.address_.spear._DocMainX.__Txt(original);

			var newFile =  nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next.OvAddress(
				container
				).address($"{main}.reduced.jpg");

			nilnul.img_.jpg.convert_._ReduceBlobX.Save_intendedBytes(
				@"D:\170203\data\wyt._biz_\org_\nilnulCom\_finance_\borrow_\y20m4\infoCollect.jpg"

,
				nilnul.num_.radix_.binary_.Mega.INT32
				,
				newFile

				);
		}
	}
}
