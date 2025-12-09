using System;

class Program
{
    static void Main(string[] args)
    {
        var geometry = new Geometry();
        bool running = true;

        while (running)
        {
            Console.WriteLine("╔═══════════════════════╗");
            Console.WriteLine("║      Geometry Guru     ║");
            Console.WriteLine("╠═══════════════════════╣");
            Console.WriteLine("║ 1. 🔘  Doira          ║");
            Console.WriteLine("║ 2. 🔺  Uchburchak     ║");
            Console.WriteLine("║ 3. ▭  To‘rtburchak     ║");
            Console.WriteLine("║ 4. ⬛  Parallelogram    ║");
            Console.WriteLine("║ 0. ❌  Chiqish        ║");
            Console.WriteLine("╚═══════════════════════╝");
            Console.Write("Tanlovingiz: ");
            
            int value = int.Parse(Console.ReadLine());

            switch (value)
            {
                case 1:
                    Console.Write("Doira radiusini kiriting: ");
                    int radius = int.Parse(Console.ReadLine());
                    geometry.Circle(radius);
                    break;

                case 2:
                    Console.WriteLine("Uchburchakda nechta tomon kiritasiz? (2 yoki 3)");
                    int sideCount = int.Parse(Console.ReadLine());

                    if (sideCount == 2)
                    {
                        Console.Write("Birinchi tomon: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Ikkinchi tomon: ");
                        int b = int.Parse(Console.ReadLine());
                        geometry.Triangle(a, b);
                    }
                    else if (sideCount == 3)
                    {
                        Console.Write("Birinchi tomon: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Ikkinchi tomon: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("Uchinchi tomon: ");
                        int c = int.Parse(Console.ReadLine());
                        geometry.Triangle(a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("Faqat 2 yoki 3 tomon kiritish mumkin!");
                    }
                    break;

                case 3:
                    Console.Write("To‘rtburchakning uzunligini kiriting: ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("To‘rtburchakning kengligini kiriting: ");
                    int width = int.Parse(Console.ReadLine());
                    geometry.Rectangle(length, width);
                    break;

                case 4:
                    Console.Write("Parallelogram asosini kiriting: ");
                    int baseP = int.Parse(Console.ReadLine());
                    Console.Write("Parallelogram balandligini kiriting: ");
                    int heightP = int.Parse(Console.ReadLine());
                    geometry.Parallelogram(baseP, heightP);
                    break;

                case 0:
                    running = false;
                    Console.WriteLine("Dastur yakunlandi.");
                    break;

                default:
                    Console.WriteLine("Noto‘g‘ri tanlov, qayta urinib ko‘ring.");
                    break;
            }
            
            Console.WriteLine("Dastur qayta ishga tushsinmi?(y/n)");
            if (Console.ReadLine().Trim().ToLower() == "y" || Console.ReadLine().Trim().ToLower() == "yes")
                running = true;
            else 
                running = false;
        }
    }
}

class Geometry
{
    public void Circle(int radius)
    {
        double area = radius * radius * System.Math.PI;
        Console.WriteLine($"Doira yuzasi: {radius} * {radius} * π = {area:F2}");
    }

    // 2 tomon berilganda → 3-tomon oralig'i
    public void Triangle(int a, int b)
    {
        double cMin = Math.Abs(a - b) + 1;
        double cMax = a + b - 1;
        Console.WriteLine($"Uchburchakda 3-tomon {cMin} va {cMax} oralig‘ida bo‘lishi mumkin.");
    }

    // 3 tomon berilganda → yuzani hisoblash
    public void Triangle(int a, int b, int c)
    {
        if (!(a + b > c && a + c > b && b + c > a))
        {
            Console.WriteLine("Uchburchak bo‘la olmaydi!");
            return;
        }

        double p = (a + b + c) / 2.0;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"Uchburchak yuzasi: {area:F2}");
    }

    public void Rectangle(int a, int b)
    {
        Console.WriteLine($"To‘rtburchak yuzasi: {a} * {b} = {a * b}");
    }

    public void Parallelogram(int a, int h)
    {
        Console.WriteLine($"Parallelogram yuzasi: {a} * {h} = {a * h}");
    }
}
