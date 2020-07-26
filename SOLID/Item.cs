using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Item  
    {
        public Guid id { get; set; }
        public decimal price { get; set; }
        public string name { get; set; }

        public virtual string printDetails()
        {
            return $"The Item {name} costs {price}. From Base.";
        }
    }
}
