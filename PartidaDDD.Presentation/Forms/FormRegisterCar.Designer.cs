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
            System.Windows.Forms.Label doorsLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label yearLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterCar));
            this.automaticCheckBox = new System.Windows.Forms.CheckBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.chassisTextBox = new System.Windows.Forms.TextBox();
            this.doorsTextBox = new System.Windows.Forms.TextBox();
            this.hydraulicSteeringCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.lblValidateName = new System.Windows.Forms.Label();
            this.lblValidateYear = new System.Windows.Forms.Label();
            this.lblValidateChassis = new System.Windows.Forms.Label();
            this.lblValidateBrand = new System.Windows.Forms.Label();
            this.lblValidateDoor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pbxCarImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.registerCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTextBox = new System.Windows.Forms.TextBox();
            brandLabel = new System.Windows.Forms.Label();
            chassisLabel = new System.Windows.Forms.Label();
            doorsLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(202, 188);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(40, 13);
            brandLabel.TabIndex = 3;
            brandLabel.Text = "Marca:";
            // 
            // chassisLabel
            // 
            chassisLabel.AutoSize = true;
            chassisLabel.Location = new System.Drawing.Point(32, 188);
            chassisLabel.Name = "chassisLabel";
            chassisLabel.Size = new System.Drawing.Size(46, 13);
            chassisLabel.TabIndex = 5;
            chassisLabel.Text = "Chassis:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Location = new System.Drawing.Point(324, 233);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new System.Drawing.Size(40, 13);
            doorsLabel.TabIndex = 7;
            doorsLabel.Text = "Portas:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(19, 128);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Nome:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(293, 128);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(29, 13);
            yearLabel.TabIndex = 13;
            yearLabel.Text = "Ano:";
            // 
            // automaticCheckBox
            // 
            this.automaticCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.registerCarBindingSource, "Automatic", true));
            this.automaticCheckBox.Location = new System.Drawing.Point(185, 228);
            this.automaticCheckBox.Name = "automaticCheckBox";
            this.automaticCheckBox.Size = new System.Drawing.Size(104, 24);
            this.automaticCheckBox.TabIndex = 6;
            this.automaticCheckBox.Text = "automático";
            this.automaticCheckBox.UseVisualStyleBackColor = true;
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(248, 185);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(184, 20);
            this.brandTextBox.TabIndex = 4;
            // 
            // chassisTextBox
            // 
            this.chassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Chassis", true));
            this.chassisTextBox.Location = new System.Drawing.Point(84, 185);
            this.chassisTextBox.Name = "chassisTextBox";
            this.chassisTextBox.Size = new System.Drawing.Size(104, 20);
            this.chassisTextBox.TabIndex = 3;
            // 
            // doorsTextBox
            // 
            this.doorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Doors", true));
            this.doorsTextBox.Location = new System.Drawing.Point(370, 230);
            this.doorsTextBox.Name = "doorsTextBox";
            this.doorsTextBox.Size = new System.Drawing.Size(31, 20);
            this.doorsTextBox.TabIndex = 7;
            // 
            // hydraulicSteeringCheckBox
            // 
            this.hydraulicSteeringCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.registerCarBindingSource, "HydraulicSteering", true));
            this.hydraulicSteeringCheckBox.Location = new System.Drawing.Point(35, 228);
            this.hydraulicSteeringCheckBox.Name = "hydraulicSteeringCheckBox";
            this.hydraulicSteeringCheckBox.Size = new System.Drawing.Size(120, 24);
            this.hydraulicSteeringCheckBox.TabIndex = 5;
            this.hydraulicSteeringCheckBox.Text = "direção hidráulica";
            this.hydraulicSteeringCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(63, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(328, 125);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(104, 20);
            this.yearTextBox.TabIndex = 2;
            // 
            // lblValidateName
            // 
            this.lblValidateName.AutoSize = true;
            this.lblValidateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateName.ForeColor = System.Drawing.Color.Red;
            this.lblValidateName.Location = new System.Drawing.Point(60, 148);
            this.lblValidateName.Name = "lblValidateName";
            this.lblValidateName.Size = new System.Drawing.Size(0, 13);
            this.lblValidateName.TabIndex = 14;
            // 
            // lblValidateYear
            // 
            this.lblValidateYear.AutoSize = true;
            this.lblValidateYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateYear.ForeColor = System.Drawing.Color.Red;
            this.lblValidateYear.Location = new System.Drawing.Point(324, 148);
            this.lblValidateYear.Name = "lblValidateYear";
            this.lblValidateYear.Size = new System.Drawing.Size(0, 13);
            this.lblValidateYear.TabIndex = 15;
            // 
            // lblValidateChassis
            // 
            this.lblValidateChassis.AutoSize = true;
            this.lblValidateChassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateChassis.ForeColor = System.Drawing.Color.Red;
            this.lblValidateChassis.Location = new System.Drawing.Point(81, 208);
            this.lblValidateChassis.Name = "lblValidateChassis";
            this.lblValidateChassis.Size = new System.Drawing.Size(0, 13);
            this.lblValidateChassis.TabIndex = 16;
            // 
            // lblValidateBrand
            // 
            this.lblValidateBrand.AutoSize = true;
            this.lblValidateBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateBrand.ForeColor = System.Drawing.Color.Red;
            this.lblValidateBrand.Location = new System.Drawing.Point(245, 208);
            this.lblValidateBrand.Name = "lblValidateBrand";
            this.lblValidateBrand.Size = new System.Drawing.Size(0, 13);
            this.lblValidateBrand.TabIndex = 17;
            // 
            // lblValidateDoor
            // 
            this.lblValidateDoor.AutoSize = true;
            this.lblValidateDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblValidateDoor.ForeColor = System.Drawing.Color.Red;
            this.lblValidateDoor.Location = new System.Drawing.Point(367, 253);
            this.lblValidateDoor.Name = "lblValidateDoor";
            this.lblValidateDoor.Size = new System.Drawing.Size(0, 13);
            this.lblValidateDoor.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PartidaDDD.Presentation.Properties.Resources.fiat_chrysler_automobiles_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 71);
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
            this.button1.Location = new System.Drawing.Point(610, 172);
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
            this.btnRegistrar.Location = new System.Drawing.Point(610, 112);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(118, 45);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pbxCarImage
            // 
            this.pbxCarImage.BackColor = System.Drawing.SystemColors.Control;
            this.pbxCarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCarImage.Location = new System.Drawing.Point(444, 112);
            this.pbxCarImage.Name = "pbxCarImage";
            this.pbxCarImage.Size = new System.Drawing.Size(160, 126);
            this.pbxCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCarImage.TabIndex = 20;
            this.pbxCarImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(559, 244);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(45, 23);
            this.btnLoadImage.TabIndex = 21;
            this.btnLoadImage.Text = "...";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // registerCarBindingSource
            // 
            this.registerCarBindingSource.DataSource = typeof(PartidaDDD.Domain.Commands.Inputs.RegisterCar);
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(444, 247);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(100, 20);
            this.imageTextBox.TabIndex = 23;
            // 
            // FormRegisterCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 295);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pbxCarImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblValidateDoor);
            this.Controls.Add(this.lblValidateBrand);
            this.Controls.Add(this.lblValidateChassis);
            this.Controls.Add(this.lblValidateYear);
            this.Controls.Add(this.lblValidateName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.automaticCheckBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(chassisLabel);
            this.Controls.Add(this.chassisTextBox);
            this.Controls.Add(doorsLabel);
            this.Controls.Add(this.doorsTextBox);
            this.Controls.Add(this.hydraulicSteeringCheckBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegisterCar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Concessionária Partida | Registrar Carro";
            this.Load += new System.EventHandler(this.FormRegisterCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerCarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.BindingSource registerCarBindingSource;
        private System.Windows.Forms.CheckBox automaticCheckBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox chassisTextBox;
        private System.Windows.Forms.TextBox doorsTextBox;
        private System.Windows.Forms.CheckBox hydraulicSteeringCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblValidateName;
        private System.Windows.Forms.Label lblValidateYear;
        private System.Windows.Forms.Label lblValidateChassis;
        private System.Windows.Forms.Label lblValidateBrand;
        private System.Windows.Forms.Label lblValidateDoor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxCarImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox imageTextBox;
    }
}