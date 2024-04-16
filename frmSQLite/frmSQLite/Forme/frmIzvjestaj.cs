using frmSQLite.Classes;
using frmSQLite.DB;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSQLite
{
    public partial class frmIzvjestaj : Form
    {

        private dtoUvjerenje podaci;
        public frmIzvjestaj(dtoUvjerenje obj)
        {
            InitializeComponent();
            this.podaci= obj??new dtoUvjerenje();

        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            this.Size = new Size(650, 500);

            ReportParameterCollection parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("BrojIndeksa", podaci.BrojIndeksa));
            parametri.Add(new ReportParameter("ImePrezime", podaci.ImePrezime));


            var tblPolozeniPredmeti = new List<object>();
            float suma = 0.0f;
            for (int i = 0; i < podaci.Polozeni.Count; i++)
            {
                tblPolozeniPredmeti.Add(new
                {
                    ID = i+1,
                    Naziv = podaci.Polozeni[i].Predmet.Naziv,
                    Ocjena = podaci.Polozeni[i].Ocjena,
                    Datum = podaci.Polozeni[i].DatumPolaganja,
                });
                suma += podaci.Polozeni[i].Ocjena;
            }
            double prosjek = 0;
            if(tblPolozeniPredmeti.Count>0)
                 prosjek = Math.Round(suma / tblPolozeniPredmeti.Count, 2);

            //dodavanje prosjeka u listu parametara
            parametri.Add(new ReportParameter("Prosjek", prosjek.ToString()));


            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "dsPolozeni";
            dataSource.Value = tblPolozeniPredmeti;
            

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.SetParameters(parametri);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
