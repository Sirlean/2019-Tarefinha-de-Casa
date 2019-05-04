using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirlean.Projeto001.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            var entrada = txtEntrada.Text;
            string texto = FormatarEntrada(entrada);
            lblResultado.Text = texto;
        }

        private string FormatarEntrada(string entrada)
        {
            return string.Format("Seu nome é: {0}.", entrada);
        }
    }
}
