
namespace wLibreria2
{
    partial class Padre
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.CmbNombreLibro = new System.Windows.Forms.ComboBox();
            this.GrpLibros = new System.Windows.Forms.GroupBox();
            this.rbtVenta = new System.Windows.Forms.RadioButton();
            this.rbtPrestamo = new System.Windows.Forms.RadioButton();
            this.GrpValor = new System.Windows.Forms.GroupBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtValorLibro = new System.Windows.Forms.TextBox();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.lblValorLibro = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.GrpLibros.SuspendLayout();
            this.GrpValor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo ";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // txt1
            // 
            this.txt1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(0, 24);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(800, 426);
            this.txt1.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(212, 38);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 88);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(215, 88);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(15, 128);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 9;
            this.lblCedula.Text = "Cedula";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(218, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(15, 170);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad";
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Location = new System.Drawing.Point(265, 167);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(129, 21);
            this.CmbSexo.TabIndex = 12;
            this.CmbSexo.Text = "Sexo";
            // 
            // CmbNombreLibro
            // 
            this.CmbNombreLibro.FormattingEnabled = true;
            this.CmbNombreLibro.Location = new System.Drawing.Point(63, 211);
            this.CmbNombreLibro.Name = "CmbNombreLibro";
            this.CmbNombreLibro.Size = new System.Drawing.Size(152, 21);
            this.CmbNombreLibro.TabIndex = 13;
            this.CmbNombreLibro.Text = "Nombre del libro ";
            // 
            // GrpLibros
            // 
            this.GrpLibros.Controls.Add(this.rbtVenta);
            this.GrpLibros.Controls.Add(this.rbtPrestamo);
            this.GrpLibros.Location = new System.Drawing.Point(18, 247);
            this.GrpLibros.Name = "GrpLibros";
            this.GrpLibros.Size = new System.Drawing.Size(200, 100);
            this.GrpLibros.TabIndex = 14;
            this.GrpLibros.TabStop = false;
            this.GrpLibros.Text = "Libros";
            // 
            // rbtVenta
            // 
            this.rbtVenta.AutoSize = true;
            this.rbtVenta.Location = new System.Drawing.Point(7, 49);
            this.rbtVenta.Name = "rbtVenta";
            this.rbtVenta.Size = new System.Drawing.Size(53, 17);
            this.rbtVenta.TabIndex = 0;
            this.rbtVenta.TabStop = true;
            this.rbtVenta.Text = "Venta";
            this.rbtVenta.UseVisualStyleBackColor = true;
            // 
            // rbtPrestamo
            // 
            this.rbtPrestamo.AutoSize = true;
            this.rbtPrestamo.Location = new System.Drawing.Point(7, 19);
            this.rbtPrestamo.Name = "rbtPrestamo";
            this.rbtPrestamo.Size = new System.Drawing.Size(69, 17);
            this.rbtPrestamo.TabIndex = 0;
            this.rbtPrestamo.TabStop = true;
            this.rbtPrestamo.Text = "Prestamo";
            this.rbtPrestamo.UseVisualStyleBackColor = true;
            // 
            // GrpValor
            // 
            this.GrpValor.Controls.Add(this.txtValorPagar);
            this.GrpValor.Controls.Add(this.txtIVA);
            this.GrpValor.Controls.Add(this.txtValorLibro);
            this.GrpValor.Controls.Add(this.lblValorPagar);
            this.GrpValor.Controls.Add(this.lbliva);
            this.GrpValor.Controls.Add(this.lblValorLibro);
            this.GrpValor.Location = new System.Drawing.Point(255, 231);
            this.GrpValor.Name = "GrpValor";
            this.GrpValor.Size = new System.Drawing.Size(241, 127);
            this.GrpValor.TabIndex = 15;
            this.GrpValor.TabStop = false;
            this.GrpValor.Text = "Valor";
            this.GrpValor.Enter += new System.EventHandler(this.GrpValor_Enter);
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(86, 91);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 23;
            this.txtValorPagar.TextChanged += new System.EventHandler(this.txtValorPagar_TextChanged);
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(86, 62);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 23;
            // 
            // txtValorLibro
            // 
            this.txtValorLibro.Location = new System.Drawing.Point(86, 34);
            this.txtValorLibro.Name = "txtValorLibro";
            this.txtValorLibro.Size = new System.Drawing.Size(100, 20);
            this.txtValorLibro.TabIndex = 23;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(10, 94);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(70, 13);
            this.lblValorPagar.TabIndex = 2;
            this.lblValorPagar.Text = "Valor a pagar";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Location = new System.Drawing.Point(10, 65);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(24, 13);
            this.lbliva.TabIndex = 1;
            this.lbliva.Text = "IVA";
            // 
            // lblValorLibro
            // 
            this.lblValorLibro.AutoSize = true;
            this.lblValorLibro.Location = new System.Drawing.Point(10, 37);
            this.lblValorLibro.Name = "lblValorLibro";
            this.lblValorLibro.Size = new System.Drawing.Size(57, 13);
            this.lblValorLibro.TabIndex = 0;
            this.lblValorLibro.Text = "Valor Libro";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(63, 81);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(63, 128);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 18;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(63, 170);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(273, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(273, 85);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 21;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(273, 38);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 22;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(521, 56);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(122, 45);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(521, 117);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(122, 42);
            this.BtnLimpiar.TabIndex = 24;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(521, 170);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(122, 44);
            this.BtnSalir.TabIndex = 25;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(521, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 51);
            this.btnCalcular.TabIndex = 27;
            this.btnCalcular.Text = "boton puto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "txt";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.GrpValor);
            this.Controls.Add(this.GrpLibros);
            this.Controls.Add(this.CmbNombreLibro);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Padre";
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GrpLibros.ResumeLayout(false);
            this.GrpLibros.PerformLayout();
            this.GrpValor.ResumeLayout(false);
            this.GrpValor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.ComboBox CmbNombreLibro;
        private System.Windows.Forms.GroupBox GrpLibros;
        private System.Windows.Forms.RadioButton rbtVenta;
        private System.Windows.Forms.RadioButton rbtPrestamo;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtValorLibro;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label lblValorLibro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        public System.Windows.Forms.GroupBox GrpValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

