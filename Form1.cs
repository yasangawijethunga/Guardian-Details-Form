using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace GuardianDetailsForm
{
    public partial class GuardianDetailsForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Demo User\Desktop\GuardianDetailsForm\HostelDB.accdb.accdb;Persist Security Info=False;";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int StudentID { get; set; }

        public GuardianDetailsForm()
        {
            InitializeComponent();
            // this.WindowState = FormWindowState.Maximized;
        }

        private void GuardianDetailsForm_Load(object sender, EventArgs e)
        {
            rdoMother.Checked = true;
            ToggleGuardianDetails();
        }

        private void rdoMother_CheckedChanged(object sender, EventArgs e)
        {
            ToggleGuardianDetails();
        }

        private void rdoFather_CheckedChanged(object sender, EventArgs e)
        {
            ToggleGuardianDetails();
        }

        private void ToggleGuardianDetails()
        {
            lblTitle.Text = rdoMother.Checked ? "Mother's Details" : "Father's Details";
            ClearFields();
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtNIC.Clear();
            txtOccupation.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LimeGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.SteelBlue;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.LimeGreen;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.SteelBlue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        string query = @"INSERT INTO Guardians 
                                        (StudentID, GuardianType, FullName, NIC, Occupation, Address, ContactNumber, Email) 
                                        VALUES 
                                        (@StudentID, @GuardianType, @FullName, @NIC, @Occupation, @Address, @ContactNumber, @Email)";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.Add("@StudentID", OleDbType.Integer).Value = StudentID;
                            cmd.Parameters.Add("@GuardianType", OleDbType.VarChar).Value = rdoMother.Checked ? "Mother" : "Father";
                            cmd.Parameters.Add("@FullName", OleDbType.VarChar).Value = txtFullName.Text;
                            cmd.Parameters.Add("@NIC", OleDbType.VarChar).Value = txtNIC.Text;
                            cmd.Parameters.Add("@Occupation", OleDbType.VarChar).Value = txtOccupation.Text;
                            cmd.Parameters.Add("@Address", OleDbType.VarChar).Value = txtAddress.Text;
                            cmd.Parameters.Add("@ContactNumber", OleDbType.VarChar).Value = txtContact.Text;
                            cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = txtEmail.Text;

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Guardian details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No records were saved.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving guardian details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || !int.TryParse(txtStudentID.Text, out int sid))
            {
                MessageBox.Show("Please enter a valid Student ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return false;
            }

            StudentID = sid; // Assign parsed StudentID

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                MessageBox.Show("Please enter NIC number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIC.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter contact number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return false;
            }



            if (string.IsNullOrWhiteSpace(txtOccupation.Text))
            {
                MessageBox.Show("Please enter occupation", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOccupation.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                MessageBox.Show("Please enter NIC number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIC.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter contact number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
