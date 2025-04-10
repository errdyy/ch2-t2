using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        double firstMultiplier = 1000;
        double secondMultiplier = 0.2; 

        Console.WriteLine("Начинаем расчет");

        double result = await MultiplyService.CalculateMultiply(firstMultiplier, secondMultiplier);

        Console.WriteLine($"Результат произведения {firstMultiplier} на {secondMultiplier} составляет {result}");
    }
}

public static class MultiplyService
{
    public static  Task<double> CalculateMultiply(double firstMultiplier, double secondMultiplier)
    {
        Console.WriteLine("Выполняем синхронный");

        double tax = firstMultiplier * secondMultiplier; 

        return Task.FromResult(tax); 
    }
}
