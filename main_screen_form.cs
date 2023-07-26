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
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();

            partDataGridView.DataSource = Inventory.AllParts;

            productDataGridView.DataSource = Inventory.Products;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.Show();
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            // Populate data grids
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

            Product product1 = new Product(0, "Red Bicycle", 15, 11.44m, 1, 25);
            Product product2 = new Product(1, "Yellow Bicycle", 19, 9.66m, 1, 20);
            Product product3 = new Product(2, "Blue Bicycle", 5, 12.77m, 1, 25);
            Product product4 = new Product(3, "Green Bicycle", 10, 111.64m, 1, 20);

            Inventory.Products.Add(product1);
            Inventory.Products.Add(product2);
            Inventory.Products.Add(product3);
            Inventory.Products.Add(product4);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (partDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(C968_performance_assessment.InhousePart))
            {
                InhousePart inhousePart = (InhousePart)partDataGridView.CurrentRow.DataBoundItem;
                new ModifyPartForm(inhousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)partDataGridView.CurrentRow.DataBoundItem;
                new ModifyPartForm(outsourcedPart).ShowDialog();
            }
            this.Refresh();
        }

        private void ModifyProductsButton_Click(object sender, EventArgs e)
        {
            if (productDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(C968_performance_assessment.Product))
            {
                Product product = (Product)productDataGridView.CurrentRow.DataBoundItem;
                new ModifyProductForm(product).ShowDialog();
            }
            this.Refresh();
        }

        private void DeleteButtonPart_Click(object sender, EventArgs e)
        {
            DeleteValidation deleteValidation = new DeleteValidation();
            deleteValidation.ShowDialog();

            if (DeleteValidation.DeleteReturn() == true)
            {
                Part part = (Part)partDataGridView.CurrentRow.DataBoundItem;
                Inventory.DeletePart(part);
            }
        }

        private void DeleteButtonProduct_Click(object sender, EventArgs e)
        {
            DeleteValidation deleteValidation = new DeleteValidation();
            deleteValidation.ShowDialog();

            if (Product.AssociatedParts.Count == 0)
            {
                if (DeleteValidation.DeleteReturn() == true)
                {
                    Product product = (Product)productDataGridView.CurrentRow.DataBoundItem;
                    Inventory.RemoveProduct(product);
                }
            }
            else
            {
                PartAssociatedWithProduct partAssociatedWithProduct = new PartAssociatedWithProduct();
                partAssociatedWithProduct.ShowDialog();
            }
        }

        private void SearchButtonMain2_Click(object sender, EventArgs e)
        {
            int searchedProductID;
            if (Int32.TryParse(searchBoxMain2.Text, out searchedProductID))
            {
                Product searchedProduct = Inventory.LookupProduct(searchedProductID);

                if (searchedProduct != null)
                {
                    foreach (DataGridViewRow row in productDataGridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;

                        if (product.ProductID == searchedProduct.ProductID)
                        {
                            row.Selected = true;
                        }
                    }

                }
                else if (searchedProduct == null)
                {
                    ProductNotFoundForm productNotFoundForm = new ProductNotFoundForm();
                    productNotFoundForm.ShowDialog();
                }

            }
        }

        private void SearchButtonMain1_Click(object sender, EventArgs e)
        {
            int searchedPartID;
            if (Int32.TryParse(searchBoxMain1.Text, out searchedPartID))
            {
                Part searchedPart = Inventory.LookupPart(searchedPartID);

                if (searchedPart != null)
                {
                    foreach (DataGridViewRow row in partDataGridView.Rows)
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
