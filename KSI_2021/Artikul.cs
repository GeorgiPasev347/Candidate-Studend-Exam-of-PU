using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI_2021
{
    class Artikul
    {
        public int PoredenNomer { get; set; }
		private string imeArtikul;

		public string ImeArtikul
		{
			get { return imeArtikul; }
			set {
				if (value.Length > 2 && value.Length < 20) 
				{
                    imeArtikul = value;
                }
				else
				{
					throw new ArgumentException("Да е между 2 и 20 символа");
				} 
				
			}
		}

		private double cena;

		public double Cena
		{
			get { return cena; }
			set 
			{ if( value >= 0.10)
			    {
					cena = value;
				}
				else
				{
					throw new ArgumentException("Да е над 0.10 лв");
				}
			}
		}

		private int nalichnost;

		public int Nalichnost
		{
			get { return nalichnost; }
			set 
			{
				if (value > 0)
				{
					nalichnost = value;
				}
				else
				{
					throw new ArgumentException("Да е положително число");
				}
			}
		}

		private int tip;

		public int Tip
		{
			get { return tip; }
			set {
                if (value>=1 && value <=5)
                {
                    tip = value;
                }
				else
				{
					throw new ArgumentException("Да е между 1 и 5");
				}
                 
			}
		}
		

		public Artikul(int poredenNomer,string imeArtikul,double cena,int nalichnost,int tip)
		{
			PoredenNomer = poredenNomer;
			ImeArtikul = imeArtikul;
			Cena = cena;
			Nalichnost= nalichnost;
			Tip = tip;
		}

		public override string ToString() 
		{
			return $"{PoredenNomer},{ImeArtikul},{Cena},{nalichnost},{Tip}";
		}
		public string Kode()
		{
			return $"{PoredenNomer + imeArtikul.Substring(0,2) + Tip}";
		}
	}
}
