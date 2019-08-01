using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClienteWCF.Data;
using ClienteWCF.Model;


namespace PruebasUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SingletonClient test = new SingletonClient();
            test.Grabar("Lucia", "Marte", DateTime.Today);
            test.ToString();

        }

        [TestMethod]
        public void TestMethod2()
        {
            DataRepositorio connection = new DataRepositorio();
            connection.Guardar("Lucia", "Marte", DateTime.Today);
            connection.ToString();

        }

        public void TestMethod3()
        {
            Persona persona = new Persona();
            persona.Nombre = "hdjshdufi44938498,.-'49jkn";
            persona.Planeta.GetType();
            persona.Data.GetType();
        }

        public void TestMethod4()
        {
            Persona persona = new Persona();
           
            persona.Data = Convert.ToDateTime("2013-01-7 12:00:00");
        }

        public void TestMethod5()
        {
            Singleton singleton = null;

            singleton.GetConexao();
        }
    }
}
