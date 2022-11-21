using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_form_P3_GP2223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            numPalabras = cuentaPalabras(textoTelegrama);
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste =((numPalabras - 10) * 0.5) + 2.5;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";

        }
        private int cuentaPalabras(string telegrama) 
        {
            int cont = 1;
            for (int i = 1; i < telegrama.Length; i++)
            {
                if(telegrama[i] == ' ' && telegrama[i - 1] != ' ' ) 
                {
                    cont++;
                }
            }
            return cont;
        }
    }
}
