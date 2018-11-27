namespace PartidaDDD.Presentation.Forms
{
    partial class FormRegisterCar
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
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label chassisLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label doorsLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label steeringLabel;
            System.Windows.Forms.Label transmissionLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label originLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterCar));
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.chassisTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.eletronicWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.steeringComboBox = new System.Windows.Forms.ComboBox();
            this.transmissionComboBox = new System.Windows.Forms.ComboBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doorsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.pbxCarImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.registerCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            brandLabel = new System.Windows.Forms.Label();
            chassisLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            doorsLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            steeringLabel = new System.Windows.Forms.Label();
            transmissionLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            originLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(10, 65);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(40, 13);
            brandLabel.TabIndex = 21;
            brandLabel.Text = "Marca:";
            // 
            // chassisLabel
            // 
            chassisLabel.AutoSize = true;
            chassisLabel.Location = new System.Drawing.Point(233, 69);
            chassisLabel.Name = "chassisLabel";
            chassisLabel.Size = new System.Drawing.Size(46, 13);
            chassisLabel.TabIndex = 23;
            chassisLabel.Text = "Chassis:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(216, 60);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(26, 13);
            colorLabel.TabIndex = 25;
            colorLabel.Text = "Cor:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Location = new System.Drawing.Point(160, 25);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new System.Drawing.Size(70, 13);
            doorsLabel.TabIndex = 27;
            doorsLabel.Text = "Nº de Portas:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(8, 25);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(45, 13);
            modelLabel.TabIndex = 33;
            modelLabel.Text = "Modelo:";
            // 
            // steeringLabel
            // 
            steeringLabel.AutoSize = true;
            steeringLabel.Location = new System.Drawing.Point(11, 26);
            steeringLabel.Name = "steeringLabel";
            steeringLabel.Size = new System.Drawing.Size(47, 13);
            steeringLabel.TabIndex = 37;
            steeringLabel.Text = "Direção:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Location = new System.Drawing.Point(11, 57);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new System.Drawing.Size(69, 13);
            transmissionLabel.TabIndex = 39;
            transmissionLabel.Text = "Transmissão:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(283, 25);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(29, 13);
            yearLabel.TabIndex = 41;
            yearLabel.Text = "Ano:";
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new System.Drawing.Point(237, 25);
            originLabel.Name = "originLabel";
            originLabel.Size = new System.Drawing.Size(43, 13);
            originLabel.TabIndex = 34;
            originLabel.Text = "Origem:";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(137, 157);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(45, 23);
            this.btnLoadImage.TabIndex = 21;
            this.btnLoadImage.Text = "...";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // brandComboBox
            // 
            this.brandComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Brand", true));
            this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Items.AddRange(new object[] {
            "FIAT",
            "VOLKSWAGEN",
            "TOYOTA",
            "HYUNDAI",
            "CHEVROLET",
            "FORD",
            "KIA",
            "BMW",
            "JEEP"});
            this.brandComboBox.Location = new System.Drawing.Point(59, 62);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandComboBox.TabIndex = 22;
            // 
            // chassisTextBox
            // 
            this.chassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Chassis", true));
            this.chassisTextBox.Location = new System.Drawing.Point(287, 64);
            this.chassisTextBox.Name = "chassisTextBox";
            this.chassisTextBox.Size = new System.Drawing.Size(139, 20);
            this.chassisTextBox.TabIndex = 24;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(255, 58);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(91, 20);
            this.colorTextBox.TabIndex = 26;
            // 
            // eletronicWindowCheckBox
            // 
            this.eletronicWindowCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.registerCarBindingSource, "EletronicWindow", true));
            this.eletronicWindowCheckBox.Location = new System.Drawing.Point(255, 26);
            this.eletronicWindowCheckBox.Name = "eletronicWindowCheckBox";
            this.eletronicWindowCheckBox.Size = new System.Drawing.Size(121, 24);
            this.eletronicWindowCheckBox.TabIndex = 30;
            this.eletronicWindowCheckBox.Text = "Vidro Eletrico";
            this.eletronicWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(59, 22);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(121, 20);
            this.modelTextBox.TabIndex = 34;
            // 
            // steeringComboBox
            // 
            this.steeringComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Steering", true));
            this.steeringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.steeringComboBox.FormattingEnabled = true;
            this.steeringComboBox.Items.AddRange(new object[] {
            "AUTOMÁTICA",
            "SEMI-AUTOMÁTICA",
            "MECÂNICA"});
            this.steeringComboBox.Location = new System.Drawing.Point(81, 57);
            this.steeringComboBox.Name = "steeringComboBox";
            this.steeringComboBox.Size = new System.Drawing.Size(121, 21);
            this.steeringComboBox.TabIndex = 38;
            // 
            // transmissionComboBox
            // 
            this.transmissionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Transmission", true));
            this.transmissionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmissionComboBox.FormattingEnabled = true;
            this.transmissionComboBox.Items.AddRange(new object[] {
            "ELÉTRICA",
            "HIDRÁULICA",
            "MECÂNICA"});
            this.transmissionComboBox.Location = new System.Drawing.Point(81, 29);
            this.transmissionComboBox.Name = "transmissionComboBox";
            this.transmissionComboBox.Size = new System.Drawing.Size(121, 21);
            this.transmissionComboBox.TabIndex = 40;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(314, 22);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(42, 20);
            this.yearTextBox.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.doorsComboBox);
            this.groupBox1.Controls.Add(this.yearTextBox);
            this.groupBox1.Controls.Add(yearLabel);
            this.groupBox1.Controls.Add(doorsLabel);
            this.groupBox1.Location = new System.Drawing.Point(19, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 66);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // doorsComboBox
            // 
            this.doorsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Doors", true));
            this.doorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorsComboBox.FormattingEnabled = true;
            this.doorsComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.doorsComboBox.Location = new System.Drawing.Point(236, 21);
            this.doorsComboBox.Name = "doorsComboBox";
            this.doorsComboBox.Size = new System.Drawing.Size(34, 21);
            this.doorsComboBox.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(originLabel);
            this.groupBox2.Controls.Add(this.originComboBox);
            this.groupBox2.Controls.Add(this.modelTextBox);
            this.groupBox2.Controls.Add(brandLabel);
            this.groupBox2.Controls.Add(this.brandComboBox);
            this.groupBox2.Controls.Add(modelLabel);
            this.groupBox2.Controls.Add(chassisLabel);
            this.groupBox2.Controls.Add(this.chassisTextBox);
            this.groupBox2.Location = new System.Drawing.Point(19, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 104);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRINCIPAL";
            // 
            // originComboBox
            // 
            this.originComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Origin", true));
            this.originComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Items.AddRange(new object[] {
            "NOVOS",
            "SEMI-NOVOS",
            "USADOS",
            "IMOBILIADOS"});
            this.originComboBox.Location = new System.Drawing.Point(286, 22);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(121, 21);
            this.originComboBox.TabIndex = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(steeringLabel);
            this.groupBox3.Controls.Add(this.colorTextBox);
            this.groupBox3.Controls.Add(this.steeringComboBox);
            this.groupBox3.Controls.Add(this.transmissionComboBox);
            this.groupBox3.Controls.Add(this.eletronicWindowCheckBox);
            this.groupBox3.Controls.Add(colorLabel);
            this.groupBox3.Controls.Add(transmissionLabel);
            this.groupBox3.Location = new System.Drawing.Point(19, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 100);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.imageTextBox);
            this.groupBox4.Controls.Add(this.pbxCarImage);
            this.groupBox4.Controls.Add(this.btnLoadImage);
            this.groupBox4.Location = new System.Drawing.Point(532, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 188);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IMAGEM";
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(22, 159);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(109, 20);
            this.imageTextBox.TabIndex = 47;
            // 
            // pbxCarImage
            // 
            this.pbxCarImage.BackColor = System.Drawing.SystemColors.Control;
            this.pbxCarImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCarImage.Location = new System.Drawing.Point(22, 19);
            this.pbxCarImage.Name = "pbxCarImage";
            this.pbxCarImage.Size = new System.Drawing.Size(160, 126);
            this.pbxCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCarImage.TabIndex = 20;
            this.pbxCarImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PartidaDDD.Presentation.Properties.Resources.FCA_Logo_Marcas;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PartidaDDD.Presentation.Properties.Resources.Edit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(610, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Editar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = global::PartidaDDD.Presentation.Properties.Resources.sign_up30x30;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(487, 349);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(118, 45);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // registerCarBindingSource
            // 
            this.registerCarBindingSource.DataSource = typeof(PartidaDDD.Domain.Commands.Inputs.RegisterCar);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(5, 25);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(38, 13);
            priceLabel.TabIndex = 43;
            priceLabel.Text = "Preço:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(45, 22);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 44;
            // 
            // FormRegisterCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 419);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegisterCar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Concessionária Partida | Registrar Carro";
            this.Load += new System.EventHandler(this.FormRegisterCar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerCarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.BindingSource registerCarBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxCarImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.TextBox chassisTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.CheckBox eletronicWindowCheckBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.ComboBox steeringComboBox;
        private System.Windows.Forms.ComboBox transmissionComboBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox doorsComboBox;
        private System.Windows.Forms.ComboBox originComboBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}