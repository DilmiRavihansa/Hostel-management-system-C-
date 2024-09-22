namespace HostalMngm_System
{
    partial class Payment
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
            this.lblPayId = new System.Windows.Forms.Label();
            this.labelPayType = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelPayDesc = new System.Windows.Forms.Label();
            this.textBoxPayID = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPayDesc = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.radioButtonCard = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.labelAdmin_ID = new System.Windows.Forms.Label();
            this.textBoxAdmin_ID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.label_Exit = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.labelMsgPayAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.panelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPayId
            // 
            this.lblPayId.AutoSize = true;
            this.lblPayId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayId.Location = new System.Drawing.Point(31, 124);
            this.lblPayId.Name = "lblPayId";
            this.lblPayId.Size = new System.Drawing.Size(79, 16);
            this.lblPayId.TabIndex = 0;
            this.lblPayId.Text = "Payment ID:";
            // 
            // labelPayType
            // 
            this.labelPayType.AutoSize = true;
            this.labelPayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayType.Location = new System.Drawing.Point(31, 164);
            this.labelPayType.Name = "labelPayType";
            this.labelPayType.Size = new System.Drawing.Size(98, 16);
            this.labelPayType.TabIndex = 1;
            this.labelPayType.Text = "Payment Type:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(31, 214);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(58, 16);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount :";
            // 
            // labelPayDesc
            // 
            this.labelPayDesc.AutoSize = true;
            this.labelPayDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayDesc.Location = new System.Drawing.Point(31, 275);
            this.labelPayDesc.Name = "labelPayDesc";
            this.labelPayDesc.Size = new System.Drawing.Size(132, 32);
            this.labelPayDesc.TabIndex = 3;
            this.labelPayDesc.Text = "Payment                        \r\n Description:";
            // 
            // textBoxPayID
            // 
            this.textBoxPayID.Location = new System.Drawing.Point(135, 123);
            this.textBoxPayID.Name = "textBoxPayID";
            this.textBoxPayID.Size = new System.Drawing.Size(121, 20);
            this.textBoxPayID.TabIndex = 4;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(135, 214);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(121, 20);
            this.textBoxAmount.TabIndex = 5;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // textBoxPayDesc
            // 
            this.textBoxPayDesc.Location = new System.Drawing.Point(135, 263);
            this.textBoxPayDesc.Multiline = true;
            this.textBoxPayDesc.Name = "textBoxPayDesc";
            this.textBoxPayDesc.Size = new System.Drawing.Size(121, 57);
            this.textBoxPayDesc.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(338, 340);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 41);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(404, 340);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 41);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(536, 340);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(60, 41);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(470, 340);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 41);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCard.Location = new System.Drawing.Point(135, 164);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(51, 19);
            this.radioButtonCard.TabIndex = 12;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Card";
            this.radioButtonCard.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCash.Location = new System.Drawing.Point(203, 164);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(53, 19);
            this.radioButtonCash.TabIndex = 13;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // labelAdmin_ID
            // 
            this.labelAdmin_ID.AutoSize = true;
            this.labelAdmin_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin_ID.Location = new System.Drawing.Point(31, 361);
            this.labelAdmin_ID.Name = "labelAdmin_ID";
            this.labelAdmin_ID.Size = new System.Drawing.Size(64, 16);
            this.labelAdmin_ID.TabIndex = 14;
            this.labelAdmin_ID.Text = "Admin ID:";
            // 
            // textBoxAdmin_ID
            // 
            this.textBoxAdmin_ID.Location = new System.Drawing.Point(135, 360);
            this.textBoxAdmin_ID.Name = "textBoxAdmin_ID";
            this.textBoxAdmin_ID.Size = new System.Drawing.Size(121, 20);
            this.textBoxAdmin_ID.TabIndex = 15;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(602, 340);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 41);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(310, 108);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(438, 199);
            this.dataGridViewAll.TabIndex = 17;
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.Location = new System.Drawing.Point(668, 340);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(63, 41);
            this.buttonViewAll.TabIndex = 18;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelPayment.Controls.Add(this.label_Exit);
            this.panelPayment.Controls.Add(this.lblPayment);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayment.Location = new System.Drawing.Point(0, 0);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(800, 78);
            this.panelPayment.TabIndex = 19;
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
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.MediumOrchid;
            this.lblPayment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(30, 34);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(111, 24);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "PAYMENT";
            // 
            // labelMsgPayAmount
            // 
            this.labelMsgPayAmount.AutoSize = true;
            this.labelMsgPayAmount.ForeColor = System.Drawing.Color.Red;
            this.labelMsgPayAmount.Location = new System.Drawing.Point(262, 221);
            this.labelMsgPayAmount.Name = "labelMsgPayAmount";
            this.labelMsgPayAmount.Size = new System.Drawing.Size(15, 13);
            this.labelMsgPayAmount.TabIndex = 63;
            this.labelMsgPayAmount.Text = "**";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMsgPayAmount);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxAdmin_ID);
            this.Controls.Add(this.labelAdmin_ID);
            this.Controls.Add(this.radioButtonCash);
            this.Controls.Add(this.radioButtonCard);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPayDesc);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxPayID);
            this.Controls.Add(this.labelPayDesc);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelPayType);
            this.Controls.Add(this.lblPayId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Text = "PAYMENT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayId;
        private System.Windows.Forms.Label labelPayType;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelPayDesc;
        private System.Windows.Forms.TextBox textBoxPayID;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPayDesc;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RadioButton radioButtonCard;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Label labelAdmin_ID;
        private System.Windows.Forms.TextBox textBoxAdmin_ID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label labelMsgPayAmount;
        private System.Windows.Forms.Label label_Exit;
    }
}