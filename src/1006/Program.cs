using System;


class URI {
    static void Main(string[] args) {
        //1006
        #region Média 2 em C#
        

        double valorA = double.Parse(Console.ReadLine());
        double valorB = double.Parse(Console.ReadLine());
        double valorC = double.Parse(Console.ReadLine());

        double notaA = valorA * 2;
        double notaB = valorB * 3;
        double notaC = valorC * 5;

        double media = (notaA + notaB + notaC) / 10;

        Console.WriteLine($"MEDIA = {media:F1}");
        #endregion
    }
}