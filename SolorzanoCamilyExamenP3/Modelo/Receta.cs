using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolorzanoCamilyExamenP3.Modelo
{
    using SQLite;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Windows.Media.Capture.Frames;

    public class Receta : INotifyPropertyChanged
    {
        private int idReceta;
        private String nombreReceta { get; set; }
        private String ingredientesReceta { get; set; }
        private int TiempoPreparacionMinutos { get; set; }
        private bool EsVegetariana { get; set; }

        public Receta()
        {
            nombreReceta = string.Empty;
            ingredientesReceta = string.Empty;
            TiempoPreparacionMinutos = 0;
            EsVegetariana = false;
        }

        public Receta(string nombreRecetap, string ingredientesRecetap, int TiempoPreparacionMinutosp, bool EsVegetarianap)
        {
            nombreReceta = nombreRecetap ?? string.Empty;
            ingredientesReceta = ingredientesRecetap ?? string.Empty;
            TiempoPreparacionMinutos = TiempoPreparacionMinutosp;
            EsVegetariana = EsVegetarianap;
        }

        [PrimaryKey, AutoIncrement]
        public int idReceta
        {
            get => idReceta;
            set => SetProperty(ref idReceta, value);
        }
        [MaxLength(80)]
        public string nombreReceta;
         {
            get => nombreReceta;
            set => SetProperty(ref nombreReceta, value);
        }

        [MaxLength(1000)]
        public string ingredientesReceta;
         {
            get => ingredientesReceta;
            set => SetProperty(ref ingredientesReceta, value);
        }


        public int TiempoPreparacionMinutos;
         {
            get => TiempoPreparacionMinutos;
            set => SetProperty(ref TiempoPreparacionMinutos, value);
        }

        public bool EsVegetariana;
         {
            get => EsVegetariana;
            set => SetProperty(ref EsVegetariana, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            OnPropertyChanged(propertyName);
            return true;
        }

    }
}
