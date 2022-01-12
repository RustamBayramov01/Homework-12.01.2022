using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Cat
    {
        int count = 0;
        int[] PreviousValueArr = new int[] { };
        public string NickName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Energy { get; set; }
        public int Price { get; set; }
        public int MealQuantity { get; set; }

        
        public Cat(string nickname, string gender, int age, int energy, int price, int mealQuantity)
        {
            NickName = nickname;
            Gender = gender;
            Age = age;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }


        public Cat() {}


        ///////////////////////////////////////////////////////////////////////////////////////


        public void Eat(Cat[] catHouse)
        {
            Console.Clear();

            int size = 0;
            int selection = 0;

            List<int> ls = PreviousValueArr.ToList();

            Console.WriteLine("[ Eat ]\n");
            foreach (var loop in catHouse)
            {
                size++;
                loop.ListNameShowTwo(size);

                if (count == 0)
                {
                    for (int i = 0; i < catHouse.Length; i++) ls.Add(catHouse[i].Energy);
                    PreviousValueArr = ls.ToArray();
                    count++;
                }
                else continue;
            }

            Console.Write("\nSelection : ");
            selection = int.Parse(Console.ReadLine());
            selection -= 1;

            if (selection < size)
            {
                int foodSelecton;
                int foodSelectonLimit = 3;

                if (catHouse[selection].Energy < PreviousValueArr[selection])
                {
                    Console.Clear();
                    Console.WriteLine("[ 1 ] Chicken Flavor\t[ Energy +10 ]\n[ 2 ] Steak Flavor\t[ Energy +50 ]");
                    Console.Write("\nSelection : ");
                    foodSelecton = int.Parse(Console.ReadLine());

                    if(foodSelecton < foodSelectonLimit)
                    {
                        if(foodSelecton == 1)
                        {
                            if(catHouse[selection].Energy + 10 > PreviousValueArr[selection])
                            {
                                Console.WriteLine("\n\nEnergy limit exceeded !");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            else
                            {
                                int count = catHouse[selection].Energy;
                                int result = count + 10;
                                while (count != result)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\tNick Name : {catHouse[selection].NickName}\t\t Default Energy : {PreviousValueArr[selection]}\t\t Energy Increase : {catHouse[selection].Energy += 1}\t\t Price Increase : {catHouse[selection].Price += 1}");
                                    Thread.Sleep(100);
                                    count++;
                                }
                            }  
                        }
                        else if(foodSelecton == 2)
                        {
                            if (catHouse[selection].Energy + 50 > PreviousValueArr[selection])
                            {
                                Console.WriteLine("\n\nEnergy limit exceeded !");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            else
                            {
                                int count = catHouse[selection].Energy;
                                int result = count + 50;
                                while (count != result)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\tNick Name : {catHouse[selection].NickName}\t\t Default Energy : {PreviousValueArr[selection]}\t\t Energy Increase : {catHouse[selection].Energy += 1}\t\t Price Increase : {catHouse[selection].Price += 1}");
                                    Thread.Sleep(100);
                                    count++;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nYou made the wrong choice !");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                }
                else
                {
                    Console.WriteLine("\nYou need to play games to eat Full Energy !");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

            }
            else
            {
                Console.WriteLine("\nYou made the wrong choice !");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////


        public void Sleep(Cat[] catHouse, bool catEnergyZero)
        {
            Console.Clear();

            int size = 0;
            int selection = 0;

            List<int> ls = PreviousValueArr.ToList();

            Console.WriteLine("[ Sleep ]\n");
            foreach (var loop in catHouse)
            {
                size++;
                loop.ListNameShow(size);

                if(count == 0)
                {
                    for (int i = 0; i < catHouse.Length; i++) ls.Add(catHouse[i].Energy);
                    PreviousValueArr = ls.ToArray();
                    count++;
                }
                else continue;
            }


            if(catEnergyZero == true)
            {
                int Index = 0;

                for (int i = 0; i < catHouse.Length; i++)
                {
                    if(catHouse[i].Energy == 0)
                    {
                        break;
                    }
                    else
                    {
                        Index++;
                        continue;
                    }
                }

                int count = catHouse[Index].Energy;
                while (count != PreviousValueArr[selection])
                {
                    Console.Clear();
                    Console.WriteLine($"\n\tNick Name : {catHouse[Index].NickName}\t\t Default Energy : {PreviousValueArr[Index]}\t\t Energy Increase : {catHouse[Index].Energy += 1}");
                    Thread.Sleep(50);
                    count++;
                }

            }
            else
            {
                Console.Write("\nSelection : ");
                selection = int.Parse(Console.ReadLine());
                selection -= 1;

                if (selection < size)
                {
                    if (catHouse[selection].Energy < PreviousValueArr[selection])
                    {
                        int count = catHouse[selection].Energy;
                        while (count != PreviousValueArr[selection])
                        {
                            Console.Clear();
                            Console.WriteLine($"\n\tNick Name : {catHouse[selection].NickName}\t\t Default Energy : {PreviousValueArr[selection]}\t\t Energy Increase : {catHouse[selection].Energy += 1}");
                            Thread.Sleep(50);
                            count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nFull Energy!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                }
                else
                {
                    Console.WriteLine("\nYou made the wrong choice !");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            
        }


        ///////////////////////////////////////////////////////////////////////////////////////


        public void Play(Cat[] catHouse)
        {
            Console.Clear();

            int size = 0;
            int selection = 0;
            int catGameSelection = 0;
            int catGameSelectionLimit = 4;

            List<int> ls = PreviousValueArr.ToList();

            Console.WriteLine("[ Play ]\n");
            foreach (var loop in catHouse)
            {
                size++;
                loop.ListNameShow(size);

                if (count == 0)
                {
                    for (int i = 0; i < catHouse.Length; i++) ls.Add(catHouse[i].Energy);
                    PreviousValueArr = ls.ToArray();
                    count++;
                }
                else continue;
            }


            Console.Write("\nSelection : ");
            selection = int.Parse(Console.ReadLine());
            selection -= 1;

            if (selection < size)
            {
                if (catHouse[selection].Energy != 0)
                {
                    int count = catHouse[selection].Energy;

                    Console.Clear();
                    Console.WriteLine("[ 1 ] Play ball\t\t\t\t[ Energy : -10  ]\n[ 2 ] To Walk\t\t\t\t[ Energy : -50  ]\n[ 3 ] To walk and Play ball\t\t[ Energy : -100 ]");
                    Console.Write("\nSelection : ");
                    catGameSelection = int.Parse(Console.ReadLine());

                    if(catGameSelection < catGameSelectionLimit)
                    {

                        if (catGameSelection == 1) count = 10;
                        else if (catGameSelection == 2) count = 50;
                        else if (catGameSelection == 2) count = 100;

                        while (count != 0)
                        {
                            Console.Clear();
                            Console.WriteLine($"\n\tNick Name : {catHouse[selection].NickName}\t\t Energy Reduction : {catHouse[selection].Energy -= 1}");
                            Thread.Sleep(50);
                            count--;

                            if (catHouse[selection].Energy == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tHe ran out of energy and went to sleep !");
                                Thread.Sleep(2000);
                                Sleep(catHouse,true);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nYou made the wrong choice !");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                }
                else
                {
                    Console.WriteLine("\nFull Energy!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

            }
            else
            {
                Console.WriteLine("\nYou made the wrong choice !");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }



        ///////////////////////////////////////////////////////////////////////////////////////

        public void Sell(ref Cat[] catHouse)
        {
            Console.Clear();

            int size = 0;
            int selection;

            foreach (var loop in catHouse)
            {
                size++;
                loop.CatShow();
            }

            Console.WriteLine("--------------------------\n");
            Console.Write("Selection : ");
            selection = int.Parse(Console.ReadLine());

            if(selection <= size)
            {
                Cat[] catHouseCopy = new Cat[catHouse.Length - 1];

                for (int i = 0, j = 0; i < catHouse.Length; i++)
                {
                    if ((selection - 1) == i)
                    {
                        continue;
                    }
                    else
                    {
                        catHouseCopy[j] = catHouse[i];
                        j++;
                    }
                }


                catHouse = catHouseCopy;

            }
            else
            {
                Console.WriteLine("\nYou made the wrong choice !");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////


        public void CatShow()
        {
            Console.WriteLine("--------------------------\n");
            Console.WriteLine($"Nick Name : {NickName}\nGender : {Gender}\nAge : {Age}\nEnergy : {Energy}\nPrice : {Price}\nMeal Quantity : {MealQuantity}\n");

        }

        public void ListNameShow(int size)
        {
            Console.WriteLine($"[ {size} ] Nick Name : {NickName}\t\tEnergy : {Energy}");
        }

        public void ListNameShowTwo(int size)
        {
            Console.WriteLine($"[ {size} ] Nick Name : {NickName}\t\tMeal Quantity : {MealQuantity}\t\tEnergy : {Energy}");
        }

        public void NickShow()
        {
            Console.WriteLine($"Nick Name : {NickName}\n");
        }

    }
}
