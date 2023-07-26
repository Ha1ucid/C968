using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Windows.Forms;

namespace C968_performance_assessment
{
    internal class InhousePart : Part
    {
        public int MachineID { get; set; }


        public InhousePart(int machineID, int partId, string name, int inStock, decimal price, int min, int max)
            : base(partId, name, inStock, price, min, max)
        {
            MachineID = machineID;
            PartID = partId;
            Name = name;
            Price = price;
            Inventory = inStock;
            Min = min;
            Max = max;
        }
    }
}
