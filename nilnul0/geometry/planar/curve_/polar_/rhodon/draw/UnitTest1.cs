using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul._img_._TEST_.nilnul0.geometry.planar.curve_.polar_.rhodon.draw
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			MethodName(
				1		/// the drawing is a circl above the x axis. the diameter is the amplitude.
						/// when angle is over pi, or is negatively from 0 to -pi, the polar deviation is negative. so the circle is draw twice.
						///

			);


		}

		static public void MethodName(int freq)
		{

			var img = nilnul.geometry.planar.curve_.polar_.rhodon._DrawX.Draw(
				new nilnul.geometry.planar.curve_.polar_.Rhodonea(
					freq
				)
				,
				100
				,
				2
			);

			var tgtFile = _this.data.dir_.exclave.dnt_.next.UnitTest1.Address("a", ".gif");

			img.Save(tgtFile);


			nilnul.fs.file.explore_._SelX.Vod(tgtFile);

			nilnul.fs.file._ExeX.Exe(tgtFile);
			//nilnul.win.prog_.notepad.run_.shell_.NewWin.Singleton.run(tgtFile);

		}
	}
}
