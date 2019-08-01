using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPersonas
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void InserirDetalhesUsuario(List<Persona> listaUsuarios);

       
    }

    [DataContract]
    public class Persona
    {
        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Planeta { get; set; }

        [DataMember]
        public DateTime Data { get; set; }
    }
}
