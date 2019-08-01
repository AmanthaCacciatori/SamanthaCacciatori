using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWCF.Data.Repository
{
    interface IDataRepository
    {

        void Guardar(string nombre, string planeta, DateTime data);
    }
}
