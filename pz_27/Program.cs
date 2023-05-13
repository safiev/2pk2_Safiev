using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_27
{
    class ZNAK
    {
        public string NAME;
        public string ZODIAC;
        public int[] BDAY = new int[3];
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            ZNAK[] BOOK = new ZNAK[2];
            int[] Bd = new int[3];

            for (int i = 0; i < BOOK.Length; i++)
            {
                int x = rnd.Next(1, 30);
                int y = rnd.Next(1, 12);
                int z = rnd.Next(1988, 2023);

                Console.WriteLine("Введите данные {0}:", i + 1);

                Console.Write("Напишите Имя и Фамилию: ");
                string name = Console.ReadLine();

                Console.Write("Напишите свой задиак: ");
                string zodiac = Console.ReadLine();

                Bd[0] = x;
                Bd[1] = y;
                Bd[2] = z;

                Console.WriteLine($"Дата Рождения: {Bd[0]}.{Bd[1]}.{Bd[2]}");
                BOOK[i] = new ZNAK { NAME = name, ZODIAC = zodiac, BDAY = Bd };
            }
            Console.WriteLine("Введите имя или фамилию: ");
            string found = Console.ReadLine();

            foreach (ZNAK znak in BOOK)
            {
                if (znak.NAME == found)
                {
                    Console.WriteLine($"Вас зовут: {znak.NAME} Ваш знак Зодиака: {znak.ZODIAC} Вы родились: {znak.BDAY[0]}.{znak.BDAY[1]}.{znak.BDAY[2]}");
                }
                if (znak.NAME != found)
                {
                    Console.WriteLine($"Ваше Имя/Фамилия:{found} не были найдены в базе даных");
                }

                //jeison
            }
        }
    }
}
