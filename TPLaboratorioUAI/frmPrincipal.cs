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
    public partial class frmPrincipal : Form
    {
        frmForm1 form1;
        frmForm2 form2;

        public frmPrincipal()
        {
            InitializeComponent();

            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            if (form2 != null) form2.Close();

            form1 = new frmForm1();
            form1.MdiParent = this;
            pnlRight.Controls.Add(form1);
            form1.WindowState = FormWindowState.Maximized;
            form1.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            if (form1 != null) form1.Close();

            form2 = new frmForm2();
            form2.MdiParent = this;
            pnlRight.Controls.Add(form2);
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }
    }
}
