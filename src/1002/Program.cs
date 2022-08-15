using System;

class URI {
   
   public static void Main(string[] args)
   {
    
    double n = 3.14159;
    float raio = float.Parse(Console.ReadLine());
    float area = float.Parse((n * raio) * 2.2f);

    Console.WriteLine($"A={area}");
   }
}
