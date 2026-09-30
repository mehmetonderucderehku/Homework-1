Console.WriteLine("Hello C#");
Console.WriteLine("------------------- \n");

Console.WriteLine("Mehmet Önder Üçdere");
Console.WriteLine("Computer Engineering");
Console.WriteLine("2nd Grade");
Console.WriteLine("------------------- \n");

Console.Write("Date and Time : ");
Console.WriteLine(DateTime.Now);
Console.WriteLine("------------------- \n");

Console.Write("Enter a °C to convert °F : ");
double d = double.Parse(Console.ReadLine());
double f = ((d * 9.0) / 5.0) + 32.0;
Console.WriteLine($"\n {d}°C is equal to {f}°F");