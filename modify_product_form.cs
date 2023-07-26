using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_performance_assessment
{
    public partial class ModifyProductForm : Form
    {
        internal ModifyProductForm(Product product)
        {
            InitializeComponent();

            partDataGridView1.DataSource = Inventory.AllParts;
            productDataGridView2.DataSource = Product.AssociatedParts;

            idModifyProduct.Text = Convert.ToString(product.ProductID);
            nameInputModifyProduct.Text = product.Name;
            inventoryInputModifyProduct.Text = Convert.ToString(product.Inventory);
            priceInputModifyProduct.Text = Convert.ToString(product.Price);
            maxInputModifyProduct.Text = Convert.ToString(product.Max);
            minInputModifyProduct.Text = Convert.ToString(product.Min);
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            Part part1 = new InhousePart(1, 0, "Wheel", 15, 12.11m, 5, 25);
            Part part2 = new InhousePart(2, 1, "Pedal", 11, 8.22m, 5, 25);
            Part part3 = new InhousePart(3, 2, "Chain", 12, 8.33m, 5, 25);
            Part part4 = new InhousePart(4, 3, "Seat", 18, 4.55m, 2, 15);
            Part part5 = new OutsourcedPart("The Bike Shop", 4, "Sprocket", 22.36m, 6, 2, 5);

            Inventory.AllParts.Add(part1);
            Inventory.AllParts.Add(part2);
            Inventory.AllParts.Add(part3);
            Inventory.AllParts.Add(part4);
            Inventory.AllParts.Add(part5);
        }

        private void CancelButttonModifyProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButtonModifyProduct_Click(object sender, EventArgs e)
        {
            Int32.TryParse(idModifyProduct.Text, out int productId);
            string name = nameInputModifyProduct.Text;
            Int32.TryParse(inventoryInputModifyProduct.Text, out int inventory);
            Decimal.TryParse(priceInputModifyProduct.Text, out decimal price);
            Int32.TryParse(minInputModifyProduct.Text, out int min);
            Int32.TryParse(maxInputModifyProduct.Text, out int max);

            if ((max >= min) && (inventory >= min && inventory <= max))
            {
                Product product = new Product(productId, name, inventory, price, min, max);
                Inventory.UpdateProduct(productId, product);

                this.Close();
            }
            else if (min > max)
            {
                maxInputModifyProduct.BackColor = Color.Red;
                minInputModifyProduct.BackColor = Color.Red;

                label10.Visible = true;
            }
            else if (inventory >= max || inventory <= min)
            {
                inventoryInputModifyProduct.BackColor = Color.Red;

                label11.Visible = true;
            }
        }

        private void AddButtonModifyProduct_Click(object sender, EventArgs e)
        {
            Part part = (Part)partDataGridView1.CurrentRow.DataBoundItem;
            Product.AddAssociatedPart(part);
        }

        private void DeleteButtonModifyProduct_Click(object sender, EventArgs e)
        {
            DeleteValidation deleteValidation = new DeleteValidation();
            deleteValidation.ShowDialog();

            if (DeleteValidation.DeleteReturn() == true)
            {
                Part part = (Part)productDataGridView2.CurrentRow.DataBoundItem;
                Product.AssociatedParts.Remove(part);
            }
        }

        private void SearchButtonModifyProduct_Click(object sender, EventArgs e)
        {
            int searchedPartID;
            if (Int32.TryParse(searchBoxModifyProduct.Text, out searchedPartID))
            {
                Part searchedPart = Inventory.LookupPart(searchedPartID);

                if (searchedPart != null)
                {
                    foreach (DataGridViewRow row in partDataGridView1.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;

                        if (part.PartID == searchedPart.PartID)
                        {
                            row.Selected = true;
                        }
                    }

                }
                else if (searchedPart == null)
                {
                    PartNotFoundForm partNotFoundForm = new PartNotFoundForm();
                    partNotFoundForm.ShowDialog();
                }

            }
        }
    }
}
