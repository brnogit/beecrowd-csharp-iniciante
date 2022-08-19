using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        #region Média 2 em C#
        double valorA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valorB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valorC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double notaA = valorA * 2;
        double notaB = valorB * 3;
        double notaC = valorC * 5;

        double media = (notaA + notaB + notaC) / 10;

        Console.WriteLine($"MEDIA = {media:F1}", CultureInfo.InvariantCulture);
        #endregion
    }
}