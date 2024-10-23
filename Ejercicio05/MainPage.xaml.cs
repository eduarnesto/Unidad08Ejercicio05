using AccesoBBDD;

namespace Ejercicio05
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            var lista = ListadoPersonas.getListadoPersonas();

            listaView.ItemsSource = lista;
        }

    }

}
