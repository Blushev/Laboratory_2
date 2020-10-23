using System;

namespace Laboratory_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую координату: ");
            string start_coord = Console.ReadLine();
            Console.Write("Введите вторую координату: ");
            string last_coord = Console.ReadLine();
            if (start_coord.Length > 2 || start_coord.Length < 1)
            {
                Console.WriteLine("Ваши координаты введены неправильно!");
            }

            if ((start_coord[0] <= 'H' && start_coord[0] >= 'A') &&
                (start_coord[1] <= '8' && start_coord[1] >= '1') &&
                (last_coord[0] <= 'H' && last_coord[0] >= 'A') &&
                (last_coord[1] <= '8' && last_coord[1] >= '1'))
            {
                if ((start_coord[0] - last_coord[0] == 1 || start_coord[0] - last_coord[0] == -1
                    && start_coord[1] - last_coord[1] == 2 || start_coord[1] - last_coord[1] == -2) ||
                    (start_coord[0] - last_coord[0] == 2 || start_coord[0] - last_coord[0] == -2
                    && start_coord[1] - last_coord[1] == 1 || start_coord[1] - last_coord[1] == -1)
                    )
                {
                    Console.WriteLine("Верно!");
                }
                else
                {
                    Console.WriteLine("Неверно!");
                }
                Console.ReadKey();
            }
        }
    }
}