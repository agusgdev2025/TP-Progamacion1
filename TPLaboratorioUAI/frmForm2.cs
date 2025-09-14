using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPLaboratorioUAI
{
    public partial class frmForm2 : Form
    {
        #region CLASES AUXILIARES
        public class Cliente
        {
            public int CodCliente { get; set; }
            public string NombreApellido { get; set; }
            public string Documento { get; set; }
            public string Email { get; set; }
            public string CondicionIVA { get; set; }
            public string Localidad { get; set; }
        }

        public class Producto
        {
            public int CodProducto { get; set; }
            public string Nombre { get; set; }
            public decimal PrecioUnitario { get; set; }
        }

        public class ProductoSeleccionado
        {
            public int CodProducto { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal SubTotal
            {
                get
                {
                    return PrecioUnitario * Cantidad;
                }
            }
        }
        #endregion

        // DECLARACION DE VARIABLES Y OBJETOS GLOBALES.-
        Form formBusquedaCliente;
        Form formBusquedaProducto;
        TextBox txtFiltrarCliente;
        TextBox txtFiltrarProducto;
        ListBox lstClientes;
        ListBox lstProductos;
        List<Cliente> listadoClientes;
        List<Producto> listadoProductos;
        BindingList<ProductoSeleccionado> productosSeleccionados;
        Cliente clienteSeleccionado;
        Producto productoSeleccionado;

        public frmForm2()
        {
            InitializeComponent();
        }

        private void frmForm2_Load(object sender, EventArgs e)
        {
            #region DATOS DE PRUEBA
            listadoClientes = new List<Cliente>();
            listadoClientes.Add(new Cliente { CodCliente = 1, NombreApellido = "Juan PEREZ", Documento = "DNI 12345678", Email = "jperez@gmail.com", CondicionIVA = "Resp. Monotributo", Localidad = "Pergamino" });
            listadoClientes.Add(new Cliente { CodCliente = 2, NombreApellido = "Gerardo LOVERA", Documento = "DNI 28237532", Email = "ger80.lovera@gmail.com", CondicionIVA = "Consumidor Final", Localidad = "Santa Rosa" });
            listadoClientes.Add(new Cliente { CodCliente = 3, NombreApellido = "Sandra RODRIGUEZ", Documento = "LC 12342255", Email = "sro1954@hotmail.com", CondicionIVA = "Resp. Inscripto", Localidad = "Santa Rosa" });
            listadoClientes.Add(new Cliente { CodCliente = 4, NombreApellido = "Bartolome Alejandro FABIAN FRANKEL", Documento = "DNI 55412289", Email = "alefabi@gmail.com", CondicionIVA = "Consumidor Final", Localidad = "Moreno" });
            listadoClientes.Add(new Cliente { CodCliente = 5, NombreApellido = "Pepe ARGENTO", Documento = "DNI 12345678", Email = "pepito@yahoo.com", CondicionIVA = "Consumidor Final", Localidad = "Santa Rosa" });
            listadoClientes.Add(new Cliente { CodCliente = 6, NombreApellido = "Agustín GUERRERA", Documento = "DNI 42311228", Email = "agustinG@yahoo.com", CondicionIVA = "Resp. Inscripto", Localidad = "Rosario" });
            listadoClientes.Add(new Cliente { CodCliente = 7, NombreApellido = "Lucía PONTINO", Documento = "DNI 44125863", Email = "luciaP@gmail.com", CondicionIVA = "Consumidor Final", Localidad = "Rosario" });
            listadoClientes.Add(new Cliente { CodCliente = 8, NombreApellido = "Agustín SARMIENTO", Documento = "DNI 55345678", Email = "agus.sarmiento@gmail.com", CondicionIVA = "Resp. Inscripto", Localidad = "Santa Fe" });
            listadoClientes.Add(new Cliente { CodCliente = 9, NombreApellido = "Andrés Juan VACCARI", Documento = "DNI 55311678", Email = "andresV@yahoo.com", CondicionIVA = "Resp. Inscripto", Localidad = "Quilmes" });

            listadoProductos = new List<Producto>();
            listadoProductos.Add(new Producto { CodProducto = 1, Nombre = "Mouse Genius MX320", PrecioUnitario = 25000 });
            listadoProductos.Add(new Producto { CodProducto = 2, Nombre = "Teclado Genius MS112", PrecioUnitario = 32000 });
            listadoProductos.Add(new Producto { CodProducto = 3, Nombre = "Pendrive Sandisk 32 GB", PrecioUnitario = 15500 });
            listadoProductos.Add(new Producto { CodProducto = 4, Nombre = "Pendrive Sandisk 128 GB", PrecioUnitario = 28000 });
            listadoProductos.Add(new Producto { CodProducto = 5, Nombre = "Monitor Samsung 24 \"", PrecioUnitario = 182000 });
            listadoProductos.Add(new Producto { CodProducto = 6, Nombre = "Procesador Intel I5 5400", PrecioUnitario = 452600 });
            listadoProductos.Add(new Producto { CodProducto = 7, Nombre = "Fuente ATX 600w Asus", PrecioUnitario = 188000 });
            listadoProductos.Add(new Producto { CodProducto = 8, Nombre = "Mother Asus B512", PrecioUnitario = 350000 });
            listadoProductos.Add(new Producto { CodProducto = 9, Nombre = "Estabilizador TVR 550", PrecioUnitario = 75000 });
            listadoProductos.Add(new Producto { CodProducto = 10, Nombre = "Memoria RAM 8 GB Kingston", PrecioUnitario = 165000 });
            listadoProductos.Add(new Producto { CodProducto = 11, Nombre = "SSD 240 GB Hikvision", PrecioUnitario = 54200 });
            listadoProductos.Add(new Producto { CodProducto = 12, Nombre = "SSD 128 GB Kingston", PrecioUnitario = 34500 });
            listadoProductos.Add(new Producto { CodProducto = 13, Nombre = "Teclado Logitech X220", PrecioUnitario = 11000 });
            listadoProductos.Add(new Producto { CodProducto = 14, Nombre = "Mouse Logitech M310", PrecioUnitario = 18900 });
            listadoProductos.Add(new Producto { CodProducto = 15, Nombre = "Gabinete ATX Antek", PrecioUnitario = 110000 });
            listadoProductos.Add(new Producto { CodProducto = 16, Nombre = "Gabinete ATX Genérico", PrecioUnitario = 85000 });
            listadoProductos.Add(new Producto { CodProducto = 17, Nombre = "HHD Externo Samsung 1 TB", PrecioUnitario = 110000 });
            listadoProductos.Add(new Producto { CodProducto = 18, Nombre = "Lecto-Grabadora USB Sony", PrecioUnitario = 24000 });
            listadoProductos.Add(new Producto { CodProducto = 19, Nombre = "Procesador AMD Ryzen 5 7400", PrecioUnitario = 374000 });
            listadoProductos.Add(new Producto { CodProducto = 20, Nombre = "Memoria RAM 16 GB Patriot", PrecioUnitario = 215500 });
            #endregion

            productosSeleccionados = new BindingList<ProductoSeleccionado>(); // Lista de productos seleccionados para la venta.-
            dgvDetalleVenta.DataSource = productosSeleccionados; 
            ConfigurarDataGrid(); // Configuración estética del DataGridView.-
            txtCodCliente.Enabled = false; 
            txtCliente.Enabled = false;
            txtDocumento.Enabled = false;
            txtEmail.Enabled = false;
            txtLocalidad.Enabled = false;
            txtCondicionIVA.Enabled = false;
            txtCodProducto.Enabled = false;
            txtProducto.Enabled = false;
            numCantidad.Enabled = false;
            btnAgregarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
            btnGenerarVenta.Enabled = false;
            gbxDetalleVenta.Enabled = false;
            numCantidad.Minimum = 1;
            numCantidad.Maximum = 10;
        }

        private void CargarClientes(string filtro = "") // Carga y filtra la lista de clientes.-
        {
            List<Cliente> clientesFiltrados = listadoClientes
                .Where(x => x.NombreApellido.ToLower()
                .Contains(filtro.ToLower()))
                .OrderBy(x => x.NombreApellido)
                .ToList();

            lstClientes.DataSource = clientesFiltrados;
        }

        private void CargarProducto(string filtro = "") // Carga y filtra la lista de productos.-
        {
            List<Producto> productosFiltrados = listadoProductos
                .Where(x => x.Nombre.ToLower()
                .Contains(filtro.ToLower()))
                .OrderBy(x => x.Nombre)
                .ToList();

            lstProductos.DataSource = productosFiltrados;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // Configuración del formulario de búsqueda de clientes.-
            formBusquedaCliente = new Form();
            formBusquedaCliente.StartPosition = FormStartPosition.CenterParent;
            formBusquedaCliente.MaximizeBox = false;
            formBusquedaCliente.MinimizeBox = false;
            formBusquedaCliente.Size = new Size(300, 200);
            formBusquedaCliente.Text = "BUSCAR CLIENTE";

            // TextBox para filtrar clientes.-
            txtFiltrarCliente = new TextBox();
            txtFiltrarCliente.Size = new Size(270, 30);
            formBusquedaCliente.Controls.Add(txtFiltrarCliente);
            txtFiltrarCliente.Location = new Point(6, 6);
            txtFiltrarCliente.TextChanged += TxtFiltrarCliente_TextChanged;

            // ListBox para mostrar los clientes filtrados.-
            lstClientes = new ListBox();
            lstClientes.Size = new Size(270, 130);
            formBusquedaCliente.Controls.Add(lstClientes);
            lstClientes.Location = new Point(6, 32);
            CargarClientes();
            lstClientes.DisplayMember = "NombreApellido";
            lstClientes.ValueMember = "CodCliente";
            lstClientes.DoubleClick += LstClientes_DoubleClick;

            formBusquedaCliente.ShowDialog();
        }

        private void LstClientes_DoubleClick(object? sender, EventArgs e)
        {
            clienteSeleccionado = (sender as ListBox).SelectedItem as Cliente; // Cliente seleccionado en el ListBox.-

            // Completar los TextBox con los datos del cliente seleccionado.-
            txtCodCliente.Text = clienteSeleccionado.CodCliente.ToString();
            txtCliente.Text = clienteSeleccionado.NombreApellido;
            txtDocumento.Text = clienteSeleccionado.Documento;
            txtEmail.Text = clienteSeleccionado.Email;
            txtLocalidad.Text = clienteSeleccionado.Localidad;
            txtCondicionIVA.Text = clienteSeleccionado.CondicionIVA;
            formBusquedaCliente.Close();
            gbxDetalleVenta.Enabled = true;

            this.BeginInvoke(new Action(() => btnBuscarProducto.Focus())); 
        }

        private void TxtFiltrarCliente_TextChanged(object? sender, EventArgs e)
        {
            CargarClientes((sender as TextBox).Text); // Filtrar la lista de clientes según el texto ingresado.-
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            // Configuración del formulario de búsqueda de productos.-
            formBusquedaProducto = new Form();
            formBusquedaProducto.StartPosition = FormStartPosition.CenterParent;
            formBusquedaProducto.MaximizeBox = false;
            formBusquedaProducto.MinimizeBox = false;
            formBusquedaProducto.Size = new Size(300, 200);
            formBusquedaProducto.Text = "BUSCAR PRODUCTO";

            // TextBox para filtrar productos.-
            txtFiltrarProducto = new TextBox();
            txtFiltrarProducto.Size = new Size(270, 30);
            formBusquedaProducto.Controls.Add(txtFiltrarProducto);
            txtFiltrarProducto.Location = new Point(6, 6);
            txtFiltrarProducto.TextChanged += TxtFiltrarProducto_TextChanged;

            // ListBox para mostrar los productos filtrados.-
            lstProductos = new ListBox();
            lstProductos.Size = new Size(270, 130);
            formBusquedaProducto.Controls.Add(lstProductos);
            lstProductos.Location = new Point(6, 32);
            CargarProducto();
            lstProductos.DisplayMember = "Nombre";
            lstProductos.ValueMember = "CodProducto";
            lstProductos.DoubleClick += LstProductos_DoubleClick;

            formBusquedaProducto.ShowDialog();
        }

        private void TxtFiltrarProducto_TextChanged(object? sender, EventArgs e)
        {
            CargarProducto((sender as TextBox).Text); // Filtrar la lista de productos según el texto ingresado.-
        }

        private void LstProductos_DoubleClick(object? sender, EventArgs e)
        {
            productoSeleccionado = (sender as ListBox).SelectedItem as Producto; // Producto seleccionado en el ListBox.-

            // Completar los TextBox con los datos del producto seleccionado.-
            txtCodProducto.Text = productoSeleccionado.CodProducto.ToString();
            txtProducto.Text = productoSeleccionado.Nombre;
            formBusquedaProducto.Close();

            this.BeginInvoke(new Action(() =>
            {
                numCantidad.Enabled = true;
                numCantidad.Value = 1;
                btnAgregarProducto.Enabled = true;
                numCantidad.Focus();
            }));
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Verificar si el producto ya fue agregado a la lista de productos seleccionados.-
            ProductoSeleccionado productoExiste = productosSeleccionados
                .FirstOrDefault(x => x.CodProducto == productoSeleccionado.CodProducto);

            if (productoExiste != null) // Si el producto ya existe, actualizar la cantidad.-
            {
                productoExiste.Cantidad = (int)numCantidad.Value;
                int idx = productosSeleccionados.IndexOf(productoExiste);
                productosSeleccionados.ResetItem(idx);
            }
            else // Si el producto no existe, agregarlo a la lista de productos seleccionados.-
            {
                productosSeleccionados.Add(new ProductoSeleccionado
                {
                    CodProducto = productoSeleccionado.CodProducto,
                    Nombre = productoSeleccionado.Nombre,
                    PrecioUnitario = productoSeleccionado.PrecioUnitario,
                    Cantidad = (int)numCantidad.Value
                });
            }

            dgvDetalleVenta.Refresh();
            dgvDetalleVenta.ClearSelection();
            btnModificarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
            btnAgregarProducto.Enabled = false;
            btnGenerarVenta.Enabled = true;
            lblTotal.Text = $"{productosSeleccionados.Sum(x => x.SubTotal).ToString("$ #,##0.00")}"; // Actualizar el total de la venta.-
            txtCodProducto.Text = string.Empty;
            txtProducto.Text = string.Empty;
            numCantidad.Enabled = false;
            btnBuscarProducto.Focus();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.CurrentRow?.DataBoundItem is ProductoSeleccionado item) // Producto seleccionado en el DataGridView.-
            {
                txtCodProducto.Text = item.CodProducto.ToString();
                txtProducto.Text = item.Nombre;
                numCantidad.Value = Math.Max(numCantidad.Minimum,
                                      Math.Min(numCantidad.Maximum, item.Cantidad));

                // Buscar el producto en el listado de productos para tener el precio unitario.-
                productoSeleccionado = listadoProductos
                    .FirstOrDefault(x => x.CodProducto == item.CodProducto);
            }

            numCantidad.Enabled = true;
            btnAgregarProducto.Enabled = true;
            numCantidad.Focus();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.CurrentRow?.DataBoundItem is ProductoSeleccionado item) // Producto seleccionado en el DataGridView.-
            {
                // Confirmar la eliminación del producto.-
                DialogResult resp = MessageBox.Show(
                    $"¿Eliminar {item.Nombre} (Cod {item.CodProducto})?",
                    "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    productosSeleccionados.Remove(item);  
                }
            }

            if (dgvDetalleVenta.Rows.Count > 0)
            {
                btnModificarProducto.Enabled = false;
                btnEliminarProducto.Enabled = false;
                btnGenerarVenta.Enabled = true;
            }
            else { 
                btnModificarProducto.Enabled = false;
                btnEliminarProducto.Enabled = false;
                btnGenerarVenta.Enabled = false;
                lblTotal.Text = string.Empty;
            }
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta generada con éxito!", "VENTA DE MERCADERIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodCliente.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCondicionIVA.Text = string.Empty;
            txtLocalidad.Text = string.Empty;
            productosSeleccionados.Clear();
            dgvDetalleVenta.Refresh();
            gbxDetalleVenta.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
            btnGenerarVenta.Enabled = false;
            lblTotal.Text = string.Empty;
        }

        private void dgvDetalleVenta_SelectionChanged(object sender, EventArgs e)
        {
            btnModificarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
        }

        public void ConfigurarDataGrid()
        {
            // ENCABEZADO
            dgvDetalleVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alineación encabezado.-
            dgvDetalleVenta.EnableHeadersVisualStyles = false; // Deshabilitar para que funcione el la siguiente linea (BACKCOLOR).-
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray; // Color fondo del encabezado.-
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de texto del encabezado.-
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle.Font = new Font("Lato", 8, FontStyle.Bold); // Estilo del encabezado.-
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DimGray; // Color de fondo del encabezado seleccionado.-
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de texto del encabezado seleccionado.-

            // REGISTROS
            dgvDetalleVenta.ReadOnly = true; // Solo lectura.-
            dgvDetalleVenta.RowHeadersVisible = false; // No se muestra la columna anterior a la primera.-
            dgvDetalleVenta.MultiSelect = false; // Multiselección.-
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tipo de selección.-
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Autosize para todas las columnas.-
            dgvDetalleVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Autosize para todas las filas.-
            dgvDetalleVenta.DefaultCellStyle.SelectionBackColor = Color.PaleGreen; // Fondo de la fila o celda seleccionada.-
            dgvDetalleVenta.DefaultCellStyle.SelectionForeColor = Color.Black; // Color de la fila o celda seleccionada.-

            dgvDetalleVenta.Columns["CodProducto"].HeaderText = "CODIGO PRODUCTO";
            dgvDetalleVenta.Columns["CodProducto"].DefaultCellStyle.Font = new Font(dgvDetalleVenta.Font, FontStyle.Bold);
            dgvDetalleVenta.Columns["CodProducto"].DefaultCellStyle.ForeColor = Color.SteelBlue;
            dgvDetalleVenta.Columns["CodProducto"].DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            dgvDetalleVenta.Columns["CodProducto"].Width = 70;
            dgvDetalleVenta.Columns["CodProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleVenta.Columns["CodProducto"].ReadOnly = true;
            dgvDetalleVenta.Columns["Nombre"].HeaderText = "PRODUCTO";
            dgvDetalleVenta.Columns["Nombre"].DefaultCellStyle.Font = new Font(dgvDetalleVenta.Font, FontStyle.Bold);
            dgvDetalleVenta.Columns["Nombre"].DefaultCellStyle.ForeColor = Color.SteelBlue;
            dgvDetalleVenta.Columns["Nombre"].DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            dgvDetalleVenta.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalleVenta.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetalleVenta.Columns["Nombre"].ReadOnly = true;
            dgvDetalleVenta.Columns["Cantidad"].HeaderText = "CANT";
            dgvDetalleVenta.Columns["Cantidad"].Width = 50;
            dgvDetalleVenta.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleVenta.Columns["Cantidad"].ReadOnly = true;
            dgvDetalleVenta.Columns["PrecioUnitario"].HeaderText = "PRECIO UNITARIO";
            dgvDetalleVenta.Columns["PrecioUnitario"].Width = 100;
            dgvDetalleVenta.Columns["PrecioUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleVenta.Columns["PrecioUnitario"].ReadOnly = true;
            dgvDetalleVenta.Columns["SubTotal"].HeaderText = "SUBTOTAL";
            dgvDetalleVenta.Columns["SubTotal"].Width = 100;
            dgvDetalleVenta.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleVenta.Columns["SubTotal"].ReadOnly = true;
        }
    }
}
