using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {

            ////using OCP
            //PhysicalItem PhysicalItem = new PhysicalItem();
            //PhysicalItem.updateDimension(2, 3, 4);
            //var dimension = PhysicalItem.getDimension();

            ////using LSP
            //Item virtualItem = new virtualItem();
            //Console.WriteLine(virtualItem.printDetails());
            Item item = new virtualItem();
            Console.WriteLine(  item.printDetails()); 

            Console.ReadLine();

        }


    }
}
