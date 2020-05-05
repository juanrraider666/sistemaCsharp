namespace appPinturasV1.Vista
{
    partial class frmRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarProducto));
            this.btnRegistar = new System.Windows.Forms.Button();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtmFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRefenerncia = new System.Windows.Forms.TextBox();
            this.dtmFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistar.BackgroundImage")));
            this.btnRegistar.Location = new System.Drawing.Point(419, 522);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(133, 116);
            this.btnRegistar.TabIndex = 51;
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(700, 474);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(181, 21);
            this.cmbPresentacion.TabIndex = 50;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(700, 401);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(181, 21);
            this.cmbTipo.TabIndex = 49;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(700, 343);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(181, 20);
            this.txtPrecio.TabIndex = 48;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(700, 271);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(181, 20);
            this.txtMarca.TabIndex = 47;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(276, 475);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(181, 20);
            this.txtColor.TabIndex = 45;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(700, 201);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(181, 20);
            this.txtCantidad.TabIndex = 46;
            // 
            // dtmFechaVencimiento
            // 
            this.dtmFechaVencimiento.Location = new System.Drawing.Point(276, 340);
            this.dtmFechaVencimiento.Name = "dtmFechaVencimiento";
            this.dtmFechaVencimiento.Size = new System.Drawing.Size(181, 20);
            this.dtmFechaVencimiento.TabIndex = 44;
            // 
            // txtRefenerncia
            // 
            this.txtRefenerncia.Location = new System.Drawing.Point(276, 401);
            this.txtRefenerncia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRefenerncia.Name = "txtRefenerncia";
            this.txtRefenerncia.Size = new System.Drawing.Size(181, 20);
            this.txtRefenerncia.TabIndex = 43;
            // 
            // dtmFechaIngreso
            // 
            this.dtmFechaIngreso.Location = new System.Drawing.Point(276, 271);
            this.dtmFechaIngreso.Name = "dtmFechaIngreso";
            this.dtmFechaIngreso.Size = new System.Drawing.Size(181, 20);
            this.dtmFechaIngreso.TabIndex = 42;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(276, 201);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(181, 20);
            this.txtProducto.TabIndex = 41;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(823, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(854, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 22);
            this.btnCerrar.TabIndex = 52;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appPinturasV1.Properties.Resources.ddd;
            this.ClientSize = new System.Drawing.Size(898, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.cmbPresentacion);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dtmFechaVencimiento);
            this.Controls.Add(this.txtRefenerncia);
            this.Controls.Add(this.dtmFechaIngreso);
            this.Controls.Add(this.txtProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarProducto";
            this.Text = "frmRegistrarProducto";
            this.Load += new System.EventHandler(this.frmRegistrarProducto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegistrarProducto_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRegistrarProducto_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRegistrarProducto_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtmFechaVencimiento;
        private System.Windows.Forms.TextBox txtRefenerncia;
        private System.Windows.Forms.DateTimePicker dtmFechaIngreso;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
    }
}