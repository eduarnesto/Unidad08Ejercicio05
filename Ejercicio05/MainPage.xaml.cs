using AccesoBBDD;
using BibliotecaClases;

namespace Ejercicio05
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            List<ClsPersona> lista = ListadoPersonas.getListadoPersonas();

            listaView.ItemsSource = lista;
        }

    }

}
