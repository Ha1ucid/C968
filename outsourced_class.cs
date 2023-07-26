using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace C968_performance_assessment
{
    internal class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }


        public OutsourcedPart(string companyName, int partId, string name, decimal price, int inStock, int min, int max)
            : base(partId, name, inStock, price, min, max)
        {
            CompanyName = companyName;
            PartID = partId;
            Name = name;
            Inventory = inStock;
            Price = price;
            Min = min;
            Max = max;
        }
    }
}
