using Microsoft.EntityFrameworkCore;
using Service.Models;
using Service.Repository;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Convenience_Store
{
    public partial class MerchandiseOrder : Form
    {
        private RepoCategory _repoCat;
        private readonly RepoMerchandise _repoMer = new();
        private readonly RepoCategory _repoCategory = new();
        private readonly ConvenienceStoreContext _context = new();
        private int _selectedMerchaId;

        public MerchandiseOrder()
        {
            InitializeComponent();
            _repoCat = new RepoCategory();
            PrepareCategoryComboBox();
        }
        private void MerchandiseOrder_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            var data = _repoMer.GetAll().ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void dgvKho_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvKho_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 1).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }
        private void btnAlcoho_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 2).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 3).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnInstant_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 4).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 5).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 6).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 7).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnSpices_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 8).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnCigarette_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 9).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 10).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnTissue_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 11).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnFrozen_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 12).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnCanned_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 13).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void btnChemicals_Click(object sender, EventArgs e)
        {
            var data = _repoMer.GetAll().Where(m => m.MerIdCategory == 14).ToList();
            dgvKho.DataSource = data;
            dgvKho.Refresh();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MerchandiseOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exitting...", "Not an error", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            AddMerchandise addMer = new();
            addMer.ShowDialog();
            LoadDataFromDatabase();
        }

       private void Edit_Click(object sender, EventArgs e)
        {
            if (_selectedMerchaId == 0)
            {
        MessageBox.Show("Please choose an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
            }


            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtQuantity.Text) || cbCategory.SelectedValue == null)
    {
        MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }


    if (!double.TryParse(txtPrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double price) || !int.TryParse(txtQuantity.Text, out int quantity))
    {
        MessageBox.Show("Price or Quantity is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }


    Merchandise updatedMerchandise = new Merchandise
    {
        MerId = _selectedMerchaId,
        MerName = txtName.Text,
        MerDescription = txtDes.Text,
        MerPrice = price,
        MerQuantity = quantity,
        MerUnit = txtUnit.Text,
        MerIdCategory = Convert.ToInt32(cbCategory.SelectedValue)
    };


    _repoMer.Update(updatedMerchandise);

    LoadDataFromDatabase();
            
    MessageBox.Show("Mặt hàng đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataFromDatabase();
        }




        private void Finish_Click(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = textBox1.Text;
            var data = _repoMer.GetAll();

            if (!string.IsNullOrEmpty(strSearch.Trim()))
            {
                data = data.Where(m => m.MerName.Contains(strSearch)).ToList();
                dgvKho.DataSource = data;
            }
        }

        private void dgvKho_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvKho_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedMerchaId = (int)e.RowIndex;
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKho.Rows.Count)
            {
                DataGridViewRow row = dgvKho.Rows[e.RowIndex];
                Merchandise selectedMerchandise = (Merchandise)row.DataBoundItem;

                txtName.Text = selectedMerchandise.MerName;
                txtDes.Text = selectedMerchandise.MerDescription;
                txtPrice.Text = selectedMerchandise.MerPrice.ToString();
                txtQuantity.Text = selectedMerchandise.MerQuantity.ToString();
                txtUnit.Text = selectedMerchandise.MerUnit;
                _selectedMerchaId = selectedMerchandise.MerId;
            }
        }

        private void PrepareCategoryComboBox()
        {
            List<Category> categories = _repoCat.GetAll();

            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "nameCategory";
            cbCategory.ValueMember = "idCategory";
        }
        private void Delete_Click_1(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count > 0)
            {

                var selectedEntity = (Merchandise)dgvKho.SelectedRows[0].DataBoundItem;

                var repo = new RepoBase<Merchandise>();

                try { bool isDeleted = repo.Delete(selectedEntity);
                    if (isDeleted)
                    {
                        MessageBox.Show("Entity deleted successfully.");
                        dgvKho.DataSource = repo.GetAll();
                    }
                }
                catch (Exception ex) { MessageBox.Show("This item is part of another table and therefore cannot be deleted."); }

            }
        }
    }
}
