﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmSQLite.Classes
{
    [Table("Predmeti")]
    public class Predmet
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }

    }
}