using BusinessObject;
using DataAccess.Repository;
using System.Data;
using System.Xml.Linq;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();

        private BindingSource memberSource;
        public frmMemberManagement() { InitializeComponent(); }
        private void frmMemberManagement_Load(object sender, EventArgs e) {}
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
            memberRepository.remove(txtMemberId.Text);
            loadMembers();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMemberList.DataSource = null;
            List<MemberObject> searchMembers = new List<MemberObject>();
            MemberObject member = memberRepository.findByIdAndName(
                buildMember().MemberId,
                buildMember().MemberName
            );

            var filterMembers = memberRepository.findByIdAndName(txtMemberIdSearch.Text, txtMemberNameSearch.Text);

            memberSource = new BindingSource();
            memberSource.DataSource = searchMembers;

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

            if (searchMembers.Count() == 0)
            {
                clearText();
                btnDelete.Enabled = false;
            } else { btnDelete.Enabled = true; }
        }
        private void cbCountry_Click(object sender, EventArgs e)
        {
            if (cbCountry.Checked && cbCity.Checked)
            {
                txtCity.ReadOnly = false;
                txtCountry.ReadOnly = false;
            } else if (cbCountry.Checked && !cbCity.Checked)
            {
                txtCountry.ReadOnly = false;
                txtCity.ReadOnly = true;
            } else if (!cbCountry.Checked && cbCity.Checked)
            {
                txtCity.ReadOnly = false;
                txtCountry.ReadOnly = true;

            } else if (!cbCountry.Checked && !cbCity.Checked)
            {
                txtCity.ReadOnly = true;
                txtCountry.ReadOnly = true;
            }
        }
        private void cbCity_Click(object sender, EventArgs e)
        {
            if (cbCity.Checked && cbCountry.Checked)
            {
                txtCity.ReadOnly = false;
                txtCountry.ReadOnly = false;
            } else if (cbCity.Checked && !cbCountry.Checked) 
            {
                txtCity.ReadOnly = false;
                txtCountry.ReadOnly = true;
            } else if (!cbCity.Checked && cbCountry.Checked)
            {
                txtCountry.ReadOnly = false;
                txtCity.ReadOnly = true;
            } else if (!cbCity.Checked && !cbCountry.Checked) {
                txtCity.ReadOnly = true;
                txtCountry.ReadOnly = true;
            }
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
            } else { btnDelete.Enabled = true; }
        }
        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void dgvMemberList_CellValueChanged(object sender, DataGridViewCellEventArgs e) {}
        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filterMembers = memberRepository.filterByCountryAndCity(txtCountry.Text, txtCity.Text);

            memberSource = new BindingSource();
            memberSource.DataSource = filterMembers;

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
        }
    }
}
