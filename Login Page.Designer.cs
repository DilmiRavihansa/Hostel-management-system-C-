namespace HostalMngm_System
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPws = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPws = new System.Windows.Forms.TextBox();
            this.buttonSign_In = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxAdminId = new System.Windows.Forms.TextBox();
            this.labelAdminID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(113, 172);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 16);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name:";
            // 
            // labelPws
            // 
            this.labelPws.AutoSize = true;
            this.labelPws.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPws.Location = new System.Drawing.Point(113, 211);
            this.labelPws.Name = "labelPws";
            this.labelPws.Size = new System.Drawing.Size(70, 16);
            this.labelPws.TabIndex = 1;
            this.labelPws.Text = "Password:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(227, 169);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 2;
            // 
            // textBoxPws
            // 
            this.textBoxPws.Location = new System.Drawing.Point(227, 208);
            this.textBoxPws.Name = "textBoxPws";
            this.textBoxPws.Size = new System.Drawing.Size(100, 20);
            this.textBoxPws.TabIndex = 4;
            this.textBoxPws.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPws_Validating);
            // 
            // buttonSign_In
            // 
            this.buttonSign_In.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonSign_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSign_In.Location = new System.Drawing.Point(102, 267);
            this.buttonSign_In.Name = "buttonSign_In";
            this.buttonSign_In.Size = new System.Drawing.Size(75, 37);
            this.buttonSign_In.TabIndex = 4;
            this.buttonSign_In.Text = "Sign In";
            this.buttonSign_In.UseVisualStyleBackColor = false;
            this.buttonSign_In.Click += new System.EventHandler(this.buttonSign_In_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(207, 267);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 37);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxAdminId
            // 
            this.textBoxAdminId.Location = new System.Drawing.Point(227, 127);
            this.textBoxAdminId.Name = "textBoxAdminId";
            this.textBoxAdminId.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdminId.TabIndex = 8;
            // 
            // labelAdminID
            // 
            this.labelAdminID.AutoSize = true;
            this.labelAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminID.Location = new System.Drawing.Point(113, 130);
            this.labelAdminID.Name = "labelAdminID";
            this.labelAdminID.Size = new System.Drawing.Size(64, 16);
            this.labelAdminID.TabIndex = 7;
            this.labelAdminID.Text = "Admin ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 75);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN ";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(314, 267);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 37);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxAdminId);
            this.Controls.Add(this.labelAdminID);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSign_In);
            this.Controls.Add(this.textBoxPws);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPws);
            this.Controls.Add(this.labelUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.Text = "LOGIN PAGE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPws;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPws;
        private System.Windows.Forms.Button buttonSign_In;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxAdminId;
        private System.Windows.Forms.Label labelAdminID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
    }
}

