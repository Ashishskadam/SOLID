using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class virtualItem : Item
    {
        public DateTime expiryDate { get; set; }

        public virtual void updateExpiryDate(DateTime date)
        {
            expiryDate = date;
        }

        public override string printDetails()
        {
            return $"The Item {name} costs {price}. From Child.";
        }
    }
}
