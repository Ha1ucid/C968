using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_performance_assessment
{
    public partial class ModifyPartForm : Form
    {
        internal ModifyPartForm(InhousePart inhousePart)
        {
            InitializeComponent();

            idLabelModifyPart.Text = Convert.ToString(inhousePart.PartID);
            nameInputModifyPart.Text = inhousePart.Name;
            inventoryInputModifyPart.Text = Convert.ToString(inhousePart.Inventory);
            priceInputModifyPart.Text = Convert.ToString(inhousePart.Price);
            maxInputModifyPart.Text = Convert.ToString(inhousePart.Max);
            minInputModifyPart.Text = Convert.ToString(inhousePart.Min);
            machineCompanyModifyPart.Text = Convert.ToString(inhousePart.MachineID);

            inHouseRadioModifyPart.Checked = true;
        }

        internal ModifyPartForm(OutsourcedPart outsourcedPart)
        {
            InitializeComponent();

            idLabelModifyPart.Text = Convert.ToString(outsourcedPart.PartID);
            nameInputModifyPart.Text = outsourcedPart.Name;
            inventoryInputModifyPart.Text = Convert.ToString(outsourcedPart.Inventory);
            priceInputModifyPart.Text = Convert.ToString(outsourcedPart.Price);
            maxInputModifyPart.Text = Convert.ToString(outsourcedPart.Max);
            minInputModifyPart.Text = Convert.ToString(outsourcedPart.Min);
            machineCompanyModifyPart.Text = outsourcedPart.CompanyName;

            outsourcedRadioModifyPart.Checked = true;
        }


        private void Modify_part_form_Load(object sender, EventArgs e)
        {

        }

        private void InHouseRadioModifyPart_Click(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void OutsourcedRadioModifyPart_Click(object sender, EventArgs e)
        {
            label9.Text = "Company Name";
        }

        private void InHouseRadioModifyPart_checkChanged(object sender, EventArgs e)
        {
            label9.Visible = !label9.Visible;
        } 

        private void OutsourcedRadioModifyPart_checkChanged(object sender, EventArgs e)
        {
            label8.Visible = !label8.Visible;
        } 

        private void CancelButtonModifyPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButtonModifyPart_Click(object sender, EventArgs e)
        {
            if (inHouseRadioModifyPart.Checked == true)
            {
                Int32.TryParse(idLabelModifyPart.Text, out int partId);
                Int32.TryParse(machineCompanyModifyPart.Text, out int machineId);
                string name = nameInputModifyPart.Text;
                Decimal.TryParse(priceInputModifyPart.Text, out decimal price);
                Int32.TryParse(inventoryInputModifyPart.Text, out int inventory);
                Int32.TryParse(maxInputModifyPart.Text, out int max);
                Int32.TryParse(minInputModifyPart.Text, out int min);

                if ((max >= min) && (max >= inventory && min <= inventory))
                {
                    InhousePart inhousePart = new InhousePart(machineId, partId, name, inventory, price, min, max);
                    Inventory.UpdatePart(partId, inhousePart);

                    this.Close();
                }
                else if (min > max)
                {
                    maxInputModifyPart.BackColor = Color.Red;
                    minInputModifyPart.BackColor = Color.Red;
                    
                    label10.Visible = true;
                }
                else if (inventory > max || inventory < min)
                {
                    inventoryInputModifyPart.BackColor = Color.Red;

                    label11.Visible = true;
                }
            }
            else 
            {
                Int32.TryParse(idLabelModifyPart.Text, out int partId);
                string companyName = machineCompanyModifyPart.Text;
                string name = nameInputModifyPart.Text;
                Decimal.TryParse(priceInputModifyPart.Text, out decimal price);
                Int32.TryParse(inventoryInputModifyPart.Text, out int inventory);
                Int32.TryParse(minInputModifyPart.Text, out int min);
                Int32.TryParse(maxInputModifyPart.Text, out int max);

                OutsourcedPart outsourcedPart = new OutsourcedPart(companyName, partId, name, price, inventory, min, max);
                Inventory.UpdatePart(partId, outsourcedPart);

                this.Close();
            }
        }
    }
}
