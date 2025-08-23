using frmSQLite.Classes;
using frmSQLite.DB;
using frmSQLite.Forme;
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
            this.Size = new Size(700, 400);
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
            var filterStudenti = db.Studenti.Include("Spol").ToList();
            if (cmbSpol.SelectedItem != null)
                filterStudenti = filterStudenti.Where(s => s.Spol.Naziv == cmbSpol.Text).ToList();
            if(txtImePrezime.Text.Length > 0)
                filterStudenti = filterStudenti.Where(s => s.ImePrezime.StartsWith(txtImePrezime.Text)).ToList();
            if (txtBrojIndeksa.Text.Length > 0)
                filterStudenti = filterStudenti.Where(s => s.BrojIndeksa == txtBrojIndeksa.Text).ToList();
            dataGridView1.DataSource= filterStudenti;
        }

       

        private void btnAddStudent2_Click(object sender, EventArgs e)
        {
            var forma = new frmDodaj();

            
            forma.FormClosed += (s, args) =>
            {
                UcitajStudente();
            };

            forma.ShowDialog();
        }

        
    }
}
