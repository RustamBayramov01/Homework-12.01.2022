using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ConsoleApp1
{
    class CatHouse : Cat
    {
        public int CatCount { get; set; }

        public CatHouse(int catCount, string nickname, string gender, int age, int energy, int price, int mealQuantity) : base(nickname, gender, age, energy, price, mealQuantity)
        {
            CatCount = catCount;
        }

        public CatHouse() {}


        public void RemoveByNickName(ref Cat[] catHouse)
        {
            Console.Clear();

            bool n = false;
            string Nick;
            Cat[] NewArray = new Cat[catHouse.Length - 1];

            foreach (var item in catHouse)
            {
                item.NickShow();
            }

            Console.WriteLine("------------------------\n");
            Console.Write("Nick : ");
            Nick = Console.ReadLine();

            for (int i = 0; i < catHouse.Length; i++)
            {
                if(catHouse[i].NickName == Nick)
                {
                    n = true;
                    break;
                }
            }

            if(n == true)
            {
                for (int i = 0; i < catHouse.Length; i++)
                {
                    if (catHouse[i].NickName == Nick)
                    {
                        for (int k = 0, j = 0; k < catHouse.Length; k++)
                        {
                            if (catHouse[k].NickName == Nick)
                            {
                                continue;
                            }
                            else
                            {
                                NewArray[j] = catHouse[k];
                                j++;
                            }
                        }

                        catHouse = NewArray;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nThis nick name could not be found !");
                Thread.Sleep(1000);
            }
            
           

        }


        public void AddCat(ref Cat[] catHouse)
        {
            Console.Clear();

            Cat[] newArray = new Cat[catHouse.Length + 1];

            string nickName = "", gender = "";
            int age = 0, energy = 0, price = 0, mealQuantity = 0;

            Console.Write("Nick Name : ");
            nickName = Console.ReadLine();
            Console.Write("Gender : ");
            gender = Console.ReadLine();
            Console.Write("Age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Energy : ");
            energy = int.Parse(Console.ReadLine());
            Console.Write("Price : ");
            price = int.Parse(Console.ReadLine());
            Console.Write("Meal Quantity : ");
            mealQuantity = int.Parse(Console.ReadLine());

            Cat NewCatAdd = new(nickName, gender, age, energy, price, mealQuantity);

            for (int i = 0; i < catHouse.Length; i++) newArray[i] = catHouse[i];
            newArray[newArray.Length - 1] = NewCatAdd;

            catHouse = newArray;

        }

        public new void Show()
        {
            base.CatShow();
            base.NickShow();
        }

        
    }
}
