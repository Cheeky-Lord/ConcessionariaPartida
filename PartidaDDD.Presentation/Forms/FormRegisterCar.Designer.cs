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
            System.Windows.Forms.Label automaticLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label chassisLabel;
            System.Windows.Forms.Label doorsLabel;
            System.Windows.Forms.Label hydraulicSteeringLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label yearLabel;
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.automaticCheckBox = new System.Windows.Forms.CheckBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.chassisTextBox = new System.Windows.Forms.TextBox();
            this.doorsTextBox = new System.Windows.Forms.TextBox();
            this.hydraulicSteeringCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.registerCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            automaticLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            chassisLabel = new System.Windows.Forms.Label();
            doorsLabel = new System.Windows.Forms.Label();
            hydraulicSteeringLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registerCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(713, 415);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // automaticLabel
            // 
            automaticLabel.AutoSize = true;
            automaticLabel.Location = new System.Drawing.Point(312, 80);
            automaticLabel.Name = "automaticLabel";
            automaticLabel.Size = new System.Drawing.Size(57, 13);
            automaticLabel.TabIndex = 1;
            automaticLabel.Text = "Automatic:";
            // 
            // automaticCheckBox
            // 
            this.automaticCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.registerCarBindingSource, "Automatic", true));
            this.automaticCheckBox.Location = new System.Drawing.Point(414, 75);
            this.automaticCheckBox.Name = "automaticCheckBox";
            this.automaticCheckBox.Size = new System.Drawing.Size(104, 24);
            this.automaticCheckBox.TabIndex = 2;
            this.automaticCheckBox.Text = "automático";
            this.automaticCheckBox.UseVisualStyleBackColor = true;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(312, 108);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(38, 13);
            brandLabel.TabIndex = 3;
            brandLabel.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(414, 105);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(104, 20);
            this.brandTextBox.TabIndex = 4;
            // 
            // chassisLabel
            // 
            chassisLabel.AutoSize = true;
            chassisLabel.Location = new System.Drawing.Point(312, 134);
            chassisLabel.Name = "chassisLabel";
            chassisLabel.Size = new System.Drawing.Size(46, 13);
            chassisLabel.TabIndex = 5;
            chassisLabel.Text = "Chassis:";
            // 
            // chassisTextBox
            // 
            this.chassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Chassis", true));
            this.chassisTextBox.Location = new System.Drawing.Point(414, 131);
            this.chassisTextBox.Name = "chassisTextBox";
            this.chassisTextBox.Size = new System.Drawing.Size(104, 20);
            this.chassisTextBox.TabIndex = 6;
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Location = new System.Drawing.Point(312, 160);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new System.Drawing.Size(38, 13);
            doorsLabel.TabIndex = 7;
            doorsLabel.Text = "Doors:";
            // 
            // doorsTextBox
            // 
            this.doorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Doors", true));
            this.doorsTextBox.Location = new System.Drawing.Point(414, 157);
            this.doorsTextBox.Name = "doorsTextBox";
            this.doorsTextBox.Size = new System.Drawing.Size(104, 20);
            this.doorsTextBox.TabIndex = 8;
            // 
            // hydraulicSteeringLabel
            // 
            hydraulicSteeringLabel.AutoSize = true;
            hydraulicSteeringLabel.Location = new System.Drawing.Point(312, 188);
            hydraulicSteeringLabel.Name = "hydraulicSteeringLabel";
            hydraulicSteeringLabel.Size = new System.Drawing.Size(97, 13);
            hydraulicSteeringLabel.TabIndex = 9;
            hydraulicSteeringLabel.Text = "Direção Hidráulica:";
            // 
            // hydraulicSteeringCheckBox
            // 
            this.hydraulicSteeringCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.registerCarBindingSource, "HydraulicSteering", true));
            this.hydraulicSteeringCheckBox.Location = new System.Drawing.Point(414, 183);
            this.hydraulicSteeringCheckBox.Name = "hydraulicSteeringCheckBox";
            this.hydraulicSteeringCheckBox.Size = new System.Drawing.Size(120, 24);
            this.hydraulicSteeringCheckBox.TabIndex = 10;
            this.hydraulicSteeringCheckBox.Text = "direção hidráulica";
            this.hydraulicSteeringCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(312, 216);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(414, 213);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(104, 20);
            this.nameTextBox.TabIndex = 12;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(312, 242);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 13;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerCarBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(414, 239);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(104, 20);
            this.yearTextBox.TabIndex = 14;
            // 
            // registerCarBindingSource
            // 
            this.registerCarBindingSource.DataSource = typeof(PartidaDDD.Domain.Commands.Inputs.RegisterCar);
            // 
            // FormRegisterCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(automaticLabel);
            this.Controls.Add(this.automaticCheckBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(chassisLabel);
            this.Controls.Add(this.chassisTextBox);
            this.Controls.Add(doorsLabel);
            this.Controls.Add(this.doorsTextBox);
            this.Controls.Add(hydraulicSteeringLabel);
            this.Controls.Add(this.hydraulicSteeringCheckBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FormRegisterCar";
            this.Text = "Concessionária Partida | Registrar Carro";
            this.Load += new System.EventHandler(this.FormRegisterCar_Load);
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
    }
}