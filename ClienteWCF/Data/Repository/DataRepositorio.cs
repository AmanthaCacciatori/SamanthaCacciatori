using ClienteWCF.Data.Repository;
using ClienteWCF.Model;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace ClienteWCF.Data

{
   public  class DataRepositorio : IDataRepository
    {
        
        public void Guardar(string nombre,string planeta, DateTime data)
        {
            String camino = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                using (DataSet dsResultado = new DataSet())
                {
                    dsResultado.ReadXml(CaminoDadosXML(camino) + @"Data\Personas.xml");
                    if (dsResultado.Tables.Count == 0)
                    {
                        Persona persona = new Persona();

                        persona.Nombre = nombre;
                        persona.Planeta = planeta;
                        persona.Data = DateTime.Now;

                        XmlTextWriter writer = new XmlTextWriter(CaminoDadosXML(camino) + @"Data\Personas.xml", System.Text.Encoding.UTF8);

                        writer.WriteStartDocument(true);
                        writer.Formatting = Formatting.Indented;
                        writer.Indentation = 2;
                        writer.WriteStartElement("Persona");

                        writer.WriteStartElement("Nombre");
                        writer.WriteString(persona.Nombre);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Planeta");
                        writer.WriteString(persona.Planeta);
                        writer.WriteEndElement();


                        writer.WriteStartElement("Data");
                        writer.WriteString(persona.Data.ToString());
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();
                        dsResultado.ReadXml(CaminoDadosXML(camino) + @"Data\Personas.xml");
                    }
                    else
                    {
                       
                        dsResultado.WriteXml(CaminoDadosXML(camino) + @"Data\Personas.xml", XmlWriteMode.IgnoreSchema);
                    }
                   
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public static string CaminoDadosXML(string camino)
        {
            if (camino.IndexOf("\\bin\\Debug") != 0)
            {
                camino = camino.Replace("\\bin\\Debug", "");
            }
            return camino;


        }

    }
}
