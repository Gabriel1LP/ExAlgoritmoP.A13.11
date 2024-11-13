using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAlgoritmoP.A13._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbN3.Items.Clear();
            int primeriotermo = int.Parse(txtN1.Text);
            int razao = int.Parse(txtN2.Text);

            int numerotermos = 10;
            int contador = 0;

            while ( contador < numerotermos)
            {
                int termoatual = primeriotermo + contador * razao;
                lsbN3.Items.Add( termoatual );
                contador ++;

            }
  


        }
    }
}
