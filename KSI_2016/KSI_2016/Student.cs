using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI_2016
{
	class Student
	{
		private string name;

		public string Name
		{
			get { return name; }
			set {
				if (value.Length > 30) { throw new ArgumentException("Under 30 symbols"); }
				else { name = value; }
			}
		}
		private string specialnost;

		public string Specialnost
		{
			get { return specialnost; }
			set
			{
				if (value.Length > 20) { throw new ArgumentException("Under 20 symbols"); }
				else { specialnost = value; }
			}
		}

		private decimal ocenka;

		public decimal Ocenka
		{
			get { return ocenka; }
			set {
				if (value > 6) { throw new ArgumentException("Must be under 6"); }
				else { ocenka = value; } 
			}
		}


		private string obuchenie;

		public string Obuchenie
		{
			get { return obuchenie; }
			set {
				if (value.Length > 15){ throw new ArgumentException("Under 15 symbols"); }

				else { obuchenie = value; }
			}

		}

        public override string ToString()
        {
            return $"{Name},{Specialnost},{Ocenka},{Obuchenie},"+Bal();
        }

		public decimal Bal()
		{
			decimal obraz = ocenka * 6;
			return obraz;
		}

		public Student(string name,string specialnost,decimal ocenka,string obuchenie)
		{
			Name=name;
			Specialnost=specialnost;
			Ocenka=ocenka;
			Obuchenie=obuchenie;
		}

		
	}
}
