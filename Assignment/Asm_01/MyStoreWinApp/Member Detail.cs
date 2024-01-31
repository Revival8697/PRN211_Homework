using BusinessObject;
using DataAccess.Repository;
using System.Net.Mail;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public bool isInsert = false;
        public frmMemberDetail()
        { InitializeComponent(); }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidDataInput()) { MessageBox.Show("Must input all field"); }
            else if (!isValidEmail(txtEmail.Text)) { MessageBox.Show("Email Invalid"); }
            else if (isValidDataInput()) {
                MemberObject member = new MemberObject
                {
                    MemberId = txtMemberId.Text,
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };

                if (isInsert) { memberRepository.insert(member); }
                else { memberRepository.update(member); }

                this.Close();
            }
        }
        bool isValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            } catch (FormatException) { return false; }
        }
        bool isValidDataInput()
        {
            return !String.IsNullOrEmpty(txtMemberId.Text) &&
                   !String.IsNullOrEmpty(txtMemberName.Text) &&
                   !String.IsNullOrEmpty(txtEmail.Text) &&
                   !String.IsNullOrEmpty(txtPassword.Text) &&
                   !String.IsNullOrEmpty(txtCountry.Text) &&
                   !String.IsNullOrEmpty(txtCity.Text);
        }
    }
}
