using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_performance_assessment
{
    internal abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        // Constructor
        public Part(int partId, string name, int inStock, decimal price, int min, int max)
        {
            PartID = partId;
            Name = name;
            Inventory = inStock;
            Price = price;
            Min = min;
            Max = max;
        }
    }
}
