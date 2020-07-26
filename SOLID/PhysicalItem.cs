using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
   public class PhysicalItem: Item
    {
        public decimal weight { get; set; }
        public decimal hight { get; set; }
        public decimal width { get; set; }
        public decimal length { get; set; }

        /// using open-closed principle. we're extensioning the item.
        /// </summary>
        /// <returns></returns>
        public string getDimension()
        {
            return $"hight:{hight}xwidth:{width}xlength:{length}";
        }

        public void updateDimension(decimal hight = 0, decimal width = 0, decimal length = 0)
        {
            this.hight = hight;
            this.width = width;
            this.length = length;
        }

    }
}
