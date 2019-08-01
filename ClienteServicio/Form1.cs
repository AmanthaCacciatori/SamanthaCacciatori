using ClienteServicio.BO;
using ClienteServicio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RepositorioClienteWCF repositorio = new RepositorioClienteWCF();
           // repositorio.GrabarLista(txtNombre.Text, txtPlaneta.Text);
        }
    }
}
