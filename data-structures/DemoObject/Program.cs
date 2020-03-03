using System;

namespace DemoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //now that we have defined a class, we can create objects from that class
            //the class serves as a template to create the object

            int candyBarAmount = GetStock("candy bar");

            Product candyBar = new Product();
            candyBar.SetValues("1", candyBarAmount, 5.0);
            System.Console.WriteLine(candyBar);

            int cerealAmount = GetStock("cereal");

            Product cereal = new Product();
            cereal.SetValues("21", cerealAmount, 4.5);
            System.Console.WriteLine(cereal);
        }

        static int GetStock(string name)
        {
            int quantity;
            do
            {
                System.Console.WriteLine("Enter quantity of product " + name + ": ");
                quantity = int.Parse(System.Console.ReadLine());
            }while (quantity < 0); //if negative quantity, prompt again
            //if we got this far, the user must have finally entered a positive quantity
            return quantity;
        }
    }
}
