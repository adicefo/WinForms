namespace frmSQLite
{
    partial class frmPolozeniPredmeti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.btnDodajPolozeniđ = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnProsjekThread = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(28, 81);
            this.cmbPredmeti.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(192, 28);
            this.cmbPredmeti.TabIndex = 2;
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjene.Location = new System.Drawing.Point(277, 81);
            this.cmbOcjene.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(105, 28);
            this.cmbOcjene.TabIndex = 3;
            // 
            // btnDodajPolozeniđ
            // 
            this.btnDodajPolozeniđ.BackColor = System.Drawing.Color.Gold;
            this.btnDodajPolozeniđ.Location = new System.Drawing.Point(666, 75);
            this.btnDodajPolozeniđ.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDodajPolozeniđ.Name = "btnDodajPolozeniđ";
            this.btnDodajPolozeniđ.Size = new System.Drawing.Size(204, 37);
            this.btnDodajPolozeniđ.TabIndex = 4;
            this.btnDodajPolozeniđ.Text = "DodajPolozeniPredmet";
            this.btnDodajPolozeniđ.UseVisualStyleBackColor = false;
            this.btnDodajPolozeniđ.Click += new System.EventHandler(this.btnDodajPolozeniđ_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 81);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.DatumPolaganja,
            this.Ocjena});
            this.dataGridView1.Location = new System.Drawing.Point(10, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(863, 273);
            this.dataGridView1.TabIndex = 6;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 15;
            this.Predmet.Name = "Predmet";
            this.Predmet.Width = 200;
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.DataPropertyName = "DatumPolaganja";
            this.DatumPolaganja.HeaderText = "DatumPolaganja";
            this.DatumPolaganja.MinimumWidth = 15;
            this.DatumPolaganja.Name = "DatumPolaganja";
            this.DatumPolaganja.Width = 200;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 15;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.Width = 300;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Red;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Location = new System.Drawing.Point(666, 472);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(204, 54);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "PrintUvjerenje";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnProsjekThread
            // 
            this.btnProsjekThread.BackColor = System.Drawing.Color.Gold;
            this.btnProsjekThread.Location = new System.Drawing.Point(666, 128);
            this.btnProsjekThread.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnProsjekThread.Name = "btnProsjekThread";
            this.btnProsjekThread.Size = new System.Drawing.Size(198, 36);
            this.btnProsjekThread.TabIndex = 8;
            this.btnProsjekThread.Text = "ProsjekOcjena";
            this.btnProsjekThread.UseVisualStyleBackColor = false;
            this.btnProsjekThread.Click += new System.EventHandler(this.btnProsjekThread_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dodaj novi predmet";
            // 
            // frmPolozeniPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProsjekThread);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDodajPolozeniđ);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.cmbPredmeti);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmPolozeniPredmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPolozeniPredmeti";
            this.Load += new System.EventHandler(this.frmPolozeniPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.Button btnDodajPolozeniđ;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnProsjekThread;
        private System.Windows.Forms.Label label1;
    }
}