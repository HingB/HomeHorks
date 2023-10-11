using System;
using System.Linq;

namespace Homework
{
    public static class Mission1
    {
        public static void Main()
        {
            List<Month> months = CreateMonths();

            Console.WriteLine("Введите номер месяца: ");
            int requireId = Convert.ToInt32(Console.ReadLine());

            if (IdIsAdequate(requireId))
                Console.WriteLine("Этот месяц: " + months.Where(p => p.Id == requireId).First().Name);
            else
                Console.WriteLine("Такого месяца нет");
        }

        private static bool IdIsAdequate(int id)
        {
            return id > 0 && id <= 12;
        }

        private static List<Month> CreateMonths()
        {
            List<Month> months = new List<Month>();

            months.Add(new Month(1, "Январь"));
            months.Add(new Month(2, "Февраль"));
            months.Add(new Month(3, "Март"));
            months.Add(new Month(4, "Апрель"));
            months.Add(new Month(5, "Май"));
            months.Add(new Month(6, "Июнь"));
            months.Add(new Month(7, "Июль"));
            months.Add(new Month(8, "Август"));
            months.Add(new Month(9, "Сентябрь"));
            months.Add(new Month(10, "Октябрь"));
            months.Add(new Month(11, "Ноябрь"));
            months.Add(new Month(12, "Декабрь"));

            return months;
        }
        
    }

    public struct Month
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Month(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}