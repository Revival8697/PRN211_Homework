﻿using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetails : Form
    {
        private readonly IProductRepository repository = new ProductRepository();
        public Product product;
        public bool IsEdit;

        public frmProductDetails()
        {
            InitializeComponent();
            RaiseEvent();
        }

        private void RaiseEvent()
        {
            this.Load += frmProductDetails_Load;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += delegate
            {
                var result = MessageBox.Show("Cancel?", (IsEdit) ? "Updating Product" : "Adding Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private Product GetProductData()
        {
            int CategoryId = Convert.ToInt32(txtCategoryId.Text);
            string ProductName = txtProductName.Text;
            string Weight = txtWeight.Text;
            decimal UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            int UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text);
            var product = new Product()
            {
                CategoryId = CategoryId,
                ProductName = ProductName,
                Weight = Weight,
                UnitPrice = UnitPrice,
                UnitsInStock = UnitsInStock
            };
            if (IsEdit)
            {
                int ProductId = Convert.ToInt32(txtProductId.Text);
                product.ProductId = ProductId;
            }
            return product;
        }

        private void SaveProduct()
        {
            try
            {
                var product = GetProductData();
                if (product.ProductId <= 0)
                {
                    throw new Exception("Invalid product id");
                }
                if (string.IsNullOrEmpty(product.ProductName))
                {
                    throw new Exception("Product name can't be empty");
                }
                if (string.IsNullOrEmpty(product.Weight))
                {
                    throw new Exception("Product weight can't be empty");
                }
                if (product.UnitPrice <= 0)
                {
                    throw new Exception("Invalid unit price");
                }
                if (product.UnitsInStock <= 0)
                {
                    throw new Exception("Invalid units in stock");
                }
                if (IsEdit)
                {
                    repository.UpdateProduct(product);
                    MessageBox.Show("Updated this product!");
                }
                else
                {
                    repository.AddProduct(product);
                    MessageBox.Show("Added this product!");
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", (IsEdit) ? "Update Product" : "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            if (product is null)
            {
                return;
            }
            LoadProduct();
        }

        private void LoadProduct()
        {
            try
            {
                if (IsEdit)
                {
                    txtProductId.ReadOnly = true;
                    txtProductId.Text = product.ProductId.ToString();
                    txtCategoryId.Text = product.CategoryId.ToString();
                    txtProductName.Text = product.ProductName;
                    txtWeight.Text = product.Weight;
                    txtUnitPrice.Text = product.UnitPrice.ToString();
                    txtUnitsInStock.Text = product.UnitsInStock.ToString();
                }
                else
                {
                    txtProductId.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Load Product Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
