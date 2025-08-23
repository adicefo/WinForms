using frmSQLite.Classes;
using frmSQLite.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSQLite
{
    public partial class frmPolozeniPredmeti : Form
    {
        private Student student;

        DataAccess db = DataAccessDispecher.Konekcija;


        public frmPolozeniPredmeti(Student s = null)
        {
            InitializeComponent();
            this.student = s ?? new Student();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            this.Size = new Size(650, 400);
            try
            {
                UcitajPredmete();
                UcitajPolozenePredmete();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private void UcitajPolozenePredmete()
        {
            dataGridView1.DataSource = null;
            var polozeni = db.StudentiPredmeti.Include("Predmet").Where(s => s.Student.ID == student.ID).ToList();
            dataGridView1.DataSource = polozeni;
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = db.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "ID";
        }

        private void btnDodajPolozeniđ_Click(object sender, EventArgs e)
        {
            if (NePostojiPredmet()&&Validiraj())
            {
                var obj = new StudentiPredmeti()
                {
                    Student = this.student,
                    Predmet = cmbPredmeti.SelectedItem as Predmet,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    DatumPolaganja = dateTimePicker1.Value.ToString("yyyy-MM-dd")

                };
                db.StudentiPredmeti.Add(obj);
                db.SaveChanges();
                MessageBox.Show("Uspjesno dodan predmet", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajPolozenePredmete();
            }
            else
                MessageBox.Show("Predmet vec postoji ili unesite validnu ocjenu i datum", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private bool Validiraj()
        {
            return cmbOcjene.Text.Length > 0 && dateTimePicker1.Value < DateTime.Now;
        }


        private bool NePostojiPredmet()
        {
            var odabrani = cmbPredmeti.SelectedItem as Predmet;
            return db.StudentiPredmeti.Where(obj => 
            obj.Student.ID == student.ID && obj.Predmet.Naziv == odabrani.Naziv).Count() == 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dtoObj = new dtoUvjerenje()
            {
                BrojIndeksa = student.BrojIndeksa,
                ImePrezime = student.ImePrezime,
                Polozeni = dataGridView1.DataSource as List<StudentiPredmeti>,
            };
            
            Form frmIzvjestaj = new frmIzvjestaj(dtoObj);
            frmIzvjestaj.ShowDialog();
        }

        private  void btnProsjekThread_Click(object sender, EventArgs e)
        {
            //jedan od nacina
            //Thread t1 = new Thread(IzracunajProsjek);

             Task.Run(() => IzracunajProsjek());
        }

        private void IzracunajProsjek()
        {
            Action akt = () => GetProsjek();
            BeginInvoke(akt);
        }

        private void GetProsjek()
        {
            Thread.Sleep(2000);

            var suma = 0.0f;
            var polozeniPredmeti = db.StudentiPredmeti.Where(s => s.Student.ID == student.ID).ToList();
            if (polozeniPredmeti.Count == 0)
            {
                MessageBox.Show("Error", "Greska",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        //ako nije nula racunaj
            foreach (var obj in polozeniPredmeti)
                suma += obj.Ocjena;
            var prosjek = Math.Round(suma / polozeniPredmeti.Count, 2);
             MessageBox.Show("Prosjek ocjena studenta je "+ prosjek
                , "Info" ,MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}

