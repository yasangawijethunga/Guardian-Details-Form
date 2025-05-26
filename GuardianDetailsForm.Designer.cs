namespace GuardianDetailsForm
{
    partial class GuardianDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpGuardianType = new System.Windows.Forms.GroupBox();
            this.rdoFather = new System.Windows.Forms.RadioButton();
            this.rdoMother = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpGuardianType.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpGuardianType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStudentID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFullName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFullName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNIC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNIC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblOccupation, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtOccupation, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblContact, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtContact, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpGuardianType
            // 
            this.grpGuardianType.Controls.Add(this.rdoFather);
            this.grpGuardianType.Controls.Add(this.rdoMother);
            this.grpGuardianType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGuardianType.Location = new System.Drawing.Point(13, 13);
            this.grpGuardianType.Name = "grpGuardianType";
            this.grpGuardianType.Size = new System.Drawing.Size(114, 44);
            this.grpGuardianType.TabIndex = 0;
            this.grpGuardianType.TabStop = false;
            this.grpGuardianType.Text = "Guardian Type";
            // 
            // rdoFather
            // 
            this.rdoFather.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoFather.AutoSize = true;
            this.rdoFather.Location = new System.Drawing.Point(60, 20);
            this.rdoFather.Name = "rdoFather";
            this.rdoFather.Size = new System.Drawing.Size(55, 17);
            this.rdoFather.TabIndex = 1;
            this.rdoFather.Text = "Father";
            this.rdoFather.UseVisualStyleBackColor = true;
            this.rdoFather.CheckedChanged += new System.EventHandler(this.rdoFather_CheckedChanged);
            // 
            // rdoMother
            // 
            this.rdoMother.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoMother.AutoSize = true;
            this.rdoMother.Checked = true;
            this.rdoMother.Location = new System.Drawing.Point(6, 20);
            this.rdoMother.Name = "rdoMother";
            this.rdoMother.Size = new System.Drawing.Size(57, 17);
            this.rdoMother.TabIndex = 0;
            this.rdoMother.TabStop = true;
            this.rdoMother.Text = "Mother";
            this.rdoMother.UseVisualStyleBackColor = true;
            this.rdoMother.CheckedChanged += new System.EventHandler(this.rdoMother_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(133, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Mother\'s Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentID.Location = new System.Drawing.Point(13, 63);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(114, 30);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentID.Location = new System.Drawing.Point(133, 66);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(338, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullName.Location = new System.Drawing.Point(13, 93);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(114, 30);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFullName
            // 
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Location = new System.Drawing.Point(133, 96);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(338, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNIC.Location = new System.Drawing.Point(13, 123);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(114, 30);
            this.lblNIC.TabIndex = 6;
            this.lblNIC.Text = "NIC";
            this.lblNIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNIC
            // 
            this.txtNIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNIC.Location = new System.Drawing.Point(133, 126);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(338, 20);
            this.txtNIC.TabIndex = 7;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOccupation.Location = new System.Drawing.Point(13, 153);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(114, 30);
            this.lblOccupation.TabIndex = 8;
            this.lblOccupation.Text = "Occupation";
            this.lblOccupation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOccupation.Location = new System.Drawing.Point(133, 156);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(338, 20);
            this.txtOccupation.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(13, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(114, 60);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(133, 186);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(338, 54);
            this.txtAddress.TabIndex = 11;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContact.Location = new System.Drawing.Point(13, 243);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(114, 30);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Contact Number";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContact
            // 
            this.txtContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContact.Location = new System.Drawing.Point(133, 246);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(338, 20);
            this.txtContact.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(13, 273);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(114, 30);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(133, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // panelButtons
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelButtons, 2);
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(13, 303);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(458, 45);
            this.panelButtons.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(368, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(278, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GuardianDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "GuardianDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guardian Details";
            this.Load += new System.EventHandler(this.GuardianDetailsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpGuardianType.ResumeLayout(false);
            this.grpGuardianType.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpGuardianType;
        private System.Windows.Forms.RadioButton rdoFather;
        private System.Windows.Forms.RadioButton rdoMother;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
