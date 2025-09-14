namespace TPLaboratorioUAI
{
    partial class frmForm2
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
            groupBox4 = new GroupBox();
            txtLocalidad = new TextBox();
            label9 = new Label();
            txtCondicionIVA = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDocumento = new TextBox();
            label6 = new Label();
            btnBuscarCliente = new Button();
            txtCliente = new TextBox();
            txtCodCliente = new TextBox();
            label5 = new Label();
            gbxDetalleVenta = new GroupBox();
            lblTotal = new Label();
            label2 = new Label();
            btnGenerarVenta = new Button();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnAgregarProducto = new Button();
            label1 = new Label();
            numCantidad = new NumericUpDown();
            btnBuscarProducto = new Button();
            txtProducto = new TextBox();
            txtCodProducto = new TextBox();
            label3 = new Label();
            dgvDetalleVenta = new DataGridView();
            groupBox4.SuspendLayout();
            gbxDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtLocalidad);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtCondicionIVA);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtEmail);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtDocumento);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(btnBuscarCliente);
            groupBox4.Controls.Add(txtCliente);
            groupBox4.Controls.Add(txtCodCliente);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(773, 93);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos del cliente";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Font = new Font("Segoe UI", 11.25F);
            txtLocalidad.Location = new Point(581, 56);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(186, 27);
            txtLocalidad.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(503, 59);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 26;
            label9.Text = "Localidad:";
            // 
            // txtCondicionIVA
            // 
            txtCondicionIVA.Font = new Font("Segoe UI", 11.25F);
            txtCondicionIVA.Location = new Point(622, 21);
            txtCondicionIVA.Name = "txtCondicionIVA";
            txtCondicionIVA.Size = new Size(145, 27);
            txtCondicionIVA.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(516, 24);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 24;
            label8.Text = "Condición IVA:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(274, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 27);
            txtEmail.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(218, 59);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 22;
            label7.Text = "E-mail:";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 11.25F);
            txtDocumento.Location = new Point(97, 56);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(112, 27);
            txtDocumento.TabIndex = 21;
            txtDocumento.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(6, 59);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 20;
            label6.Text = "Documento:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(437, 20);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(61, 30);
            btnBuscarCliente.TabIndex = 19;
            btnBuscarCliente.Text = "BUSCAR";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 11.25F);
            txtCliente.Location = new Point(120, 21);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(316, 27);
            txtCliente.TabIndex = 18;
            // 
            // txtCodCliente
            // 
            txtCodCliente.Font = new Font("Segoe UI", 11.25F);
            txtCodCliente.Location = new Point(65, 21);
            txtCodCliente.Name = "txtCodCliente";
            txtCodCliente.Size = new Size(54, 27);
            txtCodCliente.TabIndex = 17;
            txtCodCliente.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(6, 24);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 16;
            label5.Text = "Cliente:";
            // 
            // gbxDetalleVenta
            // 
            gbxDetalleVenta.Controls.Add(lblTotal);
            gbxDetalleVenta.Controls.Add(label2);
            gbxDetalleVenta.Controls.Add(btnGenerarVenta);
            gbxDetalleVenta.Controls.Add(btnEliminarProducto);
            gbxDetalleVenta.Controls.Add(btnModificarProducto);
            gbxDetalleVenta.Controls.Add(btnAgregarProducto);
            gbxDetalleVenta.Controls.Add(label1);
            gbxDetalleVenta.Controls.Add(numCantidad);
            gbxDetalleVenta.Controls.Add(btnBuscarProducto);
            gbxDetalleVenta.Controls.Add(txtProducto);
            gbxDetalleVenta.Controls.Add(txtCodProducto);
            gbxDetalleVenta.Controls.Add(label3);
            gbxDetalleVenta.Controls.Add(dgvDetalleVenta);
            gbxDetalleVenta.Location = new Point(12, 111);
            gbxDetalleVenta.Name = "gbxDetalleVenta";
            gbxDetalleVenta.Size = new Size(773, 321);
            gbxDetalleVenta.TabIndex = 15;
            gbxDetalleVenta.TabStop = false;
            gbxDetalleVenta.Text = "Detalle de la venta";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.Info;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTotal.Location = new Point(637, 285);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(130, 27);
            lblTotal.TabIndex = 23;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(577, 289);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 22;
            label2.Text = "TOTAL:";
            // 
            // btnGenerarVenta
            // 
            btnGenerarVenta.Location = new Point(167, 284);
            btnGenerarVenta.Name = "btnGenerarVenta";
            btnGenerarVenta.Size = new Size(119, 30);
            btnGenerarVenta.TabIndex = 21;
            btnGenerarVenta.Text = "GENERAR VENTA";
            btnGenerarVenta.UseVisualStyleBackColor = true;
            btnGenerarVenta.Click += btnGenerarVenta_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(84, 284);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(73, 30);
            btnEliminarProducto.TabIndex = 20;
            btnEliminarProducto.Text = "ELIMINAR";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(6, 284);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(78, 30);
            btnModificarProducto.TabIndex = 19;
            btnModificarProducto.Text = "MODIFICAR";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(696, 23);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(71, 30);
            btnAgregarProducto.TabIndex = 18;
            btnAgregarProducto.Text = "AGREGAR";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(518, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 17;
            label1.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            numCantidad.Font = new Font("Segoe UI", 10F);
            numCantidad.Location = new Point(590, 25);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(51, 25);
            numCantidad.TabIndex = 16;
            numCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(450, 23);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(61, 30);
            btnBuscarProducto.TabIndex = 15;
            btnBuscarProducto.Text = "BUSCAR";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 11.25F);
            txtProducto.Location = new Point(133, 24);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(316, 27);
            txtProducto.TabIndex = 14;
            // 
            // txtCodProducto
            // 
            txtCodProducto.Font = new Font("Segoe UI", 11.25F);
            txtCodProducto.Location = new Point(78, 24);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(54, 27);
            txtCodProducto.TabIndex = 13;
            txtCodProducto.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 12;
            label3.Text = "Producto:";
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AllowUserToAddRows = false;
            dgvDetalleVenta.AllowUserToDeleteRows = false;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(6, 56);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.Size = new Size(761, 224);
            dgvDetalleVenta.TabIndex = 0;
            dgvDetalleVenta.SelectionChanged += dgvDetalleVenta_SelectionChanged;
            // 
            // frmForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 442);
            Controls.Add(gbxDetalleVenta);
            Controls.Add(groupBox4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FORMULARIO 2";
            Load += frmForm2_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            gbxDetalleVenta.ResumeLayout(false);
            gbxDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private GroupBox gbxDetalleVenta;
        private DataGridView dgvDetalleVenta;
        private TextBox txtCodProducto;
        private Label label3;
        private TextBox txtProducto;
        private Label label1;
        private NumericUpDown numCantidad;
        private Button btnBuscarProducto;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnAgregarProducto;
        private Button btnGenerarVenta;
        private Button btnBuscarCliente;
        private TextBox txtCliente;
        private TextBox txtCodCliente;
        private Label label5;
        private Label lblTotal;
        private Label label2;
        private TextBox txtCondicionIVA;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDocumento;
        private Label label6;
        private TextBox txtLocalidad;
        private Label label9;
    }
}