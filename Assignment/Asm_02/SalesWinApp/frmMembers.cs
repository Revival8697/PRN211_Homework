using BusinessObject.Models;
using DataAccess.Repository;
using System.Data;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        private readonly IMemberRepository memberRepository = new MemberRepository();
        private readonly IOrderRepository orderRepository = new OrderRepository();
        private BindingSource source;
        string Keyword
        {
            get => txtKeyword.Text.Trim();
            set => txtKeyword.Text = value;
        }
        string companyName { get => cbCompanyName.SelectedItem?.ToString() ?? string.Empty; }
        public frmMembers()
        {
            InitializeComponent();
            InitializeData();
            RaiseEvent();
        }
        private void RaiseEvent()
        {
            this.Load += frmMembers_Load;
            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
            dgvMembers.CellDoubleClick += dgvMembers_CellDoubleClick;
            cbCompanyName.KeyPress += cbCompanyName_KeyPress;
            btnResetFilter.Click += btnResetFilter_Click;

            btnDelete.Click += btnDelete_Click;
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSearch.Click += btnSearch_Click;
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to reset the filter?", "Reset Filter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetFilter();
                LoadMemberList();
            }
        }
        private void ResetFilter()
        {
            txtKeyword.Clear();
            cbCompanyName.SelectedIndex = -1;
        }
        private void cbCompanyName_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }
        private void btnSearch_Click(object sender, EventArgs e) { SearchMembers(); }
        private void SearchMembers()
        {
            var MemberList = memberRepository.GetAllMembers(Keyword, companyName);
            source = new BindingSource();
            source.DataSource = MemberList;

            txtMemberId.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtMemberId.DataBindings.Add("Text", source, "MemberId");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");
            txtPassword.DataBindings.Add("Text", source, "Password");

            dgvMembers.DataSource = null;
            dgvMembers.DataSource = MemberList;
            dgvMembers.Columns["Orders"].Visible = false;
        }
        private void InitializeData()
        {
            var companyNameList = memberRepository.GetAllMembers().Select(member => member.CompanyName).ToArray();
            cbCompanyName.Items.AddRange(companyNameList);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMember();
            InitializeData();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var DetailsMemberForm = new frmMemberDetails(false, true);
            if (DetailsMemberForm.ShowDialog() == DialogResult.OK) { LoadMemberList(); }
        }
        private void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMember();
            InitializeData();
        }
        private void UpdateMember()
        {
            var member = GetMemberFromSelectingRow();
            var DetailsMemberForm = new frmMemberDetails(true, true) { CurrentMember = member };
            if (DetailsMemberForm.ShowDialog() == DialogResult.OK)
            {
                ClearText();
                LoadMemberList();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Delete this member?", "Delete member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteMember();
                InitializeData();
            }
        }
        private Member GetMemberFromSelectingRow()
        {
            Member member = null;
            if (dgvMembers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMembers.SelectedRows[0];
                int MemberId = Convert.ToInt32(selectedRow.Cells["MemberId"].Value);
                string Email = selectedRow.Cells["Email"].Value.ToString();
                string CompanyName = selectedRow.Cells["CompanyName"].Value.ToString();
                string Country = selectedRow.Cells["Country"].Value.ToString();
                string City = selectedRow.Cells["City"].Value.ToString();
                string Password = selectedRow.Cells["Password"].Value.ToString();

                member = new Member()
                {
                    MemberId = MemberId,
                    Email = Email,
                    CompanyName = CompanyName,
                    Country = Country,
                    City = City,
                    Password = Password
                };
            }
            return member;
        }
        private void DeleteMember()
        {
            var member = GetMemberFromSelectingRow();
            var orderList = orderRepository.GetOrdersByMemberID(member.MemberId);
            if (orderList.Count > 0) { orderRepository.DeleteMemberOrders(member.MemberId); }
            memberRepository.DeleteMember(member);
            ClearText();
            LoadMemberList();
        }
        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            var member = GetMemberFromSelectingRow();
            if (member is null) { return; }
            UpdateMemberOnTextBoxes(member);
        }

        private void ClearText()
        {
            txtMemberId.Clear();
            txtEmail.Clear();
            txtCompanyName.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPassword.Clear();
        }

        private void UpdateMemberOnTextBoxes(Member member)
        {
            if (member is null) { return; }
            txtMemberId.Text = member.MemberId.ToString();
            txtEmail.Text = member.Email;
            txtCompanyName.Text = member.CompanyName;
            txtCity.Text = member.City;
            txtCountry.Text = member.Country;
            txtPassword.Text = member.Password;
        }
        private void frmMembers_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadMemberList();
        }
        private void LoadMemberList()
        {
            var MemberList = memberRepository.GetAllMembers();
            source = new BindingSource();
            source.DataSource = MemberList;

            txtMemberId.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtMemberId.DataBindings.Add("Text", source, "MemberId");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");
            txtPassword.DataBindings.Add("Text", source, "Password");

            dgvMembers.DataSource = null;
            dgvMembers.DataSource = MemberList;
            dgvMembers.Columns["Orders"].Visible = false;
        }
    }
}