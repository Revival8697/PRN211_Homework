using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Convenience_Store
{
    public partial class AddMerchandise : Form
    {
        private RepoCategory _repoCat;
        private RepoMerchandise _repoMer;
        public AddMerchandise()
        {
            InitializeComponent();
            _repoCat = new RepoCategory();
            _repoMer = new RepoMerchandise();
            PrepareCategoryComboBox();

        }
        private void PrepareCategoryComboBox()
        {
            List<Category> categories = _repoCat.GetAll();

            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "nameCategory";
            cbCategory.ValueMember = "idCategory";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDes.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            string unit = txtUnit.Text;
            int categoryId = (int)cbCategory.SelectedValue;

            Merchandise merchandise = new Merchandise();
            merchandise.MerName = name;
            merchandise.MerDescription = description;
            merchandise.MerPrice = (double)price;
            merchandise.MerQuantity = quantity;
            merchandise.MerUnit = unit;
            merchandise.MerIdCategory = categoryId;

            _repoMer.Create(merchandise);

            MessageBox.Show("Add Successfully!", "Notification", MessageBoxButtons.OK);
            this.Close();
        }

        private void AddMerchandise_Load(object sender, EventArgs e)
        {

        }
    }
}
