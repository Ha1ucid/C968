using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C968_performance_assessment
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void InHouseRadioButton_Click(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void OutsourcedRadioButton_Click(object sender, EventArgs e)
        {
            label9.Text = "Company Name";
        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = !label9.Visible;
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = !label8.Visible;
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SavePartButton_Click(object sender, EventArgs e)
        {
            if (inHouseRadioAddPart.Checked == true)
            {
                Int32.TryParse(machineCompanyInputAddPart.Text, out int machineId);
                Int32.TryParse(idInputAddPart.Text, out int partId);
                string name = nameInputAddPart.Text;
                Decimal.TryParse(priceInputAddPart.Text, out decimal price);
                Int32.TryParse(inventoryInputAddPart.Text, out int inventory);
                Int32.TryParse(maxInputAddPart.Text, out int max);
                Int32.TryParse(minInputAddPart.Text, out int min);

                if ((max >= min) && (inventory >= min) && (inventory <= max))
                {
                    if (Inventory.LookupPart(partId) == null)
                    {
                        InhousePart inhousePart = new InhousePart(machineId, partId, name, inventory, price, max, min);
                        Inventory.AllParts.Add(inhousePart);
                    }
                    else
                    {
                        PartAlreadyExists partAlreadyExists = new PartAlreadyExists();
                        partAlreadyExists.ShowDialog();
                    }
                    this.Close();
                }
                else if (min > max)
                {
                    maxInputAddPart.BackColor = Color.Red;
                    minInputAddPart.BackColor = Color.Red;
                    
                    label10.Visible= true;
                }
                else if ((inventory < min) || (inventory > max))
                {
                    inventoryInputAddPart.BackColor = Color.Red;
                    
                    label11.Visible = true;
                } 
            }
            else
            {
                string companyName = machineCompanyInputAddPart.Text;
                Int32.TryParse(idInputAddPart.Text, out int partId);
                string name = nameInputAddPart.Text;
                Decimal.TryParse(priceInputAddPart.Text, out decimal price);
                Int32.TryParse(inventoryInputAddPart.Text, out int inventory);
                Int32.TryParse(maxInputAddPart.Text, out int max);
                Int32.TryParse(minInputAddPart.Text, out int min);

                if ((max >= min) && (inventory >= min) && (inventory <= max))
                {
                    if (Inventory.LookupPart(partId) == null)
                    {
                        OutsourcedPart outsourcedPart = new OutsourcedPart(companyName, partId, name, price, inventory, min, max);
                        Inventory.AllParts.Add(outsourcedPart);
                    }
                    else
                    {
                        PartAlreadyExists partAlreadyExists = new PartAlreadyExists();
                        partAlreadyExists.ShowDialog();
                    }
                    this.Close();
                }
                else if (min > max)
                {
                    maxInputAddPart.BackColor = Color.Red;
                    minInputAddPart.BackColor = Color.Red;
                    label10.Visible = true;
                    label10.Text = "Min value cannot be\n greater than max\n value.";
                }
                else if ((inventory < min) || (inventory > max))
                {
                    inventoryInputAddPart.BackColor = Color.Red;
                    label11.Visible = true;
                    label11.Text = "Inventory value cannot be\ngreater than max value or\n less than min value.";
                }   
            }
        }
    }
}
