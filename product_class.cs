using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_performance_assessment
{
    internal class Product
    {
        public static BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        // Constructor
        public Product(int productId, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = productId;
            Name = name;
            Inventory = inStock;
            Price = price;
            Min = min;
            Max = max;
        }


        // Add associated part method
        public static void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(Part partID)
        {
            try
            {
                AssociatedParts.Remove(partID);
                return true;
            }
            catch
            {
                return false;
            }
        }


        // Look up associated part method
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part currPart in AssociatedParts)
            {
                if (partID > 0)
                {
                    if (partID == currPart.PartID)
                    {
                        return currPart;
                    }
                }
            }
            return null;
        }
    }
}
