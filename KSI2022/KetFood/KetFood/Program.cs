using KetFood;

int n = int.Parse(Console.ReadLine());
List<Food> foods = new List<Food>();
for (int i = 0; i < n; i++)
{
int kod = int.Parse(Console.ReadLine());
    string ime=Console.ReadLine();  
    int kg=int.Parse(Console.ReadLine());
    int trainost=int.Parse(Console.ReadLine());
    string grupaStoki=Console.ReadLine();
    DateTime dataPostupvane = DateTime.Now;
    string pozicia = Console.ReadLine();

    Food food = new Food(kod,ime, kg, trainost,grupaStoki, dataPostupvane, pozicia);
    foods.Add(new Food(kod, ime, kg, trainost, grupaStoki, dataPostupvane, pozicia));
}
var sorted = foods.OrderBy(ss=>ss.Ime).ToList();

foreach(Food food in sorted)
{
    Console.WriteLine(food);
}