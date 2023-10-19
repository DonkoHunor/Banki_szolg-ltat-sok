using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public class Bank
	{
		private List<Szamla> szamlaLista;

		public Bank()
		{
			this.szamlaLista = new List<Szamla>();
		}

		public long OsszHitelkeret 
		{
			get 
			{
				long ossz = 0;
				foreach (var sz in szamlaLista)
				{
					if(sz.GetType() == typeof(HitelSzamla))
					{
						ossz += ((HitelSzamla)sz).HitelKeret;
					}
				}
				return ossz;
			}
		}

		public Szamla SzamlaNyitas(Tulajdonos tulajdonos, int hitelKeret)
		{
			if (hitelKeret < 0) 
			{
				throw new ArgumentException("A hitelkeret nem lehet nullánál kisebb!");
			}
			else
			{
				if(hitelKeret == 0)
				{
					MegtakaritasiSzamla p = new MegtakaritasiSzamla(tulajdonos);
					szamlaLista.Add(p);
					return p;
				}
				else
				{
					HitelSzamla p = new HitelSzamla( tulajdonos, hitelKeret);
					szamlaLista.Add(p);
					return p;
				}
			}
		}

		public long GetOsszEgyenleg(Tulajdonos tulajdonos)
		{
			long ossz = 0;
			foreach(var sz in szamlaLista)
			{
				if(sz.Tulajdonos == tulajdonos)
				{
					ossz += sz.AktualisEgyenleg;
				}
			}
			return ossz;
		}

		public Szamla GetLegnagyobbEgyenleguSzamla(Tulajdonos tulajdonos)
		{
			long max = int.MinValue;
			Szamla result = null;
			foreach (var sz in szamlaLista)
			{
				if (sz.Tulajdonos == tulajdonos)
				{
					if(sz.AktualisEgyenleg > max)
					{
						max = sz.AktualisEgyenleg;
						result = sz;
					}
				}
			}
			return result;
		}
	}
}
