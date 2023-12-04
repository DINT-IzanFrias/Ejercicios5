using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;

        public ObservableCollection<Plato> ListaPlatos
        {  get { return listaPlatos; }
            set { listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }

        private Plato platoSeleccionado;
        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }   

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowVM()
        {
            ListaPlatos = Plato.GetSamples(".\\imagenes");
        }
    }
}
