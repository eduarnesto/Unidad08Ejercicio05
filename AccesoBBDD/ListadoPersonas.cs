using System.Collections.ObjectModel;

namespace AccesoBBDD
{
    // All the code in this file is included in all platforms.
    public class ListadoPersonas<clsPersona>
    {
        public static List<clsPersona> getListadoPersonas() {
            List<clsPersona> Personas = [
                    new clsPersona () {nombre = "Pepe"})
                ];

            return personas;
        }
        
    }
}
