using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolorzanoCamilyExamenP3.Modelo
{
    public class RecetaRepo
    {
        string _dbPath;
        public string StatusMessage { get; set; }
        public SQLiteConnection conn { get; set; }

        private void Init()
        {
            if (conn! == null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Receta>();
        }

        public RecetaRepo(string _dbPath)
        {
            _dbPath = _dbPath;
        }

        public void AddNewReceta(string nombre, string ingredientes, int TiempoPreparacionMinutos, bool EsVegetariana)
        {
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(nombre))
                    throw new Exception("Se requiere un nombre de la receta valido");
                result = conn.Insert(new Receta(nombre, ingredientes, TiempoPreparacionMinutos, EsVegetariana));
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Error al agregar {0}. Error {1}", nombre, ex.Message);

            }
        }

        public void UpdateReceta(Receta receta)
        {
            int result = 0;
            try
            {
                Init();
                if (receta == null || string.IsNullOrEmpty(receta.nombreReceta))
                    throw new Exception("Receta valida requerida");

            }
        }
    }

}
