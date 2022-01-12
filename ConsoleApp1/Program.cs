using ConsoleApp1;
using System;
using System.Threading;

Menu menu = new();


Cat cat1 = new("Tom", "Male", 3, 100, 250, 2);
Cat cat2 = new("Felix", "Male", 1, 120, 150, 2);
Cat cat3 = new("Leia", "Female", 2, 130, 300, 3);




Cat[] catHouse = new Cat[3]
{
    cat1,  cat2, cat3

};

menu.Start(catHouse);