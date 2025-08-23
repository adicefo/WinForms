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

namespace frmSQLite.Forme
{
    public partial class frmDodaj : Form
    {
        DataAccess db = DataAccessDispecher.Konekcija;
        public frmDodaj()
        {
            InitializeComponent();
        }

        private void frmDodaj_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Size = new Size(600, 400);
            try
            {
               
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
            comboBox1.DataSource = db.Spolovi.ToList();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (Validacija()&&!PostojiStudent())
            {
                var student = new Student();
                student.BrojIndeksa = textBox1.Text;
                student.ImePrezime = textBox2.Text;
                student.Spol = comboBox1.SelectedItem as Spol;
                db.Studenti.Add(student);
                db.SaveChanges();
                MessageBox.Show("Uspjesno dodan student", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Student već postoji", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private bool PostojiStudent()
        {
            return db.Studenti.Where(s =>
            s.ImePrezime == textBox2.Text ||
            s.BrojIndeksa == textBox1.Text).Any();
        }
        private bool Validacija()
        {
            return !string.IsNullOrWhiteSpace(textBox1.Text)
                && !string.IsNullOrWhiteSpace(textBox2.Text)
                && (comboBox1.Text == "Muski" || comboBox1.Text == "Zenski");


        }
    }
}
