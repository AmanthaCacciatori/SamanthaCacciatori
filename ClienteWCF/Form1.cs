using ClienteWCF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWCF
{
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();

            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client objServiceClientobjService = new ServiceReference1.Service1Client();

            try
            {
                Persona userInfo = new Persona();
                userInfo.Nombre= txtNombre.Text;
                userInfo.Planeta = txtPlaneta.Text;

                List<Object> listaUsuario = new List<Object>();
                listaUsuario.Add(new Persona { Nombre = txtNombre.Text,Planeta= txtPlaneta.Text, Data = DateTime.Now  });

                string resultado = objServiceClientobjService.InserirDetalhesUsuario(listaUsuario);
                lblMensagem.Text = resultado;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }



            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SingletonClient client = new SingletonClient();
            client.Grabar(txtNombre.Text, txtPlaneta.Text, DateTime.Now);
        }
    }
}
