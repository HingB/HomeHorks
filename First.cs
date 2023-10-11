using System;

namespace Homework
{
    public static class Mission1
    {
        public static void Main()
        {
            float x, y;

            Console.WriteLine("Введите 1 число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма - " + (x + y));
            Console.WriteLine("Разность - " + (x - y));
            Console.WriteLine("Произведение - " + (x * y));
            Console.WriteLine("Частное - " + (x / y));
        }
    }
}
