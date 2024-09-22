namespace HostalMngm_System
{
    partial class Rooms
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
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomDescription = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.textBoxRoomDescription = new System.Windows.Forms.TextBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelHostalID = new System.Windows.Forms.Label();
            this.textBoxHostal_Id = new System.Windows.Forms.TextBox();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.label_Exit = new System.Windows.Forms.Label();
            this.lblRooms = new System.Windows.Forms.Label();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.panelRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNo.Location = new System.Drawing.Point(27, 129);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(68, 16);
            this.labelRoomNo.TabIndex = 0;
            this.labelRoomNo.Text = "Room No:";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.Location = new System.Drawing.Point(27, 173);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(82, 16);
            this.labelRoomType.TabIndex = 1;
            this.labelRoomType.Text = "Room Type:";
            // 
            // labelRoomDescription
            // 
            this.labelRoomDescription.AutoSize = true;
            this.labelRoomDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomDescription.Location = new System.Drawing.Point(27, 242);
            this.labelRoomDescription.Name = "labelRoomDescription";
            this.labelRoomDescription.Size = new System.Drawing.Size(78, 32);
            this.labelRoomDescription.TabIndex = 2;
            this.labelRoomDescription.Text = "Room\r\nDescription:";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Location = new System.Drawing.Point(133, 122);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxRoomNo.TabIndex = 7;
            // 
            // textBoxRoomDescription
            // 
            this.textBoxRoomDescription.Location = new System.Drawing.Point(133, 223);
            this.textBoxRoomDescription.Multiline = true;
            this.textBoxRoomDescription.Name = "textBoxRoomDescription";
            this.textBoxRoomDescription.Size = new System.Drawing.Size(121, 68);
            this.textBoxRoomDescription.TabIndex = 9;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "--Select Type--",
            "Single Non A/C",
            "Single A/C",
            "Double Non A/C",
            "Double A/C",
            "Triple Non A/C",
            "Triple A/C"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(133, 172);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoomType.TabIndex = 10;
            // 
            // labelHostalID
            // 
            this.labelHostalID.AutoSize = true;
            this.labelHostalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHostalID.Location = new System.Drawing.Point(27, 336);
            this.labelHostalID.Name = "labelHostalID";
            this.labelHostalID.Size = new System.Drawing.Size(65, 16);
            this.labelHostalID.TabIndex = 11;
            this.labelHostalID.Text = "Hostal ID:";
            // 
            // textBoxHostal_Id
            // 
            this.textBoxHostal_Id.Location = new System.Drawing.Point(133, 335);
            this.textBoxHostal_Id.Name = "textBoxHostal_Id";
            this.textBoxHostal_Id.Size = new System.Drawing.Size(121, 20);
            this.textBoxHostal_Id.TabIndex = 12;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(313, 113);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(438, 199);
            this.dataGridViewAll.TabIndex = 52;
            // 
            // panelRooms
            // 
            this.panelRooms.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelRooms.Controls.Add(this.label_Exit);
            this.panelRooms.Controls.Add(this.lblRooms);
            this.panelRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRooms.Location = new System.Drawing.Point(0, 0);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(800, 78);
            this.panelRooms.TabIndex = 54;
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
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.BackColor = System.Drawing.Color.MediumOrchid;
            this.lblRooms.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(30, 34);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(88, 24);
            this.lblRooms.TabIndex = 0;
            this.lblRooms.Text = "ROOMS";
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.Location = new System.Drawing.Point(668, 348);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(63, 41);
            this.buttonViewAll.TabIndex = 60;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(601, 348);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 41);
            this.buttonDelete.TabIndex = 59;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(469, 348);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 41);
            this.buttonBack.TabIndex = 58;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(535, 348);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(60, 41);
            this.buttonUpdate.TabIndex = 57;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(403, 348);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 41);
            this.buttonClear.TabIndex = 56;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(337, 348);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 41);
            this.buttonSave.TabIndex = 55;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.textBoxHostal_Id);
            this.Controls.Add(this.labelHostalID);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.textBoxRoomDescription);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.labelRoomDescription);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.labelRoomNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.Text = "ROOMS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelRoomDescription;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.TextBox textBoxRoomDescription;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label labelHostalID;
        private System.Windows.Forms.TextBox textBoxHostal_Id;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label_Exit;
    }
}