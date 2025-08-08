using KSI_2016;

int n =int.Parse(Console.ReadLine());  
List<Student> students = new List<Student>();
if (n < 5 || n > 550)
{
    Console.WriteLine("Number must be between 5 and 550");
}
else
{
    for (int i = 0; i < n; i++)
    {


        string name = Console.ReadLine();
        string specialnost = Console.ReadLine();
        decimal ocenka = decimal.Parse(Console.ReadLine());
        string obuchenie = Console.ReadLine();
        Student student = new Student(name, specialnost, ocenka, obuchenie);
        students.Add(new Student(name, specialnost, ocenka, obuchenie));
    }
    var sorted = students.OrderBy(students => students.Name).ToList();
    foreach (Student students1 in sorted)
    {
        Console.WriteLine(students1.ToString());
    }
    decimal avera=students.Average(s=>s.Ocenka);
Console.WriteLine($"{avera:F2}");
}

   



