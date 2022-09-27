
namespace RecetasSLN.presentación
{
    partial class FrmConsultarRecetas
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
            this.lblReceta = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCheff = new System.Windows.Forms.Label();
            this.lblTipoingrediente = new System.Windows.Forms.Label();
            this.CboTipoIngrediente = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.CboIngrediente = new System.Windows.Forms.ComboBox();
            this.txtCantIngredientes = new System.Windows.Forms.Label();
            this.Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Location = new System.Drawing.Point(70, 40);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(55, 13);
            this.lblReceta.TabIndex = 0;
            this.lblReceta.Text = "Receta #:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(131, 127);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(253, 20);
            this.txtCheff.TabIndex = 2;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(27, 94);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCheff
            // 
            this.LblCheff.AutoSize = true;
            this.LblCheff.Location = new System.Drawing.Point(27, 127);
            this.LblCheff.Name = "LblCheff";
            this.LblCheff.Size = new System.Drawing.Size(32, 13);
            this.LblCheff.TabIndex = 5;
            this.LblCheff.Text = "Cheff";
            // 
            // lblTipoingrediente
            // 
            this.lblTipoingrediente.AutoSize = true;
            this.lblTipoingrediente.Location = new System.Drawing.Point(27, 165);
            this.lblTipoingrediente.Name = "lblTipoingrediente";
            this.lblTipoingrediente.Size = new System.Drawing.Size(98, 13);
            this.lblTipoingrediente.TabIndex = 6;
            this.lblTipoingrediente.Text = "Tipo de ingrediente";
            // 
            // CboTipoIngrediente
            // 
            this.CboTipoIngrediente.FormattingEnabled = true;
            this.CboTipoIngrediente.Location = new System.Drawing.Point(131, 162);
            this.CboTipoIngrediente.Name = "CboTipoIngrediente";
            this.CboTipoIngrediente.Size = new System.Drawing.Size(140, 21);
            this.CboTipoIngrediente.TabIndex = 7;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(194, 202);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(195, 20);
            this.nudCantidad.TabIndex = 8;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(50, 413);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 9;
            this.BtnAceptar.Text = "Agregar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(174, 413);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(395, 199);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingrediente,
            this.Acciones,
            this.Cantidad});
            this.dgvIngredientes.Location = new System.Drawing.Point(30, 237);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.Size = new System.Drawing.Size(440, 150);
            this.dgvIngredientes.TabIndex = 12;
            this.dgvIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellContentClick);
            // 
            // CboIngrediente
            // 
            this.CboIngrediente.FormattingEnabled = true;
            this.CboIngrediente.Location = new System.Drawing.Point(30, 201);
            this.CboIngrediente.Name = "CboIngrediente";
            this.CboIngrediente.Size = new System.Drawing.Size(158, 21);
            this.CboIngrediente.TabIndex = 13;
            // 
            // txtCantIngredientes
            // 
            this.txtCantIngredientes.AutoSize = true;
            this.txtCantIngredientes.Location = new System.Drawing.Point(303, 418);
            this.txtCantIngredientes.Name = "txtCantIngredientes";
            this.txtCantIngredientes.Size = new System.Drawing.Size(94, 13);
            this.txtCantIngredientes.TabIndex = 14;
            this.txtCantIngredientes.Text = "Total ingredientes:";
            // 
            // Ingrediente
            // 
            this.Ingrediente.HeaderText = "Ingrediente";
            this.Ingrediente.Name = "Ingrediente";
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // FrmConsultarRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 449);
            this.Controls.Add(this.txtCantIngredientes);
            this.Controls.Add(this.CboIngrediente);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.CboTipoIngrediente);
            this.Controls.Add(this.lblTipoingrediente);
            this.Controls.Add(this.LblCheff);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.txtCheff);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblReceta);
            this.Name = "FrmConsultarRecetas";
            this.Text = "Alta Receta";
            this.Load += new System.EventHandler(this.FrmConsultarRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCheff;
        private System.Windows.Forms.Label lblTipoingrediente;
        private System.Windows.Forms.ComboBox CboTipoIngrediente;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.ComboBox CboIngrediente;
        private System.Windows.Forms.Label txtCantIngredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingrediente;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}