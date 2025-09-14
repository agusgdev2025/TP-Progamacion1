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
    public partial class frmForm1 : Form
    {

        public frmForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbDni.Checked = true;
            rdbHombre.Checked = true;
            dtpFecNacimiento.MinDate = DateTime.Now.AddYears(-120);
            dtpFecNacimiento.MaxDate = DateTime.Now.Date;
            dtpDobleBacUltimaDosis.MinDate = DateTime.Now.AddYears(-15);
            dtpDobleBacUltimaDosis.MaxDate = DateTime.Now.Date;
            cboCovidDosis.SelectedIndex = 0;
            cboCovidDosis.Enabled = false;
            dtpDobleBacUltimaDosis.Enabled = false;
            txtNombre.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Cargo los datos en el ListBox
            lstVacunacion.Items.Add($" Nombre y Apellido:  {txtNombre.Text}, {txtApellido.Text}");
            lstVacunacion.Items.Add($" Nro. Documento:  {ObtenerTipoDocumento()} {txtNroDocumento.Text}");
            lstVacunacion.Items.Add($" Fecha de Nacimiento:  {dtpFecNacimiento.Value.ToShortDateString()}");
            lstVacunacion.Items.Add($" Localidad:  {cboLocalidad.Text}");
            lstVacunacion.Items.Add($" Género:  {ObtenerGenero()}");
            lstVacunacion.Items.Add("");
            lstVacunacion.Items.Add(" Vacunas Aplicadas:  ");

            string vacuna = string.Empty;

            foreach (Control control in gbxVacunas.Controls) // Recorro los controles del GroupBox 
            {
                if (control is CheckBox checkBox && checkBox.Checked) // Si el control es un CheckBox y está seleccionado
                {
                    vacuna = $"      - {checkBox.Text}";

                    if (checkBox.Name == "chkCovid" && checkBox.Checked) // Si es la vacuna Covid
                        vacuna += $"  ( Dosis: {cboCovidDosis.Text} )";
                    
                    if (checkBox.Name == "chkDobreBacteriana" && checkBox.Checked) // Si es la vacuna Doble Bacteriana
                        vacuna += $"  ( Última Dosis: {dtpDobleBacUltimaDosis.Value.ToShortDateString()} )";

                    lstVacunacion.Items.Add(vacuna);
                }
            }

            lstVacunacion.Items.Add("------------------------------------------------------------");
            MessageBox.Show("Registro de vacunas completado con éxito.", "Registración de vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RestablecerControles();
            txtNombre.Focus();
        }

        private string ObtenerTipoDocumento() // Método para obtener el tipo de documento seleccionado
        {
            if (rdbDni.Checked) return "DNI";
            else if (rdbLe.Checked) return "LE";
            else if (rdbLc.Checked) return "LC";
            else if (rdbPas.Checked) return "PAS";
            else return "";
        }

        private string ObtenerGenero() // Método para obtener el género seleccionado
        {
            if (rdbHombre.Checked) return rdbHombre.Text;
            else if (rdbMujer.Checked) return rdbMujer.Text;
            else if (rdbNoBinario.Checked) return rdbNoBinario.Text;
            else if (rdbOtro.Checked) return rdbOtro.Text;
            else return "";
        }

        private void chkCovid_CheckedChanged(object sender, EventArgs e) 
        {
            if (chkCovid.Checked) cboCovidDosis.Enabled = true; // Habilito el ComboBox si se selecciona la vacuna Covid
            else
            {
                cboCovidDosis.Enabled = false;
                cboCovidDosis.SelectedIndex = 0;
            }
        }

        private void chkDobreBacteriana_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDobreBacteriana.Checked) dtpDobleBacUltimaDosis.Enabled = true; // Habilito el DateTimePicker si se selecciona la vacuna Doble Bacteriana
            else
            {
                dtpDobleBacUltimaDosis.Enabled = false;
                dtpDobleBacUltimaDosis.Value = DateTime.Now.Date;
            }
        }

        private void RestablecerControles ()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            rdbDni.Checked = true;
            txtNroDocumento.Clear();
            dtpFecNacimiento.Value = DateTime.Now.Date;
            cboLocalidad.SelectedIndex = -1;
            rdbHombre.Checked = true;

            foreach (Control control in gbxVacunas.Controls) // Recorro los controles del GroupBox y si es un CheckBox lo desmarco
            {
                if (control is CheckBox checkBox)
                    checkBox.Checked = false;
            }

            cboCovidDosis.SelectedIndex = 0;
            cboCovidDosis.Enabled = false;
            dtpDobleBacUltimaDosis.Value = DateTime.Now.Date;
            dtpDobleBacUltimaDosis.Enabled = false;
        }
    }
}
