namespace ClienteWCF.Data
{
    public class Singleton
    {
        
        private static Singleton instancy;
        private Singleton conexion;

        private Singleton()
        { 

        }

        public static Singleton GetInstancy()
        {
            if (instancy == null)
            {
                instancy = new Singleton();
            }
            return instancy;

        }

        public Singleton GetConexao()
        {
            return conexion;
        }
    }
}
