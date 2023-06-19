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

        private void Validar()
        {
            if(txtUsuario.Text != string.Empty && txtContra.Text != string.Empty)
            {
                btnLoguin.Enabled = true;
               
                
            }
            else
            {
                btnLoguin.Enabled = false;
            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           Validar();
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }
        private void btnLoguin_Click(object sender, EventArgs e)
        {
            string User = "Admin";
            string Pass = "Admin2023";
            txtContra.Text.Equals(Pass);
            txtUsuario.Text.Equals(User);
            Form2 obj = new Form2();
            

            if (txtUsuario.Text.Equals(User) && txtContra.Text.Equals(Pass))
            {
                obj.ShowDialog();
                txtUsuario.Clear();
                txtContra.Clear();
                this.Hide();

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

        private void frmLoguin_Load(object sender, EventArgs e)
        {
            btnLoguin.Enabled = false;
        }
    }
}
