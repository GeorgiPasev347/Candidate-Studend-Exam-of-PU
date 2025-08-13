using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI2015_1
{
     class Pet
    {
		private string ime;

		public string Ime
		{
			get { return ime; }
			set 
            {
                if (value.Length > 30) { throw new ArgumentException("less than 30 letters"); }
                else { ime = value; }
            }
		}

        private string vid;

        public string Vid
        {
            get { return vid; }
            set {
                if (value.Length > 30) { throw new ArgumentException("less than 30 letters"); }
                else { vid = value; }
            }
        }
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

        private string stopanin;

        public string Stopanin
        {
            get { return stopanin; }
            set {
                if (value.Length > 40)
                {
                    throw new ArgumentException("less than 40 letters");
                }
                else { stopanin = value; }
            }
        }

        public Pet(string ime, string vid, int age, string stopanin)
        {
           
            Ime = ime;
            
            Vid = vid;
            
            Age = age;
            
            Stopanin = stopanin;
        }

        public override string ToString()
        {
            return $"{Ime},{vid},{age/12} years {age%12} months,{stopanin}";
        }
    }
}
