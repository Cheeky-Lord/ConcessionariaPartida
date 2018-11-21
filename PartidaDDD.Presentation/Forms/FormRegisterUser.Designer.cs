namespace PartidaDDD.Presentation.Forms
{
    partial class FormRegisterUser
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
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label detailsLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label functionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label sexLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterUser));
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.registerUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.functionComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblValidateName = new System.Windows.Forms.Label();
            this.lblValidateCPF = new System.Windows.Forms.Label();
            this.lblValidatePassword = new System.Windows.Forms.Label();
            this.lblValidateEmail = new System.Windows.Forms.Label();
            this.lblValidateRG = new System.Windows.Forms.Label();
            this.lblValidateFunction = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            cPFLabel = new System.Windows.Forms.Label();
            detailsLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            functionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registerUserBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(20, 117);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 2;
            cPFLabel.Text = "CPF:";
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Location = new System.Drawing.Point(14, 19);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new System.Drawing.Size(52, 13);
            detailsLabel.TabIndex = 4;
            detailsLabel.Text = "Detalhes:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(315, 67);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "E-mail:";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Location = new System.Drawing.Point(307, 117);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new System.Drawing.Size(46, 13);
            functionLabel.TabIndex = 8;
            functionLabel.Text = "Função:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(14, 67);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Nome:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(11, 157);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(41, 13);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Senha:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(328, 161);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Telefone:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(556, 161);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 16;
            rGLabel.Text = "RG:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(511, 117);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(34, 13);
            sexLabel.TabIndex = 18;
            sexLabel.Text = "Sexo:";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(56, 110);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(220, 20);
            this.cPFTextBox.TabIndex = 2;
            // 
            // registerUserBindingSource
            // 
            this.registerUserBindingSource.DataSource = typeof(PartidaDDD.Domain.Commands.Inputs.RegisterUser);
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Details", true));
            this.detailsTextBox.Location = new System.Drawing.Point(17, 35);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(686, 121);
            this.detailsTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(359, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(350, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // functionComboBox
            // 
            this.functionComboBox.BackColor = System.Drawing.Color.White;
            this.functionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Function", true));
            this.functionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionComboBox.FormattingEnabled = true;
            this.functionComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "CEO",
            "CTO",
            "Caixa"});
            this.functionComboBox.Location = new System.Drawing.Point(359, 110);
            this.functionComboBox.Name = "functionComboBox";
            this.functionComboBox.Size = new System.Drawing.Size(121, 21);
            this.functionComboBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(56, 64);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(56, 154);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(216, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(386, 157);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneTextBox.TabIndex = 7;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(588, 158);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(121, 20);
            this.rGTextBox.TabIndex = 8;
            // 
            // sexComboBox
            // 
            this.sexComboBox.BackColor = System.Drawing.Color.White;
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Sex", true));
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexComboBox.Location = new System.Drawing.Point(551, 114);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(158, 21);
            this.sexComboBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::PartidaDDD.Presentation.Properties.Resources.delete_286553;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(751, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 58);
            this.button2.TabIndex = 20;
            this.button2.Text = "Deletar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PartidaDDD.Presentation.Properties.Resources.Edit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(751, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Editar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = global::PartidaDDD.Presentation.Properties.Resources.sign_up30x30;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(751, 34);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 58);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblValidateName
            // 
            this.lblValidateName.AutoSize = true;
            this.lblValidateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateName.ForeColor = System.Drawing.Color.Red;
            this.lblValidateName.Location = new System.Drawing.Point(53, 87);
            this.lblValidateName.Name = "lblValidateName";
            this.lblValidateName.Size = new System.Drawing.Size(0, 13);
            this.lblValidateName.TabIndex = 21;
            // 
            // lblValidateCPF
            // 
            this.lblValidateCPF.AutoSize = true;
            this.lblValidateCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateCPF.ForeColor = System.Drawing.Color.Red;
            this.lblValidateCPF.Location = new System.Drawing.Point(53, 133);
            this.lblValidateCPF.Name = "lblValidateCPF";
            this.lblValidateCPF.Size = new System.Drawing.Size(0, 13);
            this.lblValidateCPF.TabIndex = 22;
            // 
            // lblValidatePassword
            // 
            this.lblValidatePassword.AutoSize = true;
            this.lblValidatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidatePassword.ForeColor = System.Drawing.Color.Red;
            this.lblValidatePassword.Location = new System.Drawing.Point(53, 177);
            this.lblValidatePassword.Name = "lblValidatePassword";
            this.lblValidatePassword.Size = new System.Drawing.Size(0, 13);
            this.lblValidatePassword.TabIndex = 23;
            // 
            // lblValidateEmail
            // 
            this.lblValidateEmail.AutoSize = true;
            this.lblValidateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateEmail.ForeColor = System.Drawing.Color.Red;
            this.lblValidateEmail.Location = new System.Drawing.Point(356, 87);
            this.lblValidateEmail.Name = "lblValidateEmail";
            this.lblValidateEmail.Size = new System.Drawing.Size(0, 13);
            this.lblValidateEmail.TabIndex = 24;
            // 
            // lblValidateRG
            // 
            this.lblValidateRG.AutoSize = true;
            this.lblValidateRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateRG.ForeColor = System.Drawing.Color.Red;
            this.lblValidateRG.Location = new System.Drawing.Point(585, 181);
            this.lblValidateRG.Name = "lblValidateRG";
            this.lblValidateRG.Size = new System.Drawing.Size(0, 13);
            this.lblValidateRG.TabIndex = 25;
            // 
            // lblValidateFunction
            // 
            this.lblValidateFunction.AutoSize = true;
            this.lblValidateFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateFunction.ForeColor = System.Drawing.Color.Red;
            this.lblValidateFunction.Location = new System.Drawing.Point(356, 134);
            this.lblValidateFunction.Name = "lblValidateFunction";
            this.lblValidateFunction.Size = new System.Drawing.Size(0, 13);
            this.lblValidateFunction.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 391);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.lblValidateFunction);
            this.tabPage1.Controls.Add(this.sexComboBox);
            this.tabPage1.Controls.Add(this.lblValidateRG);
            this.tabPage1.Controls.Add(sexLabel);
            this.tabPage1.Controls.Add(this.lblValidateEmail);
            this.tabPage1.Controls.Add(this.rGTextBox);
            this.tabPage1.Controls.Add(this.lblValidatePassword);
            this.tabPage1.Controls.Add(rGLabel);
            this.tabPage1.Controls.Add(this.lblValidateCPF);
            this.tabPage1.Controls.Add(this.phoneTextBox);
            this.tabPage1.Controls.Add(this.lblValidateName);
            this.tabPage1.Controls.Add(phoneLabel);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(passwordLabel);
            this.tabPage1.Controls.Add(cPFLabel);
            this.tabPage1.Controls.Add(nameLabel);
            this.tabPage1.Controls.Add(this.cPFTextBox);
            this.tabPage1.Controls.Add(this.functionComboBox);
            this.tabPage1.Controls.Add(functionLabel);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(emailLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.detailsTextBox);
            this.tabPage2.Controls.Add(detailsLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informações adicionais";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concessionária Partida | Cadastrar Usuário";
            this.Load += new System.EventHandler(this.FormRegisterUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerUserBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.BindingSource registerUserBindingSource;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox functionComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblValidateName;
        private System.Windows.Forms.Label lblValidateCPF;
        private System.Windows.Forms.Label lblValidatePassword;
        private System.Windows.Forms.Label lblValidateEmail;
        private System.Windows.Forms.Label lblValidateRG;
        private System.Windows.Forms.Label lblValidateFunction;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}