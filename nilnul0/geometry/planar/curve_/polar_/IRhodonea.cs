using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polar_
{
	/// <summary>
	/// rose or rhodonea curve
	/// </summary>

	internal class IRhodonea
	{
	}

	 public class Rhodonea
		:nilnul.num.real.op_.Unary4dblI
	{
		private double _amplitude;

		public double amplitude
		{
			get { return _amplitude; }
			set { _amplitude = value; }
		}

		private double _frequence;

		public double frequence
		{
			get { return _frequence; }
			set { _frequence = value; }
		}

		public Rhodonea( double freq=1, double ample=1)
		{
			this._frequence = freq;
			this._amplitude = ample;
		}

		static public Rhodonea OfFreq(double freq) {
			return new Rhodonea( freq,1);
		}

		public double op(double par)
		{
			return _amplitude * Math.Sin(
				_frequence * par	//given a time, it happens multiple times;
			);
		}
	}


}
