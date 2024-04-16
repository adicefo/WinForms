﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmSQLite.Classes
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmeti
    {
        public int ID { get; set; }
        public  virtual Student Student { get; set; }

        public virtual Predmet Predmet { get; set; }

        public int Ocjena { get; set; }
        public  string DatumPolaganja { get; set; }




    }
}
