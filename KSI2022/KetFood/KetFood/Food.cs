using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetFood
{
     class Food
    {
		private int kod;

		public int Kod
		{
			get { return kod; }
			set 
			{
				if (value.ToString().Length > 5) { throw new ArgumentException("DO 5 ZNAKA"); }
				else { kod = value; } 
			}
		}

		private string ime;

		public string Ime
		{
			get { return ime; }
			set 
			{
				if (value.Length > 40) { throw new ArgumentException("UNDER 40 LETTERS"); }
				else { ime = value; }
			}
		}
		private int kg;

		public int Kg
		{
			get { return kg; }
			set { kg = value; }
		}
        private int trainost;

        public int Trainost
        {
            get { return trainost; }
            set { trainost = value; }
        }

		public string GrupaStoki { get;set; }
		public DateTime DataPostupvane { get;set; }

		private string pozicia;

		public string Pozicia
		{
			get { return pozicia; }
			set 
			{
				if (value.ToString().Length > 5) { throw new ArgumentException("DO 5 ZNAKA"); }
				pozicia = value;
			}
		}
		 public Food(int kod,string ime,int kg,int trainost,string grupaStoki,DateTime dataPostupvane,string pozicia)
		{
			Kod = kod;
			Ime = ime;
			Kg = kg;
			Trainost = trainost;
			GrupaStoki = grupaStoki;
			DataPostupvane= dataPostupvane;
			Pozicia = pozicia;
		}

        public override string ToString()
        {
			return $"{pozicia} ,{Kod.ToString()}, {Ime}, {Kg}, {DataPostupvane}, {trainost}"; ;
        }

	}
}
