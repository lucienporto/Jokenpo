Console.WriteLine("Insira o lado A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Insira o lado B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine($"A hipotenusa é {c}.");