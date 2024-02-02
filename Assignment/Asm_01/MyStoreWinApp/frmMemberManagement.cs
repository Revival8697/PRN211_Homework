using BusinessObject;
using DataAccess.Repository;
using System.Data;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();

        private BindingSource memberSource;
        public frmMemberManagement() { InitializeComponent(); }
        private void frmMemberManagement_Load(object sender, EventArgs e) { }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail();
            frmMemberDetail.Text = "Add Member";
            frmMemberDetail.isInsert = true;
            frmMemberDetail.ShowDialog();
            loadMembers();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail();
            frmMemberDetail.Text = "Update Member";
            frmMemberDetail.isInsert = false;
            frmMemberDetail.ShowDialog();
            loadMembers();
        }
        private MemberObject buildMember()
        {
            string memberId = txtMemberId.Text;
            string memberName = txtMemberName.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            MemberObject member = new MemberObject()
            {
                MemberId = memberId,
                MemberName = memberName,
                City = city,
                Country = country,
                Email = email,
                Password = password
            };
            return member;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //memberRepository.remove(txtMemberId.Text);
            loadMembers();
        }
        private void clearText()
        {
            txtMemberName.Text = string.Empty;
            txtMemberId.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
        }
        public void loadMembers()
        {
            var memberList = memberRepository.findAll().OrderByDescending(o => o.MemberName).ToList();
            memberSource = new BindingSource();
            memberSource.DataSource = memberList;

            txtMemberName.DataBindings.Clear();
            txtMemberId.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCity.DataBindings.Clear();

            txtMemberName.DataBindings.Add("Text", memberSource, "MemberName");
            txtMemberId.DataBindings.Add("Text", memberSource, "MemberId");
            txtCountry.DataBindings.Add("Text", memberSource, "Country");
            txtEmail.DataBindings.Add("Text", memberSource, "Email"); ;
            txtPassword.DataBindings.Add("Text", memberSource, "Password");
            txtCity.DataBindings.Add("Text", memberSource, "City");

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = memberSource;
            memberSource.Position = -1;

            if (memberList.Count() == 0)
            {
                clearText();
                btnDelete.Enabled = false;
            }
            else { btnDelete.Enabled = true; }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            var FilterList = memberRepository.filterByCountryAndCity(txtCountryFilter.Text, txtCityFilter.Text).ToList();

            memberSource = new BindingSource();
            memberSource.DataSource = FilterList;

            txtMemberName.DataBindings.Clear();
            txtMemberId.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCity.DataBindings.Clear();

            if (FilterList.Any())
            {
                txtMemberName.DataBindings.Add("Text", memberSource, "MemberName");
                txtMemberId.DataBindings.Add("Text", memberSource, "MemberId");
                txtCountry.DataBindings.Add("Text", memberSource, "Country");
                txtEmail.DataBindings.Add("Text", memberSource, "Email");
                txtPassword.DataBindings.Add("Text", memberSource, "Password");
                txtCity.DataBindings.Add("Text", memberSource, "City");
            }

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = memberSource;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var SearchList = memberRepository.findByIdAndName(txtMemberIdSearch.Text, txtMemberNameSearch.Text);

            memberSource = new BindingSource();
            memberSource.DataSource = SearchList;

            txtMemberName.DataBindings.Clear();
            txtMemberId.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCity.DataBindings.Clear();

            if (SearchList.Any())
            {
                txtMemberName.DataBindings.Add("Text", memberSource, "MemberName");
                txtMemberId.DataBindings.Add("Text", memberSource, "MemberId");
                txtCountry.DataBindings.Add("Text", memberSource, "Country");
                txtEmail.DataBindings.Add("Text", memberSource, "Email");
                txtPassword.DataBindings.Add("Text", memberSource, "Password");
                txtCity.DataBindings.Add("Text", memberSource, "City");
            }

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = memberSource;
        }

        private void btnLoad_Click(object sender, EventArgs e) { loadMembers(); }

        private void cbCountry_Click(object sender, EventArgs e)
        {
            if (cbCountry.Checked && cbCity.Checked)
            {
                txtCityFilter.ReadOnly = false;
                txtCountryFilter.ReadOnly = false;
            }
            else if (cbCountry.Checked && !cbCity.Checked)
            {
                txtCountryFilter.ReadOnly = false;
                txtCityFilter.ReadOnly = true;
                txtCityFilter.Clear();
            }
            else if (!cbCountry.Checked && cbCity.Checked)
            {
                txtCityFilter.ReadOnly = false;
                txtCountryFilter.ReadOnly = true;
                txtCountryFilter.Clear();
            }
            else if (!cbCountry.Checked && !cbCity.Checked)
            {
                txtCityFilter.ReadOnly = true;
                txtCountryFilter.ReadOnly = true;
                txtCountryFilter.Clear();
                txtCityFilter.Clear();
            }
        }
        private void cbCity_Click(object sender, EventArgs e)
        {
            if (cbCity.Checked && cbCountry.Checked)
            {
                txtCityFilter.ReadOnly = false;
                txtCountryFilter.ReadOnly = false;
            }
            else if (cbCity.Checked && !cbCountry.Checked)
            {
                txtCityFilter.ReadOnly = false;
                txtCountryFilter.ReadOnly = true;
                txtCountryFilter.Clear();
            }
            else if (!cbCity.Checked && cbCountry.Checked)
            {
                txtCountryFilter.ReadOnly = false;
                txtCityFilter.ReadOnly = true;
                txtCityFilter.Clear();
            }
            else if (!cbCity.Checked && !cbCountry.Checked)
            {
                txtCityFilter.ReadOnly = true;
                txtCountryFilter.ReadOnly = true;
                txtCountryFilter.Clear();
                txtCityFilter.Clear();
            }
        }
        private void cbMemberIdSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMemberNameSearch.Checked && cbMemberIdSearch.Checked)
            {
                txtMemberNameSearch.ReadOnly = false;
                txtMemberIdSearch.ReadOnly = false;
            }
            else if (cbMemberNameSearch.Checked && !cbMemberIdSearch.Checked)
            {
                txtMemberNameSearch.ReadOnly = false;
                txtMemberIdSearch.ReadOnly = true;
                txtMemberNameSearch.Clear();
            }
            else if (!cbMemberNameSearch.Checked && cbMemberIdSearch.Checked)
            {
                txtMemberNameSearch.ReadOnly = false;
                txtMemberIdSearch.ReadOnly = true;
                txtMemberIdSearch.Clear();
            }
            else if (!cbMemberNameSearch.Checked && !cbMemberIdSearch.Checked)
            {
                txtMemberNameSearch.ReadOnly = true;
                txtMemberIdSearch.ReadOnly = true;
                txtMemberNameSearch.Clear();
                txtMemberIdSearch.Clear();
            }
        }
        private void CBMemberNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMemberNameSearch.Checked && cbMemberIdSearch.Checked)
            {
                txtMemberNameSearch.ReadOnly = false;
                txtMemberIdSearch.ReadOnly = false;
            }
            else if (cbMemberNameSearch.Checked && !cbMemberIdSearch.Checked)
            {
                txtMemberNameSearch.ReadOnly = false;
                txtMemberIdSearch.ReadOnly = true;
                txtMemberNameSearch.Clear();
            }
            else if (!cbMemberNameSearch.Checked && cbMemberIdSearch.Checked)
            {
                txtMemberNameSearch.ReadOnly = false;
                txtMemberIdSearch.ReadOnly = true;
                txtMemberIdSearch.Clear();
            }
            else if (!cbMemberNameSearch.Checked && !cbMemberIdSearch.Checked)
            {
                txtMemberNameSearch.ReadOnly = true;
                txtMemberIdSearch.ReadOnly = true;
                txtMemberNameSearch.Clear();
                txtMemberIdSearch.Clear();
            }
        }
    }
}
