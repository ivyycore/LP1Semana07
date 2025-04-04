namespace BetterColorSpheres
{
    public class Program
    {
        public class Color
        {
            //Propriedades
            public byte Red { get; }
            public byte Green { get; }
            public byte Blue { get; }


            //Construtor
            public Color(byte red, byte green, byte blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }

            //readonly 
             public byte Grey => (byte)((Red + Green + Blue) / 3);
        }
        public class Sphere
        {
            public Color Color { get; } 
            public int Radius { get; private set; } 
            private int ThrowTimes;

            //Propriedades 
             public Sphere(Color color, int radius)
            {
                Color = color;
                Radius = radius;
                ThrowTimes = 0;
            }

            public void Pop()
            {
                Radius = 0;
            }

            public void Throw()
            {
                if (Radius > 0)
                {
                    ThrowTimes++;
                }
            }

            public int GetTimesThrown() => ThrowTimes;
        }
        public static void Main()
        {
            const byte MaxRed = 255, MaxGreen = 255, MaxBlue = 255;
            const byte NoColor = 0;
            
            //red (255,0,0) green (0,255,0) blue (0,0,255)
            Color redColor = new Color(MaxRed, NoColor, NoColor);
            Color greenColor = new Color(NoColor, MaxGreen, NoColor);
            Color blueColor = new Color(NoColor, NoColor, MaxBlue);
            
            //esferas (cor, raio)
            Sphere sphere1 = new Sphere(redColor, 10);
            Sphere sphere3 = new Sphere(greenColor, 12);
            Sphere sphere2 = new Sphere(blueColor, 15);
            //throw da primeira 3 vezes
            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();
            //pop da segunda
            sphere2.Pop();
            //throw da terceira 1 vez
            sphere3.Throw();

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

