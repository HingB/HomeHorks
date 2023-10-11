namespace Homework
{
    public static class Mission2
    {
        public static void Main()
        {
            double a, b, c;
            double square, perimeter;

            Console.WriteLine("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            square = (a * b) / 2;
            perimeter = a + b + c;

            Console.WriteLine("Площадь - " + square);
            Console.WriteLine("Периметр  - " + perimeter);
        }
    }
}