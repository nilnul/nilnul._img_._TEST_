using Colourful;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._img.color.co
{
	/// <summary>
	/// 
	/// </summary>
	internal class _DifX
	{
		static public readonly CIEDE2000ColorDifference Comparer = new CIEDE2000ColorDifference();



		static public double Dif(LabColor a, LabColor b) {
			return Comparer.ComputeDifference(a, b); 
		}
		static public double Dif(Color a, Color b) {
			return Dif(color.op_._FormatX.Lab( a), op_._FormatX.Lab( b) ); 
		}


	}
}
