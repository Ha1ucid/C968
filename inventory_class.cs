using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_performance_assessment
{
    internal class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();


        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(Product product)
        {
            try
            {
                Products.Remove(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Product LookupProduct(int productID)
        {
            foreach (Product currProduct in Products)
            {
                if (productID > 0)
                {
                    if (productID == currProduct.ProductID)
                    {
                        return currProduct;
                    }
                }
            }
            return null;
        }

        public static void UpdateProduct(int productId, Product product)
        {
            foreach (Product currProduct in Products)
            {
                if (currProduct.ProductID == productId)
                {
                    currProduct.ProductID = productId;
                    currProduct.Name = product.Name;
                    currProduct.Inventory = product.Inventory;
                    currProduct.Price = product.Price;
                    currProduct.Max = product.Max;
                    currProduct.Min = product.Min;

                    return;
                }

            }
        }

        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part currPart in AllParts)
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


        public static void UpdatePart(int partId, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(C968_performance_assessment.InhousePart))
                {
                    InhousePart currPart = (InhousePart)AllParts[i];

                    if (currPart.PartID == partId)
                    {
                        currPart.PartID = partId;
                        currPart.Name = part.Name;
                        currPart.Price = part.Price;
                        currPart.Inventory = part.Inventory;
                        currPart.Min = part.Min;
                        currPart.Max = part.Max;
                    }
                }
                else if (AllParts[i].GetType() == typeof(C968_performance_assessment.OutsourcedPart))
                {
                    OutsourcedPart currPart = (OutsourcedPart)AllParts[i];

                    if (currPart.PartID == partId)
                    {
                        currPart.PartID = partId;
                        currPart.Name = part.Name;
                        currPart.Price = part.Price;
                        currPart.Inventory = part.Inventory;
                        currPart.Min = part.Min;
                        currPart.Max = part.Max;
                    }
                }
            }


        }
    }
}
