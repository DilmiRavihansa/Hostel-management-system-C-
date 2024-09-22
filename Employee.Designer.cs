namespace HostalMngm_System
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUser_Id = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.label_Exit = new System.Windows.Forms.Label();
            this.lblEmployeeDetails = new System.Windows.Forms.Label();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelMsgContact = new System.Windows.Forms.Label();
            this.dataGridViewPost = new System.Windows.Forms.DataGridView();
            this.dataGridViewContact = new System.Windows.Forms.DataGridView();
            this.dataGridViewUserEmployee = new System.Windows.Forms.DataGridView();
            this.panelPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Items.AddRange(new object[] {
            "--Select Type--",
            "Manager",
            "Clerk",
            "Staff"});
            this.comboBoxPost.Location = new System.Drawing.Point(110, 404);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPost.TabIndex = 34;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(110, 328);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(121, 20);
            this.textBoxContact.TabIndex = 33;
            this.textBoxContact.TextChanged += new System.EventHandler(this.textBoxContact_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(110, 293);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddress.TabIndex = 32;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(110, 212);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 31;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(110, 175);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(121, 20);
            this.textBoxLname.TabIndex = 30;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(110, 137);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(121, 20);
            this.textBoxFname.TabIndex = 29;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(110, 98);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserID.TabIndex = 28;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.Location = new System.Drawing.Point(27, 405);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(37, 16);
            this.labelPost.TabIndex = 27;
            this.labelPost.Text = "Post:";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(27, 329);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(76, 16);
            this.labelContact.TabIndex = 26;
            this.labelContact.Text = "Contact No:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(27, 294);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(61, 16);
            this.labelAddress.TabIndex = 25;
            this.labelAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(27, 213);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "Email:";
            // 
            // labelUser_Id
            // 
            this.labelUser_Id.AutoSize = true;
            this.labelUser_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser_Id.Location = new System.Drawing.Point(27, 99);
            this.labelUser_Id.Name = "labelUser_Id";
            this.labelUser_Id.Size = new System.Drawing.Size(55, 16);
            this.labelUser_Id.TabIndex = 23;
            this.labelUser_Id.Text = "User ID:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(27, 176);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(75, 16);
            this.labelLname.TabIndex = 22;
            this.labelLname.Text = "Last Name:";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(27, 138);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(75, 16);
            this.labelFname.TabIndex = 21;
            this.labelFname.Text = "First Name:";
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(168, 370);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_female.TabIndex = 41;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(106, 370);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_male.TabIndex = 40;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(27, 371);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(55, 16);
            this.labelGender.TabIndex = 39;
            this.labelGender.Text = "Gender:";
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNo.Location = new System.Drawing.Point(27, 255);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(68, 16);
            this.labelRoomNo.TabIndex = 42;
            this.labelRoomNo.Text = "Room No:";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Location = new System.Drawing.Point(110, 254);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxRoomNo.TabIndex = 43;
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelPayment.Controls.Add(this.label_Exit);
            this.panelPayment.Controls.Add(this.lblEmployeeDetails);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayment.Location = new System.Drawing.Point(0, 0);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(800, 78);
            this.panelPayment.TabIndex = 53;
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.GhostWhite;
            this.label_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.Red;
            this.label_Exit.Location = new System.Drawing.Point(779, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(21, 20);
            this.label_Exit.TabIndex = 5;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // lblEmployeeDetails
            // 
            this.lblEmployeeDetails.AutoSize = true;
            this.lblEmployeeDetails.BackColor = System.Drawing.Color.MediumOrchid;
            this.lblEmployeeDetails.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDetails.Location = new System.Drawing.Point(30, 34);
            this.lblEmployeeDetails.Name = "lblEmployeeDetails";
            this.lblEmployeeDetails.Size = new System.Drawing.Size(223, 24);
            this.lblEmployeeDetails.TabIndex = 0;
            this.lblEmployeeDetails.Text = "EMPLOYEE DETAILS";
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.Location = new System.Drawing.Point(642, 371);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(63, 41);
            this.buttonViewAll.TabIndex = 71;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(576, 371);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 41);
            this.buttonDelete.TabIndex = 70;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(444, 371);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 41);
            this.buttonBack.TabIndex = 69;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(510, 371);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(60, 41);
            this.buttonUpdate.TabIndex = 68;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(378, 371);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 41);
            this.buttonClear.TabIndex = 67;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(312, 371);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 41);
            this.buttonSave.TabIndex = 66;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelMsgContact
            // 
            this.labelMsgContact.AutoSize = true;
            this.labelMsgContact.ForeColor = System.Drawing.Color.Red;
            this.labelMsgContact.Location = new System.Drawing.Point(249, 332);
            this.labelMsgContact.Name = "labelMsgContact";
            this.labelMsgContact.Size = new System.Drawing.Size(15, 13);
            this.labelMsgContact.TabIndex = 72;
            this.labelMsgContact.Text = "**";
            // 
            // dataGridViewPost
            // 
            this.dataGridViewPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPost.Location = new System.Drawing.Point(540, 252);
            this.dataGridViewPost.Name = "dataGridViewPost";
            this.dataGridViewPost.Size = new System.Drawing.Size(199, 89);
            this.dataGridViewPost.TabIndex = 75;
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContact.Location = new System.Drawing.Point(302, 252);
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.Size = new System.Drawing.Size(212, 89);
            this.dataGridViewContact.TabIndex = 74;
            // 
            // dataGridViewUserEmployee
            // 
            this.dataGridViewUserEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserEmployee.Location = new System.Drawing.Point(302, 104);
            this.dataGridViewUserEmployee.Name = "dataGridViewUserEmployee";
            this.dataGridViewUserEmployee.Size = new System.Drawing.Size(437, 128);
            this.dataGridViewUserEmployee.TabIndex = 73;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.dataGridViewPost);
            this.Controls.Add(this.dataGridViewContact);
            this.Controls.Add(this.dataGridViewUserEmployee);
            this.Controls.Add(this.labelMsgContact);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.labelRoomNo);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUser_Id);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "EMPLOYEE";
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUser_Id;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label lblEmployeeDetails;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelMsgContact;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.DataGridView dataGridViewPost;
        private System.Windows.Forms.DataGridView dataGridViewContact;
        private System.Windows.Forms.DataGridView dataGridViewUserEmployee;
    }
}