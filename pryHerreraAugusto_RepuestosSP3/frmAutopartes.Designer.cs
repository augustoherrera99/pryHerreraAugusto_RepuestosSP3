namespace pryHerreraAugusto_RepuestosSP3
{
    partial class frmAutopartes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutopartes));
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNroRepuesto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNroRepuesto = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.lstBusqueda = new System.Windows.Forms.ListBox();
            this.optNacional2 = new System.Windows.Forms.RadioButton();
            this.optImportado2 = new System.Windows.Forms.RadioButton();
            this.cmbMarca2 = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrarRegistros = new System.Windows.Forms.Button();
            this.mrcRegistro.SuspendLayout();
            this.mrcConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.txtDescripcion);
            this.mrcRegistro.Controls.Add(this.txtNroRepuesto);
            this.mrcRegistro.Controls.Add(this.txtPrecio);
            this.mrcRegistro.Controls.Add(this.optNacional);
            this.mrcRegistro.Controls.Add(this.optImportado);
            this.mrcRegistro.Controls.Add(this.lblDescripcion);
            this.mrcRegistro.Controls.Add(this.cmbMarca);
            this.mrcRegistro.Controls.Add(this.lblPrecio);
            this.mrcRegistro.Controls.Add(this.lblNroRepuesto);
            this.mrcRegistro.Controls.Add(this.lblOrigen);
            this.mrcRegistro.Controls.Add(this.lblMarca);
            this.mrcRegistro.Location = new System.Drawing.Point(16, 12);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(434, 155);
            this.mrcRegistro.TabIndex = 0;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro de Repuestos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(211, 86);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 51);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtNroRepuesto
            // 
            this.txtNroRepuesto.Location = new System.Drawing.Point(80, 69);
            this.txtNroRepuesto.MaxLength = 6;
            this.txtNroRepuesto.Name = "txtNroRepuesto";
            this.txtNroRepuesto.Size = new System.Drawing.Size(82, 20);
            this.txtNroRepuesto.TabIndex = 11;
            this.txtNroRepuesto.TextChanged += new System.EventHandler(this.txtNroRepuesto_TextChanged);
            this.txtNroRepuesto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroRepuesto_KeyDown);
            this.txtNroRepuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroRepuesto_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(80, 105);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(82, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(293, 35);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(33, 17);
            this.optNacional.TabIndex = 8;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "N";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(259, 35);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(28, 17);
            this.optImportado.TabIndex = 7;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "I";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(208, 70);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.cmbMarca.Location = new System.Drawing.Point(80, 34);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(34, 21);
            this.cmbMarca.TabIndex = 5;
            this.cmbMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMarca_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 108);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio          $";
            // 
            // lblNroRepuesto
            // 
            this.lblNroRepuesto.AutoSize = true;
            this.lblNroRepuesto.Location = new System.Drawing.Point(6, 72);
            this.lblNroRepuesto.Name = "lblNroRepuesto";
            this.lblNroRepuesto.Size = new System.Drawing.Size(68, 13);
            this.lblNroRepuesto.TabIndex = 2;
            this.lblNroRepuesto.Text = "N° Repuesto";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(208, 37);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 37);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.lstBusqueda);
            this.mrcConsulta.Controls.Add(this.optNacional2);
            this.mrcConsulta.Controls.Add(this.optImportado2);
            this.mrcConsulta.Controls.Add(this.cmbMarca2);
            this.mrcConsulta.Controls.Add(this.lblResultado);
            this.mrcConsulta.Controls.Add(this.lblOrigen2);
            this.mrcConsulta.Controls.Add(this.lblMarca2);
            this.mrcConsulta.Enabled = false;
            this.mrcConsulta.Location = new System.Drawing.Point(16, 184);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Size = new System.Drawing.Size(434, 153);
            this.mrcConsulta.TabIndex = 1;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta";
            // 
            // lstBusqueda
            // 
            this.lstBusqueda.FormattingEnabled = true;
            this.lstBusqueda.Location = new System.Drawing.Point(211, 38);
            this.lstBusqueda.Name = "lstBusqueda";
            this.lstBusqueda.Size = new System.Drawing.Size(188, 95);
            this.lstBusqueda.TabIndex = 6;
            this.lstBusqueda.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // optNacional2
            // 
            this.optNacional2.AutoSize = true;
            this.optNacional2.Location = new System.Drawing.Point(91, 70);
            this.optNacional2.Name = "optNacional2";
            this.optNacional2.Size = new System.Drawing.Size(33, 17);
            this.optNacional2.TabIndex = 5;
            this.optNacional2.TabStop = true;
            this.optNacional2.Text = "N";
            this.optNacional2.UseVisualStyleBackColor = true;
            // 
            // optImportado2
            // 
            this.optImportado2.AutoSize = true;
            this.optImportado2.Location = new System.Drawing.Point(57, 70);
            this.optImportado2.Name = "optImportado2";
            this.optImportado2.Size = new System.Drawing.Size(28, 17);
            this.optImportado2.TabIndex = 4;
            this.optImportado2.TabStop = true;
            this.optImportado2.Text = "I";
            this.optImportado2.UseVisualStyleBackColor = true;
            // 
            // cmbMarca2
            // 
            this.cmbMarca2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca2.FormattingEnabled = true;
            this.cmbMarca2.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.cmbMarca2.Location = new System.Drawing.Point(56, 35);
            this.cmbMarca2.Name = "cmbMarca2";
            this.cmbMarca2.Size = new System.Drawing.Size(34, 21);
            this.cmbMarca2.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(208, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(6, 70);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen2.TabIndex = 1;
            this.lblOrigen2.Text = "Origen";
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(6, 38);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(37, 13);
            this.lblMarca2.TabIndex = 0;
            this.lblMarca2.Text = "Marca";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(487, 49);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(83, 30);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(487, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Location = new System.Drawing.Point(487, 222);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 30);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(487, 268);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(83, 30);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(387, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrarRegistros
            // 
            this.btnBorrarRegistros.Enabled = false;
            this.btnBorrarRegistros.Location = new System.Drawing.Point(487, 95);
            this.btnBorrarRegistros.Name = "btnBorrarRegistros";
            this.btnBorrarRegistros.Size = new System.Drawing.Size(83, 30);
            this.btnBorrarRegistros.TabIndex = 7;
            this.btnBorrarRegistros.Text = "Borrar";
            this.btnBorrarRegistros.UseVisualStyleBackColor = true;
            this.btnBorrarRegistros.Click += new System.EventHandler(this.btnBorrarRegistros_Click);
            // 
            // frmAutopartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 401);
            this.Controls.Add(this.btnBorrarRegistros);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.mrcRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAutopartes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autopartes - Registros y Consultas";
            this.Load += new System.EventHandler(this.frmAutopartes_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.TextBox txtNroRepuesto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNroRepuesto;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.ListBox lstBusqueda;
        private System.Windows.Forms.RadioButton optNacional2;
        private System.Windows.Forms.RadioButton optImportado2;
        private System.Windows.Forms.ComboBox cmbMarca2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrarRegistros;
    }
}

