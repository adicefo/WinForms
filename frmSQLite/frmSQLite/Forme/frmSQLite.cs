using frmSQLite.Classes;
using frmSQLite.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSQLite
{
    public partial class frmSQLite : Form
    {
  
        DataAccess db = DataAccessDispecher.Konekcija;


        public frmSQLite()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Size = new Size(650, 400);
            try
            {
                UcitajStudente();
                UcitajSpolove();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{Environment.NewLine}" +
                      $" {ex.InnerException?.Message}");
            }
           
        }

        private void UcitajSpolove()
        {
            cmbSpol.DataSource = db.Spolovi.ToList();
        }

        private  void UcitajStudente()
        {
           dataGridView1.DataSource = db.Studenti.Include("Spol").ToList();
        }

      
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dataGridView1.SelectedRows[0].DataBoundItem as Student;
            Form forma = null;
            if (student != null)
            {
                if (dataGridView1.CurrentCell is DataGridViewButtonCell)
                    forma = new frmPolozeniPredmeti(student);
                else
                    forma = new frmPolozeniPredmeti(student);
                if (forma.ShowDialog() == DialogResult.OK)
                    UcitajStudente();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(Validacija()&&!PostojiStudent())
            {
                var noviStudent = new Student()
                {
                    BrojIndeksa=txtBrojIndeksa.Text,
                    ImePrezime=txtImePrezime.Text,
                    Spol=cmbSpol.SelectedItem as Spol ,
                };
                db.Studenti.Add(noviStudent);
                db.SaveChanges();
                MessageBox.Show("Uspjesno dodan student", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UcitajStudente();
            }
            else
                MessageBox.Show("Greska pri dodavanju","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool PostojiStudent()
        {
            return db.Studenti.Where(s => 
            s.ImePrezime == txtImePrezime.Text ||
            s.BrojIndeksa == txtBrojIndeksa.Text).Any();
        }

        private bool Validacija()
        {
            return !string.IsNullOrWhiteSpace(txtBrojIndeksa.Text)
                && !string.IsNullOrWhiteSpace(txtImePrezime.Text)
                && (cmbSpol.Text == "Muski" || cmbSpol.Text == "Zenski");
                

        }
    }
}
