using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }
        int a = 0;

        private void btnLoguin_Click(object sender, EventArgs e)
        {
            string User = "VAAdmin";
            string Pass = "Admin*2023";
            txtContra.Text.Equals(Pass);
            txtUsuario.Text.Equals(User);
            Form1 obj = new Form1();

            if (txtUsuario.Text.Equals(User) && txtContra.Text.Equals(Pass))
            {
                obj.ShowDialog();
                txtUsuario.Clear();
                txtContra.Clear();

            }
            else
            {
                a = a + 1;
                MessageBox.Show("Datos no encontrado, solo puede intentar 3 veces, lleva " + a + " intentos");
                txtContra.Clear();
                if (a == 3)
                {
                    MessageBox.Show("Error, no se han encontrado sus datos, saldra del programa");
                    a = 0;
                    Application.Exit();

                }
            }

        }
    }
}
