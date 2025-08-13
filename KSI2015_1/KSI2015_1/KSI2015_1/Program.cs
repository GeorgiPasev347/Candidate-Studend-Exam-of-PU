



using KSI2015_1;
using System.Xml.Schema;

int n = int.Parse(Console.ReadLine());
List<Pet> pets = new List<Pet>();
for (int i = 0; i < n; i++)
{
    string name=Console.ReadLine();
    string vid=Console.ReadLine();
    int age=int.Parse(Console.ReadLine());
     
    string stopanin=Console.ReadLine();
    pets.Add(new Pet(name, vid, age, stopanin));

    
}
Console.WriteLine();
string owner2 = Console.ReadLine();
var sorted=pets.OrderBy(pet => pet.Age).ToList();
foreach (Pet pet in sorted)
{
    Console.WriteLine( pet.ToString() );
   
}
Console.WriteLine();
var filteredSearch=pets.Where(o=>o.Stopanin.Equals(owner2)).ToList();
foreach (Pet pet in filteredSearch)
{
    Console.WriteLine( pet);
}
