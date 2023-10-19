using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public class MegtakaritasiSzamla : Szamla
	{
		public static double alapKamat;
		private double kamat;

		public MegtakaritasiSzamla(Tulajdonos tulajdonos) : base(tulajdonos)
		{
			alapKamat = 1.1;
			kamat = 1.1;
		}

		public double Kamat { get => kamat; set => kamat = value; }

		public override bool Kivesz(int osszeg)
		{
			if(aktualisEgyenleg - osszeg >= 0)
			{
				aktualisEgyenleg -= osszeg;
				return true;
			}
			else
			{
				return false;
			}
		}

		public void KamatJovairas()
		{
			this.aktualisEgyenleg = Convert.ToInt32((this.aktualisEgyenleg * this.kamat));
		}
	}
}
