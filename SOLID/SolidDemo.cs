using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class SolidDemo
    {
        static void Main(string[] args)
        {
            List<IDatabase> Customers = new List<IDatabase>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new goldCustomer());
            //Customers.Add(new Enquiry());

            foreach (Customer o in Customers)
            {
                o.Add();

            }

        }
    }

    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }


    interface IDatabase
    {
        void Add();
    }

    class Customer :IDiscount, IDatabase
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }

        public virtual void Add()
        {
            Console.WriteLine("Patent");
        }
    }
    class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }
    }
    class goldCustomer : SilverCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }

        public void xPrint()
        {
            Console.WriteLine("");
        }
    }

    class Enquiry : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
}
