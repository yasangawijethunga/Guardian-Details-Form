using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuardianDetailsForm
{
    public partial class GuardianDetailsForm : Form
    {
        public GuardianDetailsForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            SetupButtons();
        }

        private void SetupButtons()
        {
            btnSubmit.BackColor = Color.White;
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderColor = Color.Gray;
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.LightGray;

            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderColor = Color.Gray;
            btnClear.FlatAppearance.MouseOverBackColor = Color.LightGray;
        }

        private void GuardianDetailsForm_Load(object sender, EventArgs e)
        {
            rdoMother.Checked = true;
            ToggleGuardianDetails();
        }

        private void rdoMother_CheckedChanged(object sender, EventArgs e) => ToggleGuardianDetails();
        private void rdoFather_CheckedChanged(object sender, EventArgs e) => ToggleGuardianDetails();
        private void rdoGuardian_CheckedChanged(object sender, EventArgs e) => ToggleGuardianDetails();

        private void ToggleGuardianDetails()
        {
            lblTitle.Text = rdoMother.Checked ? "Mother's Details" :
                           rdoFather.Checked ? "Father's Details" : "Guardian's Details";
            lblRelationship.Visible = txtRelationship.Visible = rdoGuardian.Checked;
        }

        private void ClearAllFields()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtNIC.Clear();
            txtOccupation.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtRelationship.Clear();
            rdoMother.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearAllFields();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MessageBox.Show("Guardian details saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please enter Student ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
