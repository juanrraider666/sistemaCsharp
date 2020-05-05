namespace appPinturasV1.Vista
{
    partial class frmTipoPresentacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnGuardarTipo = new System.Windows.Forms.Button();
            this.txtDescripcionTipo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarPresentacion = new System.Windows.Forms.Button();
            this.txtDescripcionPresentacion = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.dgvListaTipo = new System.Windows.Forms.DataGridView();
            this.dgvListaPresentacion = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.btnGuardarTipo);
            this.groupBox1.Controls.Add(this.txtDescripcionTipo);
            this.groupBox1.Location = new System.Drawing.Point(19, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regristrar Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(70, 49);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.Location = new System.Drawing.Point(70, 137);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarTipo.TabIndex = 2;
            this.btnGuardarTipo.Text = "Guardar";
            this.btnGuardarTipo.UseVisualStyleBackColor = true;
            this.btnGuardarTipo.Click += new System.EventHandler(this.btnGuardarTipo_Click);
            // 
            // txtDescripcionTipo
            // 
            this.txtDescripcionTipo.Location = new System.Drawing.Point(70, 91);
            this.txtDescripcionTipo.Name = "txtDescripcionTipo";
            this.txtDescripcionTipo.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionTipo.TabIndex = 1;
            this.txtDescripcionTipo.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardarPresentacion);
            this.groupBox2.Controls.Add(this.txtDescripcionPresentacion);
            this.groupBox2.Controls.Add(this.txtPresentacion);
            this.groupBox2.Location = new System.Drawing.Point(595, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Presentacion";
            // 
            // btnGuardarPresentacion
            // 
            this.btnGuardarPresentacion.Location = new System.Drawing.Point(56, 138);
            this.btnGuardarPresentacion.Name = "btnGuardarPresentacion";
            this.btnGuardarPresentacion.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarPresentacion.TabIndex = 5;
            this.btnGuardarPresentacion.Text = "Guardar";
            this.btnGuardarPresentacion.UseVisualStyleBackColor = true;
            this.btnGuardarPresentacion.Click += new System.EventHandler(this.btnGuardarPresentacion_Click);
            // 
            // txtDescripcionPresentacion
            // 
            this.txtDescripcionPresentacion.Location = new System.Drawing.Point(56, 92);
            this.txtDescripcionPresentacion.Name = "txtDescripcionPresentacion";
            this.txtDescripcionPresentacion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionPresentacion.TabIndex = 4;
            this.txtDescripcionPresentacion.Enter += new System.EventHandler(this.txtDescripcion2_Enter);
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(56, 49);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(100, 20);
            this.txtPresentacion.TabIndex = 3;
            this.txtPresentacion.Enter += new System.EventHandler(this.txtPresentacion_Enter);
            // 
            // dgvListaTipo
            // 
            this.dgvListaTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTipo.Location = new System.Drawing.Point(238, 36);
            this.dgvListaTipo.Name = "dgvListaTipo";
            this.dgvListaTipo.Size = new System.Drawing.Size(339, 150);
            this.dgvListaTipo.TabIndex = 2;
            // 
            // dgvListaPresentacion
            // 
            this.dgvListaPresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPresentacion.Location = new System.Drawing.Point(814, 36);
            this.dgvListaPresentacion.Name = "dgvListaPresentacion";
            this.dgvListaPresentacion.Size = new System.Drawing.Size(329, 150);
            this.dgvListaPresentacion.TabIndex = 3;
            // 
            // frmTipoPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 417);
            this.Controls.Add(this.dgvListaPresentacion);
            this.Controls.Add(this.dgvListaTipo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTipoPresentacion";
            this.Text = "frmTipoPresentacion";
            this.Load += new System.EventHandler(this.frmTipoPresentacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPresentacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardarTipo;
        private System.Windows.Forms.TextBox txtDescripcionTipo;
        private System.Windows.Forms.Button btnGuardarPresentacion;
        private System.Windows.Forms.TextBox txtDescripcionPresentacion;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.DataGridView dgvListaTipo;
        private System.Windows.Forms.DataGridView dgvListaPresentacion;
        private System.Windows.Forms.TextBox txtTipo;
    }
}