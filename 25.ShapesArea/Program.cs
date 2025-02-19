internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this area calculator!");
        double radius, a, b, c;
        while (true)
        {
            Console.WriteLine("\n1.Circle\n2.Square\n3.Triangle\n4.Rectangle\nSelect an option: ");
            string option = Console.ReadLine() ?? "";
            bool cont = false;

            switch (option)
            {
                case "1":
                    Console.Write("Enter a radius of a circle: ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of a circle is {CircleArea(radius)}");
                    break;
                case "2":
                    Console.Write("Enter side of a square: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of a square is {SquareArea(a)}");
                    break;
                case "3":
                    Console.Write("Enter side a of triangle: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side b of triangle: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side c of triangle: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of a triangle is {TriangleArea(a, b, c)}");
                    break;
                case "4":
                    Console.Write("Enter side a of rectangle: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side b of rectangle: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of rectangle is {RectangleArea(a, b)}");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again!");
                    cont = true;
                    break;
            }
            if (cont) 
                continue;
            
            Console.Write("Calculate again?(y/n): ");
            string again = Console.ReadLine() ?? "";
            if (again.ToLower().Equals("n"))
                goto end;
        }
        
        end:
        Console.WriteLine("Thanks for calculating!");
    }

    public static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double SquareArea(double a)
    {
        return a * a;
    }

    public static double TriangleArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public static double RectangleArea(double a, double b)
    {
        return a * b;
    }
}