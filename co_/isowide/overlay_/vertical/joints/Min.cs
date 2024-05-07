using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.img.co_.isowide.overlay_.vertical.joints
{
	/// <summary>
	/// find the overlapping areas of two, say, snapshots of mobile phone chat screen, which is usually scrolled long, but the snapshot of mobile phone app cannot be infinitly long.
	/// </summary>
	internal class _MinX
	{
		static public int Pixels(Image upper, Image lower) {
			var r = 0;

			var max = Math.Min(upper.Height, lower.Height);

			for (int i = 0; i < max; i++)
			{
				// calculate the overlapped rect's index.

			}

		}
	}
}
