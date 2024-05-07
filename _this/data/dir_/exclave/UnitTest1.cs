using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul._img_._TEST_._this.data.dir_.exclave
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		}
		static public string Address(string dnt=".tmp")
		{
			var data = _this.data.UnitTest1.Shield();

			var dataAddress = System.IO.Path.Combine(data.ToString());

			var exclave = nilnul.fs.folder.dir_.exclave_.newest._EnsureX._Enclave_1ensure4enclave(
				dataAddress
				,
				dnt
			);

			var exclaveAsAddress = System.IO.Path.Combine(
				dataAddress, exclave
			);
			return exclaveAsAddress;


		}	}
}
