using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Trabalho_POO.Triangulo.Controle controle = new Trabalho_POO.Triangulo.Controle(txtLado1.Text, txtLado2.Text, txtLado3.Text);

            lblResposta.Text = controle.Resposta;
        }
    }
}
