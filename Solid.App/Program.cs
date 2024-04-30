// See https://aka.ms/new-console-template for more information
using Solid.App.OCPBad;

Console.WriteLine("Hello, World!");

SalaryCalculator salaryCalculator = new SalaryCalculator();

Console.WriteLine($"Low salary :{ salaryCalculator.Calculate(1000, SalaryType.Low)}");
Console.WriteLine($"Middle salary :{salaryCalculator.Calculate(1000, SalaryType.Middle)}");
Console.WriteLine($"High salary :{salaryCalculator.Calculate(1000, SalaryType.High)}");
