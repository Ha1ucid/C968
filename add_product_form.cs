using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_performance_assessment
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();


            partDataGridView1.DataSource = Inventory.AllParts;
            productDataGridView2.DataSource = Product.AssociatedParts;
        }

        private void CancelButttonAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
           
        }

        private void SaveButtonAddProduct_Click(object sender, EventArgs e)
        {
            Int32.TryParse(idInputAddProduct.Text, out int productId);
            string name = nameInputAddProduct.Text;
            Int32.TryParse(inventoryInputAddProduct.Text, out int inventory);
            Decimal.TryParse(priceInputAddProduct.Text, out decimal price);
            Int32.TryParse(minInputAddProduct.Text, out int min);
            Int32.TryParse(maxInputAddProduct.Text, out int max);

            if ((max >= min) && (inventory >= min && inventory <= max))
            {
                if (Inventory.LookupProduct(productId) == null)
                {
                    Product product = new Product(productId, name, inventory, price, min, max);
                    Inventory.Products.Add(product);
                }
                else
                {
                    ProductAlreadyExists productAlreadyExists = new ProductAlreadyExists();
                    productAlreadyExists.ShowDialog();
                }

                this.Close();
            }
            else if (min > max)
            {
                maxInputAddProduct .BackColor = Color.Red;
                minInputAddProduct.BackColor = Color.Red;

                label10.Visible = true;
            }
            else if (inventory > max || inventory < min)
            {
                inventoryInputAddProduct .BackColor = Color.Red;

                label11.Visible = true;
            }
        }

        private void AddButtonAddProduct_Click(object sender, EventArgs e)
        {
            Part part = (Part)partDataGridView1.CurrentRow.DataBoundItem;
            Product.AddAssociatedPart(part);
        }

        private void DeleteButtonAddProduct_Click(object sender, EventArgs e)
        {
            DeleteValidation deleteValidation = new DeleteValidation();
            deleteValidation.ShowDialog();

            if (DeleteValidation.DeleteReturn() == true)
            {
                Part part = (Part)productDataGridView2.CurrentRow.DataBoundItem;
                Product.AssociatedParts.Remove(part);
            }
        }

        private void SearchButtonAddProduct_Click(object sender, EventArgs e)
        {
            int searchedPartID;
            if (Int32.TryParse(searchBoxAddProduct.Text, out searchedPartID))
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
