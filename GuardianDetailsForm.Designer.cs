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
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentID);

            this.grpGuardianType = new System.Windows.Forms.GroupBox();
            this.rdoFather = new System.Windows.Forms.RadioButton();
            this.rdoMother = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpGuardianType.SuspendLayout();
            this.SuspendLayout();

            /////
            // 
            // lblStudentID
            // 
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(12, 55);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentID.Location = new System.Drawing.Point(120, 52);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 2;

            // 
            // grpGuardianType
            // 
            this.grpGuardianType.Controls.Add(this.rdoFather);
            this.grpGuardianType.Controls.Add(this.rdoMother);
            this.grpGuardianType.Location = new System.Drawing.Point(12, 12);
            this.grpGuardianType.Name = "grpGuardianType";
            this.grpGuardianType.Size = new System.Drawing.Size(200, 50);
            this.grpGuardianType.TabIndex = 0;
            this.grpGuardianType.TabStop = false;
            this.grpGuardianType.Text = "Guardian Type";
            // 
            // rdoFather
            // 
            this.rdoFather.AutoSize = true;
            this.rdoFather.Location = new System.Drawing.Point(100, 20);
            this.rdoFather.Name = "rdoFather";
            this.rdoFather.Size = new System.Drawing.Size(55, 17);
            this.rdoFather.TabIndex = 1;
            this.rdoFather.Text = "Father";
            this.rdoFather.UseVisualStyleBackColor = true;
            this.rdoFather.CheckedChanged += new System.EventHandler(this.rdoFather_CheckedChanged);
            // 
            // rdoMother
            // 
            this.rdoMother.AutoSize = true;
            this.rdoMother.Checked = true;
            this.rdoMother.Location = new System.Drawing.Point(10, 20);
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
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(230, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Mother\'s Details";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 80);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(120, 77);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(12, 110);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(25, 13);
            this.lblNIC.TabIndex = 4;
            this.lblNIC.Text = "NIC";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(120, 107);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(150, 20);
            this.txtNIC.TabIndex = 5;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(12, 140);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 6;
            this.lblOccupation.Text = "Occupation";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(120, 137);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(200, 20);
            this.txtOccupation.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 170);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 167);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 50);
            this.txtAddress.TabIndex = 9;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(12, 230);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(84, 13);
            this.lblContact.TabIndex = 10;
            this.lblContact.Text = "Contact Number";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(120, 227);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(150, 20);
            this.txtContact.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 257);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GuardianDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpGuardianType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuardianDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guardian Details";
            this.Load += new System.EventHandler(this.GuardianDetailsForm_Load);
            this.grpGuardianType.ResumeLayout(false);
            this.grpGuardianType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGuardianType;
        private System.Windows.Forms.RadioButton rdoFather;
        private System.Windows.Forms.RadioButton rdoMother;
        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStudentID;
private System.Windows.Forms.TextBox txtStudentID;

    }
}