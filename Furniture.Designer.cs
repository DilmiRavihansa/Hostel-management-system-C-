namespace HostalMngm_System
{
    partial class Furniture
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
            this.labelFurnitureId = new System.Windows.Forms.Label();
            this.labelFurniture_type = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxFurnitureID = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxFurniture_Type = new System.Windows.Forms.ComboBox();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.panelFurnitures = new System.Windows.Forms.Panel();
            this.label_Exit = new System.Windows.Forms.Label();
            this.lblFurnitures = new System.Windows.Forms.Label();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.panelFurnitures.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFurnitureId
            // 
            this.labelFurnitureId.AutoSize = true;
            this.labelFurnitureId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFurnitureId.Location = new System.Drawing.Point(31, 177);
            this.labelFurnitureId.Name = "labelFurnitureId";
            this.labelFurnitureId.Size = new System.Drawing.Size(77, 16);
            this.labelFurnitureId.TabIndex = 0;
            this.labelFurnitureId.Text = "Furniture ID:";
            // 
            // labelFurniture_type
            // 
            this.labelFurniture_type.AutoSize = true;
            this.labelFurniture_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFurniture_type.Location = new System.Drawing.Point(31, 238);
            this.labelFurniture_type.Name = "labelFurniture_type";
            this.labelFurniture_type.Size = new System.Drawing.Size(96, 16);
            this.labelFurniture_type.TabIndex = 1;
            this.labelFurniture_type.Text = "Furniture Type:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(31, 300);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(58, 16);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Quantity:";
            // 
            // textBoxFurnitureID
            // 
            this.textBoxFurnitureID.Location = new System.Drawing.Point(138, 176);
            this.textBoxFurnitureID.Name = "textBoxFurnitureID";
            this.textBoxFurnitureID.Size = new System.Drawing.Size(121, 20);
            this.textBoxFurnitureID.TabIndex = 3;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(138, 299);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // comboBoxFurniture_Type
            // 
            this.comboBoxFurniture_Type.FormattingEnabled = true;
            this.comboBoxFurniture_Type.Items.AddRange(new object[] {
            "--select type--",
            "Chair",
            "Tables",
            "Sofa",
            "Shoe Rack",
            "Beds",
            "Cupboard"});
            this.comboBoxFurniture_Type.Location = new System.Drawing.Point(138, 237);
            this.comboBoxFurniture_Type.Name = "comboBoxFurniture_Type";
            this.comboBoxFurniture_Type.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFurniture_Type.TabIndex = 5;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(318, 120);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(438, 199);
            this.dataGridViewAll.TabIndex = 53;
            // 
            // panelFurnitures
            // 
            this.panelFurnitures.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelFurnitures.Controls.Add(this.label_Exit);
            this.panelFurnitures.Controls.Add(this.lblFurnitures);
            this.panelFurnitures.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFurnitures.Location = new System.Drawing.Point(0, 0);
            this.panelFurnitures.Name = "panelFurnitures";
            this.panelFurnitures.Size = new System.Drawing.Size(800, 78);
            this.panelFurnitures.TabIndex = 55;
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
            this.label_Exit.TabIndex = 78;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // lblFurnitures
            // 
            this.lblFurnitures.AutoSize = true;
            this.lblFurnitures.BackColor = System.Drawing.Color.MediumOrchid;
            this.lblFurnitures.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitures.Location = new System.Drawing.Point(30, 34);
            this.lblFurnitures.Name = "lblFurnitures";
            this.lblFurnitures.Size = new System.Drawing.Size(145, 24);
            this.lblFurnitures.TabIndex = 0;
            this.lblFurnitures.Text = "FURNITURES";
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.Location = new System.Drawing.Point(674, 362);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(63, 41);
            this.buttonViewAll.TabIndex = 77;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(608, 362);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 41);
            this.buttonDelete.TabIndex = 76;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(476, 362);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 41);
            this.buttonBack.TabIndex = 75;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(542, 362);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(60, 41);
            this.buttonUpdate.TabIndex = 74;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(410, 362);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 41);
            this.buttonClear.TabIndex = 73;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(344, 362);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 41);
            this.buttonSave.TabIndex = 72;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Furniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.panelFurnitures);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxFurniture_Type);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFurnitureID);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelFurniture_type);
            this.Controls.Add(this.labelFurnitureId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Furniture";
            this.Text = "FURNITURE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.panelFurnitures.ResumeLayout(false);
            this.panelFurnitures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFurnitureId;
        private System.Windows.Forms.Label labelFurniture_type;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxFurnitureID;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxFurniture_Type;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Panel panelFurnitures;
        private System.Windows.Forms.Label lblFurnitures;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label_Exit;
    }
}