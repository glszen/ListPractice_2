using System;
using System.Collections.Generic;

List <string> Coffee = new List <string> (); //Create a new list of string type

Console.Write("Coffee 1: "); //Add values into the list with values ​​get from the user
Coffee.Add(Console.ReadLine());

Console.Write("Coffee 2: ");
Coffee.Add(Console.ReadLine());

Console.Write("Coffee 3: ");
Coffee.Add(Console.ReadLine());

Console.Write("Coffee 4: ");
Coffee.Add(Console.ReadLine());

Console.Write("Coffee 5: ");
Coffee.Add(Console.ReadLine());

Console.WriteLine("----------------");
Console.WriteLine("Entered Coffe Names:");

foreach (string coffe in Coffee)  //Values ​​in the list are listed with foreach
{
    Console.WriteLine(coffe);
}

Console.ReadKey();