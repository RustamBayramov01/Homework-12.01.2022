using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        
        Cat cat = new();
        CatHouse CatHouse = new();

        public void Start(Cat[] catHouse)
        {

            ConsoleKey key;
            while (true)
            {
                Console.Clear();

                Console.WriteLine("[ 1 ] Eat\n[ 2 ] Sleep\n[ 3 ] Play\n[ 4 ] Sell\n[ 5 ] Remove By NickName\n[ 6 ] Add Cat");

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1) cat.Eat(catHouse);
                else if (key == ConsoleKey.D2) cat.Sleep(catHouse,false);
                else if (key == ConsoleKey.D3) cat.Play(catHouse);
                else if (key == ConsoleKey.D4) cat.Sell(ref catHouse);
                else if (key == ConsoleKey.D5) CatHouse.RemoveByNickName(ref catHouse);
                else if (key == ConsoleKey.D6) CatHouse.AddCat(ref catHouse);

                else
                {
                    Console.WriteLine("\nYou made the wrong choice !");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }

        

    }
}
