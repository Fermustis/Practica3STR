using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form1 : Form
    {
        string Contra1 = "12345";
        int conta1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (conta1 < 2)
            {
                if(textPassword.Text == Contra1)
                {
                    this.Hide();
                    Calculos C = new Calculos();
                    C.Show();
                }
                else
                {
                    conta1++;
                    MessageBox.Show($"Contraseña erronea, intentos restantes: {3-conta1}");
                    textPassword.Clear();

                }

            }
            else
            {
                this.Close();
            }

        }
    }
}
