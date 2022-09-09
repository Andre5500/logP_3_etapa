using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int valor = 2;
            while(valor<=256)
            {
                lblDWhileResultado.Text += valor + " ";
                lblForResultado.Text += valor + " ";
                lblWhileResultado.Text += valor + " ";
                valor *= 2;
            }
        }
    }
}
