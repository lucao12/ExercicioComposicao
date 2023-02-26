using UdemyCurso2.Entities.Enums;
using UdemyCurso2.Entities;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Department's name: ");
        string DepName = Console.ReadLine();
        Console.WriteLine("Enter worker data: ");
        Console.Write("Name: ");
        string nome = Console.ReadLine();
        Console.Write("Level (Junior/MidLevel/Senior): ");
        Workerlevel level = Enum.Parse<Workerlevel>(Console.ReadLine());
        Console.Write("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Departament dept = new Departament(DepName);
        Worker worker = new Worker(nome, level, baseSalary, dept);

        Console.Write("How many contracts to this worker: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} contract data: ");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duration (Hours): ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(data, value, hours);
            worker.AddContract(contract);
        }

        Console.WriteLine();
        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string MonthAndYear = Console.ReadLine();

        int month = int.Parse(MonthAndYear.Substring(0, 2));
        int year = int.Parse(MonthAndYear.Substring(3));
        Console.WriteLine($"Name: {worker.Name}");
        Console.WriteLine($"Departament: {worker.Departament.Name}");
        Console.WriteLine($"Income for {MonthAndYear}: {worker.Income(year, month)}");
    }
}