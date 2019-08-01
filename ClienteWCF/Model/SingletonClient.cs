using ClienteWCF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWCF.Model
{
   public class SingletonClient
    {

        public void Grabar(string nombre, string planeta, DateTime data)
        {
            try
            {
                Singleton client = Singleton.GetInstancy();
                Singleton conexion = client.GetConexao();
            }

            catch
            {
                DataRepositorio repositorio = new DataRepositorio();
                repositorio.Guardar(nombre, planeta, data);


            }
        }
       
        

    }
}
