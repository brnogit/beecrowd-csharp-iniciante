using System;

class URI {
    public static void Main(string[] args)
    {
        #region Diferença
        int valorA = int.Parse(Console.ReadLine());
        int valorB = int.Parse(Console.ReadLine());
        int valorC = int.Parse(Console.ReadLine());
        int valorD = int.Parse(Console.ReadLine());

        int valorDaDiferenca = ((valorA * valorB) - (valorC * valorD));

        Console.WriteLine($"DIFERENCA = {valorDaDiferenca}");
        #endregion
    }
}