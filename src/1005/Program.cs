using System;
using System.Globalization;

class URI {
    public static void Main(string[] args)
    {
        CultureInfo culture = CultureInfo.InvariantCulture;
        
        double valorA = double.Parse(Console.ReadLine(), culture);
        double valorB = double.Parse(Console.ReadLine(), culture);

        double media = ((valorA * 3.5) + (valorB * 7.5))/11;

        Console.WriteLine($"MEDIA = {media:F5}", culture);
    }
}