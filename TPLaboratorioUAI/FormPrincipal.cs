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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            PanelForm.Dock = DockStyle.Fill;
        }


        private void btnForm1_Click(object sender, EventArgs e)
        {
            frmForm1 form1 = new frmForm1();

            form1.TopLevel = false;

            PanelForm.Controls.Add(form1);

            form1.Show();
        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnForm2_Click_1(object sender, EventArgs e)
        {
            frmForm2 form2 = new frmForm2();

            form2.TopLevel = false;

            PanelForm.Controls.Add(form2);

            form2.Show();
        }
    }
}
