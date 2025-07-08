using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolorzanoCamilyExamenP3.Modelo
{
    using SQLite;
    using System.ComponentModel;
    using Windows.Media.Capture.Frames;

    public class Receta : INotifyPropertyChanged
    {
        private int idReceta;
        private String nombreReceta { get; set; }
        private String ingredientesReceta { get; set;}
        private int TiempoPreparacionMinutos { get; set;}
        private bool EsVegetariana { get; set;}

        public Receta()
        {
            nombreReceta = string.Empty;
            ingredientesReceta = string.Empty;
            TiempoPreparacionMinutos = 0;
            EsVegetariana = false;
        }

        public Receta (string nombreRecetap, string ingredientesRecetap, int TiempoPreparacionMinutosp, bool EsVegetarianap)
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









    }
}
