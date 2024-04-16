using frmSQLite.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmSQLite
{
    public class DataAccess:DbContext
    {
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }

        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<StudentiPredmeti> StudentiPredmeti { get; set; }

        public DataAccess():base("db")
        {

        }
       
    }
}
