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
                if 
            }
        }
    }

}
