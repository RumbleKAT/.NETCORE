using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ideacore.Models
{
    
    public class ideaRepository
    {
        private SqlConnection db;

        public ideaRepository()
        {
            db = new SqlConnection("server=(localdb)\\mssqllocaldb;database=Idea;Integrated Security=true");
            
        }

        public List<idea> getAll()
        {
            return db.Query<idea>("Select * From Ideas").ToList();
        }

        public void add(idea model)
        {
            db.Execute("Insert into Ideas Values(@Note);", model);
        }
    }
}
