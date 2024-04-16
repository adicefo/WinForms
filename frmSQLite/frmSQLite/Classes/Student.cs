using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Assemblies;
using frmSQLite.Classes;

namespace frmSQLite
{
    [Table("Studenti")]

    public class Student
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
        public virtual Spol Spol { get; set; } = new Spol();
        
        private static int id = 0;

        public Student()
        {
            ID = id++;
            ImePrezime = "notSet";
            BrojIndeksa = "notSet";
        }

        public override string ToString()
        {
            return ImePrezime;
        }

    }
}
