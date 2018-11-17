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
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.functionComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.registerUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(25, 109);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 2;
            cPFLabel.Text = "CPF:";
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Location = new System.Drawing.Point(15, 192);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new System.Drawing.Size(42, 13);
            detailsLabel.TabIndex = 4;
            detailsLabel.Text = "Details:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(323, 72);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Location = new System.Drawing.Point(312, 109);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new System.Drawing.Size(46, 13);
            functionLabel.TabIndex = 8;
            functionLabel.Text = "Função:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(19, 72);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Nome:";
            nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(16, 137);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(41, 13);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Senha:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(333, 141);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(25, 13);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Tel:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(561, 141);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 16;
            rGLabel.Text = "RG:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(516, 109);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(34, 13);
            sexLabel.TabIndex = 18;
            sexLabel.Text = "Sexo:";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(61, 102);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(220, 20);
            this.cPFTextBox.TabIndex = 2;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Details", true));
            this.detailsTextBox.Location = new System.Drawing.Point(18, 208);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(696, 202);
            this.detailsTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(364, 69);
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
            this.functionComboBox.Location = new System.Drawing.Point(364, 102);
            this.functionComboBox.Name = "functionComboBox";
            this.functionComboBox.Size = new System.Drawing.Size(121, 21);
            this.functionComboBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(61, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(61, 134);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(216, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(364, 137);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneTextBox.TabIndex = 7;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerUserBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(593, 138);
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
            this.sexComboBox.Location = new System.Drawing.Point(556, 106);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(158, 21);
            this.sexComboBox.TabIndex = 6;
            // 
            // registerUserBindingSource
            // 
            this.registerUserBindingSource.DataSource = typeof(PartidaDDD.Domain.Commands.Inputs.RegisterUser);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Image = global::PartidaDDD.Presentation.Properties.Resources.sign_up30x30;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(735, 69);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 58);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PartidaDDD.Presentation.Properties.Resources.sign_up30x30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(735, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Editar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::PartidaDDD.Presentation.Properties.Resources.sign_up30x30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(735, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 58);
            this.button2.TabIndex = 20;
            this.button2.Text = "Deletar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(detailsLabel);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(functionLabel);
            this.Controls.Add(this.functionComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.btnRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegisterUser";
            this.Text = "Concessionária Partida | Cadastrar Usuario";
            this.Load += new System.EventHandler(this.FormRegisterUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}