using EncapsulationGetSet.Models;
using System;
  
public class Program 
{
    static public void Main()
    {

        Encapsulated encapsul = new Encapsulated();

        encapsul.Name = "Tahmin";

        Console.WriteLine("My name is " + encapsul.Name);

    }
}