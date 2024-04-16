using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmSQLite.Classes
{
     public class dtoUvjerenje
    {
        public string BrojIndeksa { get; set; }
        public string ImePrezime { get; set; }

        public List<StudentiPredmeti> Polozeni { get; set; }

    }
}
