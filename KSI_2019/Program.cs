// See https://aka.ms/new-console-template for more information
using KSI2019;

int n = int.Parse(Console.ReadLine());
List<Zvezda> zvezdi = new List<Zvezda>(); 
for (int i = 0; i < n; i++)
{
    string imenomer=Console.ReadLine(); 
    decimal razstoyanie = decimal.Parse(Console.ReadLine());    
    char klasific = char.Parse(Console.ReadLine()); 
    decimal masa = decimal.Parse(Console.ReadLine());
    string suzvezdie = Console.ReadLine();

    zvezdi.Add(new Zvezda(
        imenomer, razstoyanie, klasific, masa, suzvezdie
        ));
}

var sorted = zvezdi.OrderBy(zvezdi=>zvezdi.Razstoyanie).ToList();

foreach (Zvezda zvezda in sorted)
{
    Console.WriteLine( zvezda);
}