using System;

namespace ColorSpheres
{
    public class Program
    {
        public static void Main()
        {
            Color redColor = new Color(255, 0, 0);
            Color blueColor = new Color(0, 0, 255);
            Color greenColor = new Color(0, 255, 0);

            Sphere sphere1 = new Sphere(redColor, 10);
            Sphere sphere2 = new Sphere(blueColor, 15);
            Sphere sphere3 = new Sphere(greenColor, 12);
            
            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();

            sphere2.Pop();

            sphere2.Throw();

            Console.WriteLine("Esfera 1:");
            Console.WriteLine($"Cor: ({sphere1.GetColor().Red}, {sphere1.GetColor().Green}, {sphere1.GetColor().Blue})");
            Console.WriteLine($"Raio: {sphere1.GetRadius()}");
            Console.WriteLine($"Número de vezes que foi atirada: {sphere1.GetTimesThrown()}");
            Console.WriteLine();

            Console.WriteLine("Esfera 2:");
            Console.WriteLine($"Cor: ({sphere2.GetColor().Red}, {sphere2.GetColor().Green}, {sphere2.GetColor().Blue})");
            Console.WriteLine($"Raio: {sphere2.GetRadius()}");
            Console.WriteLine($"Número de vezes que foi atirada: {sphere2.GetTimesThrown()}");
        }
    }
}

