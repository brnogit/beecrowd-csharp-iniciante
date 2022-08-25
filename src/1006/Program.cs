using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        //1006
        #region Média 2 em C#
        CultureInfo culture = CultureInfo.InvariantCulture;

        double valorA = double.Parse(Console.ReadLine(), culture);
        double valorB = double.Parse(Console.ReadLine(), culture);
        double valorC = double.Parse(Console.ReadLine(), culture);

        double notaA = valorA * 2;
        double notaB = valorB * 3;
        double notaC = valorC * 5;

        double media = (notaA + notaB + notaC) / 10;

        Console.WriteLine($"MEDIA = {media:F1}", culture);
        #endregion
    }
}