namespace BibliotecaClases
{
    // All the code in this file is included in all platforms.
    public class ClsPersona
    {
        #region Propiedades

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        #endregion

        #region constructor

        public ClsPersona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        #endregion
    }
}
