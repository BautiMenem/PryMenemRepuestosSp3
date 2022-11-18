namespace WindowsFormsApp2
{
    partial class frmMain
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
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lstMarca = new System.Windows.Forms.ComboBox();
            this.lstOrigen = new System.Windows.Forms.ComboBox();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mrcRepuestos = new System.Windows.Forms.GroupBox();
            this.rtbRepuestos = new System.Windows.Forms.ListBox();
            this.lstMarca2 = new System.Windows.Forms.ComboBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            this.mrcRepuestos.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lstMarca);
            this.mrcDatos.Controls.Add(this.lstOrigen);
            this.mrcDatos.Controls.Add(this.rtbDescripcion);
            this.mrcDatos.Controls.Add(this.lblDescripcion);
            this.mrcDatos.Controls.Add(this.txtNumero);
            this.mrcDatos.Controls.Add(this.txtPrecio);
            this.mrcDatos.Controls.Add(this.lblNumero);
            this.mrcDatos.Controls.Add(this.lblPrecio);
            this.mrcDatos.Controls.Add(this.lblOrigen);
            this.mrcDatos.Controls.Add(this.lblMarca);
            this.mrcDatos.Location = new System.Drawing.Point(34, 44);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(606, 232);
            this.mrcDatos.TabIndex = 0;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos de Repuestos";
            // 
            // lstMarca
            // 
            this.lstMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMarca.FormattingEnabled = true;
            this.lstMarca.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.lstMarca.Location = new System.Drawing.Point(125, 32);
            this.lstMarca.Name = "lstMarca";
            this.lstMarca.Size = new System.Drawing.Size(100, 21);
            this.lstMarca.TabIndex = 11;
            // 
            // lstOrigen
            // 
            this.lstOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstOrigen.FormattingEnabled = true;
            this.lstOrigen.Items.AddRange(new object[] {
            "Nacional",
            "Importado"});
            this.lstOrigen.Location = new System.Drawing.Point(125, 91);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.Size = new System.Drawing.Size(100, 21);
            this.lstOrigen.TabIndex = 10;
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(188, 149);
            this.rtbDescripcion.MaxLength = 50;
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(284, 77);
            this.rtbDescripcion.TabIndex = 9;
            this.rtbDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(290, 133);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(452, 35);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(452, 91);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(374, 38);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(374, 94);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(50, 94);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(51, 35);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // mrcRepuestos
            // 
            this.mrcRepuestos.Controls.Add(this.rtbRepuestos);
            this.mrcRepuestos.Controls.Add(this.lstMarca2);
            this.mrcRepuestos.Controls.Add(this.mrcOrigen);
            this.mrcRepuestos.Controls.Add(this.lblMarca2);
            this.mrcRepuestos.Location = new System.Drawing.Point(34, 295);
            this.mrcRepuestos.Name = "mrcRepuestos";
            this.mrcRepuestos.Size = new System.Drawing.Size(606, 232);
            this.mrcRepuestos.TabIndex = 9;
            this.mrcRepuestos.TabStop = false;
            this.mrcRepuestos.Text = "Repuestos Ingresados";
            // 
            // rtbRepuestos
            // 
            this.rtbRepuestos.FormattingEnabled = true;
            this.rtbRepuestos.Location = new System.Drawing.Point(345, 32);
            this.rtbRepuestos.Name = "rtbRepuestos";
            this.rtbRepuestos.Size = new System.Drawing.Size(207, 186);
            this.rtbRepuestos.TabIndex = 13;
            // 
            // lstMarca2
            // 
            this.lstMarca2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMarca2.FormattingEnabled = true;
            this.lstMarca2.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.lstMarca2.Location = new System.Drawing.Point(125, 32);
            this.lstMarca2.Name = "lstMarca2";
            this.lstMarca2.Size = new System.Drawing.Size(100, 21);
            this.lstMarca2.TabIndex = 12;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Location = new System.Drawing.Point(45, 92);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(180, 85);
            this.mrcOrigen.TabIndex = 9;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(19, 46);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 1;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(19, 23);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 0;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(51, 35);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(37, 13);
            this.lblMarca2.TabIndex = 0;
            this.lblMarca2.Text = "Marca";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(672, 56);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 36);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(672, 115);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 36);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(672, 307);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 36);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 560);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcRepuestos);
            this.Controls.Add(this.mrcDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.mrcRepuestos.ResumeLayout(false);
            this.mrcRepuestos.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.ComboBox lstOrigen;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox mrcRepuestos;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox lstMarca;
        private System.Windows.Forms.ListBox rtbRepuestos;
        private System.Windows.Forms.ComboBox lstMarca2;
    }
}

