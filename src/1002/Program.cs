using System;


class URI {
   
   public static void Main(string[] args)
   {
    
    double n = 3.14159;
    double raio = double.Parse(Console.ReadLine());
    double area = (raio * raio) * n;

    Console.WriteLine($"A={area:F4}");
   }
}
