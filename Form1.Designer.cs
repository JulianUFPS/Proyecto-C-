namespace Form_Programacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecargarGasolinera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidadGasolinera = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.btnAnadirFila = new System.Windows.Forms.Button();
            this.btnRecargarGasolinera = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRecargarVehiculo = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGalonesVehiculo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(179, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gasolinera";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recargar a gasolinera";
            // 
            // txtRecargarGasolinera
            // 
            this.txtRecargarGasolinera.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtRecargarGasolinera.Location = new System.Drawing.Point(25, 104);
            this.txtRecargarGasolinera.Name = "txtRecargarGasolinera";
            this.txtRecargarGasolinera.Size = new System.Drawing.Size(139, 20);
            this.txtRecargarGasolinera.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad en gasolinera:";
            // 
            // lblCantidadGasolinera
            // 
            this.lblCantidadGasolinera.AutoSize = true;
            this.lblCantidadGasolinera.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadGasolinera.Location = new System.Drawing.Point(189, 104);
            this.lblCantidadGasolinera.Name = "lblCantidadGasolinera";
            this.lblCantidadGasolinera.Size = new System.Drawing.Size(16, 15);
            this.lblCantidadGasolinera.TabIndex = 4;
            this.lblCantidadGasolinera.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 28);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vehículo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtPlaca.Location = new System.Drawing.Point(667, 53);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 6;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Placa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tipo de vehiculo";
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(667, 79);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbTipoVehiculo.TabIndex = 9;
            this.cbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAnadirFila
            // 
            this.btnAnadirFila.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAnadirFila.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnadirFila.Location = new System.Drawing.Point(554, 120);
            this.btnAnadirFila.Name = "btnAnadirFila";
            this.btnAnadirFila.Size = new System.Drawing.Size(75, 23);
            this.btnAnadirFila.TabIndex = 10;
            this.btnAnadirFila.Text = "Añadir a fila";
            this.btnAnadirFila.UseVisualStyleBackColor = false;
            this.btnAnadirFila.Click += new System.EventHandler(this.añadirFilaClick);
            // 
            // btnRecargarGasolinera
            // 
            this.btnRecargarGasolinera.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRecargarGasolinera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecargarGasolinera.Location = new System.Drawing.Point(25, 140);
            this.btnRecargarGasolinera.Name = "btnRecargarGasolinera";
            this.btnRecargarGasolinera.Size = new System.Drawing.Size(139, 23);
            this.btnRecargarGasolinera.TabIndex = 11;
            this.btnRecargarGasolinera.Tag = "";
            this.btnRecargarGasolinera.Text = "Recargar Gasolinera";
            this.btnRecargarGasolinera.UseVisualStyleBackColor = false;
            this.btnRecargarGasolinera.Click += new System.EventHandler(this.btnRecargarGasolineraClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gold;
            this.label8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Placa del vehículo actual en la fila:";
            // 
            // btnRecargarVehiculo
            // 
            this.btnRecargarVehiculo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRecargarVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecargarVehiculo.Location = new System.Drawing.Point(18, 295);
            this.btnRecargarVehiculo.Name = "btnRecargarVehiculo";
            this.btnRecargarVehiculo.Size = new System.Drawing.Size(146, 23);
            this.btnRecargarVehiculo.TabIndex = 13;
            this.btnRecargarVehiculo.Text = "Recargar al Vehiculo";
            this.btnRecargarVehiculo.UseVisualStyleBackColor = false;
            this.btnRecargarVehiculo.Click += new System.EventHandler(this.RecargarVehiculoClick);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(243, 246);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(67, 15);
            this.lblPlaca.TabIndex = 14;
            this.lblPlaca.Text = "Placa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gold;
            this.label10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cantidad de galones a recargar:";
            // 
            // txtGalonesVehiculo
            // 
            this.txtGalonesVehiculo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtGalonesVehiculo.Location = new System.Drawing.Point(246, 267);
            this.txtGalonesVehiculo.Name = "txtGalonesVehiculo";
            this.txtGalonesVehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtGalonesVehiculo.TabIndex = 16;
            this.txtGalonesVehiculo.TextChanged += new System.EventHandler(this.txtGalonesVehiculo_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gold;
            this.label11.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tipo de Vehículo:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(243, 222);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(52, 15);
            this.lblTipoVehiculo.TabIndex = 18;
            this.lblTipoVehiculo.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 181);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "En Fila:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Image = global::Form_Programacion.Properties.Resources.terpel_logo_EB258B58F7_seeklogo_com;
            this.pictureBox2.Location = new System.Drawing.Point(359, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form_Programacion.Properties.Resources.gasolinera;
            this.pictureBox1.Location = new System.Drawing.Point(414, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(587, 91);
            this.label9.TabIndex = 22;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(679, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "CERRAR \r\nGASOLINERA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGalonesVehiculo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnRecargarVehiculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRecargarGasolinera);
            this.Controls.Add(this.btnAnadirFila);
            this.Controls.Add(this.cbTipoVehiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCantidadGasolinera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecargarGasolinera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gasolinera";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecargarGasolinera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidadGasolinera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.Button btnAnadirFila;
        private System.Windows.Forms.Button btnRecargarGasolinera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRecargarVehiculo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGalonesVehiculo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

