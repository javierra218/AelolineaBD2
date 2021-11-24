
namespace Aerolinea
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
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tbpInsertar = new System.Windows.Forms.TabPage();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmpresa = new System.Windows.Forms.Label();
            this.lblNombreEmp = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.btnGuardarEmpresa = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.tbpInsertarAvion = new System.Windows.Forms.TabPage();
            this.dtpFechaEnsamble = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEnsamble = new System.Windows.Forms.Label();
            this.lblPaisEnsamble = new System.Windows.Forms.Label();
            this.lblLogintudAvion = new System.Windows.Forms.Label();
            this.lblTipoAvion = new System.Windows.Forms.Label();
            this.lblMarcaAvion = new System.Windows.Forms.Label();
            this.lblIDAerolinea = new System.Windows.Forms.Label();
            this.lblSerialAvion = new System.Windows.Forms.Label();
            this.btnGuardarAvion = new System.Windows.Forms.Button();
            this.txtEnsamblePais = new System.Windows.Forms.TextBox();
            this.txtLongitudAvion = new System.Windows.Forms.TextBox();
            this.txtAvionMarca = new System.Windows.Forms.TextBox();
            this.txtIDAerolinea = new System.Windows.Forms.TextBox();
            this.txtSerialAvion = new System.Windows.Forms.TextBox();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.dgvAviones = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTexBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbpEliminar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminarAvion = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.cbxTipoAvion = new System.Windows.Forms.ComboBox();
            this.tbcGestion.SuspendLayout();
            this.tbpInsertar.SuspendLayout();
            this.tbpInsertarAvion.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).BeginInit();
            this.tbpEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tbpInsertar);
            this.tbcGestion.Controls.Add(this.tbpInsertarAvion);
            this.tbcGestion.Controls.Add(this.tbpBuscar);
            this.tbcGestion.Controls.Add(this.tbpEliminar);
            this.tbcGestion.Location = new System.Drawing.Point(12, 12);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(637, 333);
            this.tbcGestion.TabIndex = 1;
            // 
            // tbpInsertar
            // 
            this.tbpInsertar.Controls.Add(this.dtFecha);
            this.tbpInsertar.Controls.Add(this.lblFechaEmpresa);
            this.tbpInsertar.Controls.Add(this.lblNombreEmp);
            this.tbpInsertar.Controls.Add(this.lblNit);
            this.tbpInsertar.Controls.Add(this.btnGuardarEmpresa);
            this.tbpInsertar.Controls.Add(this.txtNombre);
            this.tbpInsertar.Controls.Add(this.txtNIT);
            this.tbpInsertar.Location = new System.Drawing.Point(4, 22);
            this.tbpInsertar.Name = "tbpInsertar";
            this.tbpInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInsertar.Size = new System.Drawing.Size(629, 307);
            this.tbpInsertar.TabIndex = 0;
            this.tbpInsertar.Text = "Insertar";
            this.tbpInsertar.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(236, 158);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 7;
            // 
            // lblFechaEmpresa
            // 
            this.lblFechaEmpresa.AutoSize = true;
            this.lblFechaEmpresa.Location = new System.Drawing.Point(31, 166);
            this.lblFechaEmpresa.Name = "lblFechaEmpresa";
            this.lblFechaEmpresa.Size = new System.Drawing.Size(67, 13);
            this.lblFechaEmpresa.TabIndex = 6;
            this.lblFechaEmpresa.Text = "Digite Fecha";
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.AutoSize = true;
            this.lblNombreEmp.Location = new System.Drawing.Point(31, 113);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(117, 13);
            this.lblNombreEmp.TabIndex = 5;
            this.lblNombreEmp.Text = "Digite Nombre empresa";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(28, 65);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(98, 13);
            this.lblNit.TabIndex = 4;
            this.lblNit.Text = "Digite NIT empresa";
            // 
            // btnGuardarEmpresa
            // 
            this.btnGuardarEmpresa.Location = new System.Drawing.Point(236, 197);
            this.btnGuardarEmpresa.Name = "btnGuardarEmpresa";
            this.btnGuardarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEmpresa.TabIndex = 3;
            this.btnGuardarEmpresa.Text = "Guardar";
            this.btnGuardarEmpresa.UseVisualStyleBackColor = true;
            this.btnGuardarEmpresa.Click += new System.EventHandler(this.btnGuardarEmpresa_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(236, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(236, 59);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(100, 20);
            this.txtNIT.TabIndex = 0;
            this.txtNIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIT_KeyPress);
            // 
            // tbpInsertarAvion
            // 
            this.tbpInsertarAvion.Controls.Add(this.dtpFechaEnsamble);
            this.tbpInsertarAvion.Controls.Add(this.cbxTipoAvion);
            this.tbpInsertarAvion.Controls.Add(this.lblFechaEnsamble);
            this.tbpInsertarAvion.Controls.Add(this.lblPaisEnsamble);
            this.tbpInsertarAvion.Controls.Add(this.lblLogintudAvion);
            this.tbpInsertarAvion.Controls.Add(this.lblTipoAvion);
            this.tbpInsertarAvion.Controls.Add(this.lblMarcaAvion);
            this.tbpInsertarAvion.Controls.Add(this.lblIDAerolinea);
            this.tbpInsertarAvion.Controls.Add(this.lblSerialAvion);
            this.tbpInsertarAvion.Controls.Add(this.btnGuardarAvion);
            this.tbpInsertarAvion.Controls.Add(this.txtEnsamblePais);
            this.tbpInsertarAvion.Controls.Add(this.txtLongitudAvion);
            this.tbpInsertarAvion.Controls.Add(this.txtAvionMarca);
            this.tbpInsertarAvion.Controls.Add(this.txtIDAerolinea);
            this.tbpInsertarAvion.Controls.Add(this.txtSerialAvion);
            this.tbpInsertarAvion.Location = new System.Drawing.Point(4, 22);
            this.tbpInsertarAvion.Name = "tbpInsertarAvion";
            this.tbpInsertarAvion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInsertarAvion.Size = new System.Drawing.Size(629, 307);
            this.tbpInsertarAvion.TabIndex = 3;
            this.tbpInsertarAvion.Text = "Insertar Avion";
            this.tbpInsertarAvion.UseVisualStyleBackColor = true;
            // 
            // dtpFechaEnsamble
            // 
            this.dtpFechaEnsamble.CustomFormat = "";
            this.dtpFechaEnsamble.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEnsamble.Location = new System.Drawing.Point(410, 197);
            this.dtpFechaEnsamble.Name = "dtpFechaEnsamble";
            this.dtpFechaEnsamble.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaEnsamble.TabIndex = 16;
            // 
            // lblFechaEnsamble
            // 
            this.lblFechaEnsamble.AutoSize = true;
            this.lblFechaEnsamble.Location = new System.Drawing.Point(41, 203);
            this.lblFechaEnsamble.Name = "lblFechaEnsamble";
            this.lblFechaEnsamble.Size = new System.Drawing.Size(162, 13);
            this.lblFechaEnsamble.TabIndex = 14;
            this.lblFechaEnsamble.Text = "Seleccione Fecha de ensamble: ";
            // 
            // lblPaisEnsamble
            // 
            this.lblPaisEnsamble.AutoSize = true;
            this.lblPaisEnsamble.Location = new System.Drawing.Point(41, 170);
            this.lblPaisEnsamble.Name = "lblPaisEnsamble";
            this.lblPaisEnsamble.Size = new System.Drawing.Size(138, 13);
            this.lblPaisEnsamble.TabIndex = 13;
            this.lblPaisEnsamble.Text = "Ingrese el pais de ensamble";
            // 
            // lblLogintudAvion
            // 
            this.lblLogintudAvion.AutoSize = true;
            this.lblLogintudAvion.Location = new System.Drawing.Point(41, 143);
            this.lblLogintudAvion.Name = "lblLogintudAvion";
            this.lblLogintudAvion.Size = new System.Drawing.Size(139, 13);
            this.lblLogintudAvion.TabIndex = 12;
            this.lblLogintudAvion.Text = "Inserte la longitud del avion:";
            // 
            // lblTipoAvion
            // 
            this.lblTipoAvion.AutoSize = true;
            this.lblTipoAvion.Location = new System.Drawing.Point(41, 115);
            this.lblTipoAvion.Name = "lblTipoAvion";
            this.lblTipoAvion.Size = new System.Drawing.Size(118, 13);
            this.lblTipoAvion.TabIndex = 11;
            this.lblTipoAvion.Text = "Seleccion tipo de avion";
            // 
            // lblMarcaAvion
            // 
            this.lblMarcaAvion.AutoSize = true;
            this.lblMarcaAvion.Location = new System.Drawing.Point(41, 85);
            this.lblMarcaAvion.Name = "lblMarcaAvion";
            this.lblMarcaAvion.Size = new System.Drawing.Size(124, 13);
            this.lblMarcaAvion.TabIndex = 10;
            this.lblMarcaAvion.Text = "Ingrese Marca del avion:";
            // 
            // lblIDAerolinea
            // 
            this.lblIDAerolinea.AutoSize = true;
            this.lblIDAerolinea.Location = new System.Drawing.Point(41, 59);
            this.lblIDAerolinea.Name = "lblIDAerolinea";
            this.lblIDAerolinea.Size = new System.Drawing.Size(143, 13);
            this.lblIDAerolinea.TabIndex = 9;
            this.lblIDAerolinea.Text = "Ingrese el ID de la Aerolinea:";
            // 
            // lblSerialAvion
            // 
            this.lblSerialAvion.AutoSize = true;
            this.lblSerialAvion.Location = new System.Drawing.Point(41, 33);
            this.lblSerialAvion.Name = "lblSerialAvion";
            this.lblSerialAvion.Size = new System.Drawing.Size(118, 13);
            this.lblSerialAvion.TabIndex = 8;
            this.lblSerialAvion.Text = "Ingrese serial del avion:";
            // 
            // btnGuardarAvion
            // 
            this.btnGuardarAvion.Location = new System.Drawing.Point(410, 234);
            this.btnGuardarAvion.Name = "btnGuardarAvion";
            this.btnGuardarAvion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAvion.TabIndex = 7;
            this.btnGuardarAvion.Text = "Guardar";
            this.btnGuardarAvion.UseVisualStyleBackColor = true;
            this.btnGuardarAvion.Click += new System.EventHandler(this.btnGuardarAvion_Click);
            // 
            // txtEnsamblePais
            // 
            this.txtEnsamblePais.Location = new System.Drawing.Point(410, 163);
            this.txtEnsamblePais.Name = "txtEnsamblePais";
            this.txtEnsamblePais.Size = new System.Drawing.Size(100, 20);
            this.txtEnsamblePais.TabIndex = 5;
            // 
            // txtLongitudAvion
            // 
            this.txtLongitudAvion.Location = new System.Drawing.Point(410, 136);
            this.txtLongitudAvion.Name = "txtLongitudAvion";
            this.txtLongitudAvion.Size = new System.Drawing.Size(100, 20);
            this.txtLongitudAvion.TabIndex = 4;
            // 
            // txtAvionMarca
            // 
            this.txtAvionMarca.Location = new System.Drawing.Point(410, 78);
            this.txtAvionMarca.Name = "txtAvionMarca";
            this.txtAvionMarca.Size = new System.Drawing.Size(100, 20);
            this.txtAvionMarca.TabIndex = 2;
            // 
            // txtIDAerolinea
            // 
            this.txtIDAerolinea.Location = new System.Drawing.Point(410, 52);
            this.txtIDAerolinea.Name = "txtIDAerolinea";
            this.txtIDAerolinea.Size = new System.Drawing.Size(100, 20);
            this.txtIDAerolinea.TabIndex = 1;
            this.txtIDAerolinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDAerolinea_KeyPress);
            // 
            // txtSerialAvion
            // 
            this.txtSerialAvion.Location = new System.Drawing.Point(410, 26);
            this.txtSerialAvion.Name = "txtSerialAvion";
            this.txtSerialAvion.Size = new System.Drawing.Size(100, 20);
            this.txtSerialAvion.TabIndex = 0;
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.dgvAviones);
            this.tbpBuscar.Controls.Add(this.txtBuscar);
            this.tbpBuscar.Controls.Add(this.lblTexBuscar);
            this.tbpBuscar.Controls.Add(this.btnBuscar);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(629, 307);
            this.tbpBuscar.TabIndex = 1;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvAviones
            // 
            this.dgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAviones.Location = new System.Drawing.Point(50, 134);
            this.dgvAviones.Name = "dgvAviones";
            this.dgvAviones.Size = new System.Drawing.Size(462, 139);
            this.dgvAviones.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(215, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblTexBuscar
            // 
            this.lblTexBuscar.AutoSize = true;
            this.lblTexBuscar.Location = new System.Drawing.Point(47, 63);
            this.lblTexBuscar.Name = "lblTexBuscar";
            this.lblTexBuscar.Size = new System.Drawing.Size(109, 13);
            this.lblTexBuscar.TabIndex = 1;
            this.lblTexBuscar.Text = "Inserte NIT empresa: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(426, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbpEliminar
            // 
            this.tbpEliminar.Controls.Add(this.btnEliminar);
            this.tbpEliminar.Controls.Add(this.lblEliminarAvion);
            this.tbpEliminar.Controls.Add(this.txtEliminar);
            this.tbpEliminar.Location = new System.Drawing.Point(4, 22);
            this.tbpEliminar.Name = "tbpEliminar";
            this.tbpEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminar.Size = new System.Drawing.Size(629, 307);
            this.tbpEliminar.TabIndex = 2;
            this.tbpEliminar.Text = "Eliminar";
            this.tbpEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(233, 197);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEliminarAvion
            // 
            this.lblEliminarAvion.AutoSize = true;
            this.lblEliminarAvion.Location = new System.Drawing.Point(59, 123);
            this.lblEliminarAvion.Name = "lblEliminarAvion";
            this.lblEliminarAvion.Size = new System.Drawing.Size(154, 13);
            this.lblEliminarAvion.TabIndex = 1;
            this.lblEliminarAvion.Text = "Ingrese serial del avion a borrar";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(334, 116);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 0;
            // 
            // cbxTipoAvion
            // 
            this.cbxTipoAvion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Aerolinea.Properties.Settings.Default, "comercial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxTipoAvion.FormattingEnabled = true;
            this.cbxTipoAvion.Items.AddRange(new object[] {
            "comercial",
            "carga",
            "militar"});
            this.cbxTipoAvion.Location = new System.Drawing.Point(410, 107);
            this.cbxTipoAvion.Name = "cbxTipoAvion";
            this.cbxTipoAvion.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoAvion.TabIndex = 15;
            this.cbxTipoAvion.Text = global::Aerolinea.Properties.Settings.Default.comercial;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 369);
            this.Controls.Add(this.tbcGestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcGestion.ResumeLayout(false);
            this.tbpInsertar.ResumeLayout(false);
            this.tbpInsertar.PerformLayout();
            this.tbpInsertarAvion.ResumeLayout(false);
            this.tbpInsertarAvion.PerformLayout();
            this.tbpBuscar.ResumeLayout(false);
            this.tbpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).EndInit();
            this.tbpEliminar.ResumeLayout(false);
            this.tbpEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.TabPage tbpInsertar;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTexBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tbpEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label lblNombreEmp;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Button btnGuardarEmpresa;
        private System.Windows.Forms.Label lblFechaEmpresa;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TabPage tbpInsertarAvion;
        private System.Windows.Forms.ComboBox cbxTipoAvion;
        private System.Windows.Forms.Label lblFechaEnsamble;
        private System.Windows.Forms.Label lblPaisEnsamble;
        private System.Windows.Forms.Label lblLogintudAvion;
        private System.Windows.Forms.Label lblTipoAvion;
        private System.Windows.Forms.Label lblMarcaAvion;
        private System.Windows.Forms.Label lblIDAerolinea;
        private System.Windows.Forms.Label lblSerialAvion;
        private System.Windows.Forms.Button btnGuardarAvion;
        private System.Windows.Forms.TextBox txtEnsamblePais;
        private System.Windows.Forms.TextBox txtLongitudAvion;
        private System.Windows.Forms.TextBox txtAvionMarca;
        private System.Windows.Forms.TextBox txtIDAerolinea;
        private System.Windows.Forms.TextBox txtSerialAvion;
        private System.Windows.Forms.DateTimePicker dtpFechaEnsamble;
        private System.Windows.Forms.DataGridView dgvAviones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEliminarAvion;
        private System.Windows.Forms.TextBox txtEliminar;
    }
}

