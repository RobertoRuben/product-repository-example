using System;
using System.Windows.Forms;
using BusinessLayer.services;
using EntitiesLayer.entities;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private string operation = "";
        private ProductsService _productsService;
        public Form1()
        {
            InitializeComponent();
            _productsService = new ProductsService();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productsService.GetProducts();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoGenerateColumns = true;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxName.Text) || string.IsNullOrEmpty(tboxDescription.Text) || string.IsNullOrEmpty(tboxPrice.Text))
            {
                ErrorMessage("Please fill all fields");
                return;
            }

            try
            {
                var product = new Products
                {
                    Name = tboxName.Text,
                    Description = tboxDescription.Text,
                    Price = decimal.Parse(tboxPrice.Text)  
                };

                if (operation.Equals("Update"))
                {
                    // Actualización del producto existente
                    product.IdProduct = Convert.ToInt32(dgvProducts.CurrentRow.Cells["IdProduct"].Value);
                    _productsService.UpdateProducts(product);
                    ShowButtons();
                    OkMessage("Product updated successfully");
                    
                }
                else if(operation.Equals("New"))
                {
                    // Agregar nuevo producto
                    _productsService.AddProducts(product);
                    ClearTextBox();
                    ShowButtons();
                    OkMessage("Product added successfully");
                }
                LoadProducts();  // Recargar lista de productos
            }
            catch (FormatException fe)
            {
                ErrorMessage($"Input format error. {fe.Message}");
            }
            catch (Exception ex)
            {
                ErrorMessage($"Error: {ex.Message}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                ErrorMessage("Select a product to delete");
                return;
            }

            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["IdProduct"].Value);

            if (MessageBox.Show("Are you sure you want to remove this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _productsService.DeleteProducts(id);
                OkMessage("Product disposed correctly");
                ClearTextBox();
                ShowButtons();
                LoadProducts();
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchName = tboxSearch.Text; 
            if (string.IsNullOrWhiteSpace(searchName))
            {
                ErrorMessage("Please enter a name to search for.");
                return;
            }

            var foundProducts = _productsService.FindByName(searchName);
            if (foundProducts.Count > 0)
            {
                dgvProducts.DataSource = foundProducts;
            }
            else
            {
                dgvProducts.DataSource = null;
                OkMessage("No products found with that name.");
            }
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                tboxName.Text = row.Cells["Name"].Value.ToString();
                tboxDescription.Text = row.Cells["Description"].Value.ToString();
                tboxPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }
        //Messages
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Add Product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "New";
            HideButtons();
            ClearTextBox();
        }

        private void ShowButtons()
        {
            btnAdd.Visible = true;
            btnModify.Visible = true;
            btnDelete.Visible = true;
        }

        private void HideButtons()
        {
            btnAdd.Visible = false;
            btnModify.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            operation = "Update";
            HideButtons();
        }

        private void ClearTextBox()
        {
            tboxName.Text = null;
            tboxDescription.Text = null;
            tboxPrice.Text = null;
        }
    }
}