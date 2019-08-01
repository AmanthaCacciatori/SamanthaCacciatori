using ClienteServicio.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfPersonas;
using Persona = ClienteServicio.BO.Persona;

namespace ClienteServicio.Model
{
    class RepositorioClienteWCF
    {
        ServiceReference1.Service1Client objServiceClientobjService = new ServiceReference1.Service1Client();
        List<Persona> listaUsuarios = new List<Persona>();
        
        public void GrabarLista()
        {
         
            listaUsuarios.Add(new Persona { Nombre = "Carlos", Planeta = "Marte", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Jose", Planeta = "Jupiter", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Vantuil", Planeta = "Tierra", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Julia", Planeta = "Venus", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Jose Carlos", Planeta = "Urano", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Maria", Planeta = "Mercurio", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Antonio", Planeta = "Saturno", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Carolina", Planeta = "Neptuno", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Marcelo", Planeta = "Tierra", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Lucia", Planeta = "Tierra", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Emilio", Planeta = "Tierra", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Marina", Planeta = "Marte", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Geovana", Planeta = "Neptuno", Data = DateTime.Now });
            listaUsuarios.Add(new Persona { Nombre = "Henrique", Planeta = "Marte", Data = DateTime.Now });



            


        }

      


    }
}
