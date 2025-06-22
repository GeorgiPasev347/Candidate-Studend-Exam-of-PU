using KSI_2021;


for (int i = 0; i < 2000; i++)
{
    


    int poredenNomer = int.Parse(Console.ReadLine());
	string imeArtikul = Console.ReadLine();
	double cena = double.Parse(Console.ReadLine());
	int nalichnost = int.Parse(Console.ReadLine());
	int tip = int.Parse(Console.ReadLine());
	

    Artikul artikul = new Artikul(poredenNomer, imeArtikul, cena, nalichnost, tip);
	Console.WriteLine(artikul.ToString() +"," + artikul.Kode());
}

