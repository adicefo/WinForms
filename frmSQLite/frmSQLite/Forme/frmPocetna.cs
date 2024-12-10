using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSQLite.Forme_Reporti
{
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Size = new Size(700, 350);
        }
        private void PrikaziFormu(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }


        private void openSQLiteFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmSQLite());

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poruka = MessageBox.Show("Zelite li ugasiti formu?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (poruka == DialogResult.Yes)
            {
                 var poruka2 = MessageBox.Show("Neki podaci mozda nece biti spremljeni. "+Environment.NewLine+"Zelite li sigurno ugasiti aplikaciju?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if( poruka2 == DialogResult.Yes)
                    Application.Exit();
            }
        }
    }
}
