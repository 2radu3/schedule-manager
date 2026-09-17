using Project.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    public partial class FormStergeMaterie : Form
    {
        public Disciplina MaterieSelectata { get; private set; }

        public FormStergeMaterie(List<Disciplina> discipline)
        {
            InitializeComponent();

            cmbStergeMaterie.DataSource = discipline;
            cmbStergeMaterie.DisplayMember = "Denumire";
            cmbStergeMaterie.SelectedIndex = -1;
        }

        private void btnStergeMaterie_Click(object sender, EventArgs e)
        {
            if (cmbStergeMaterie.SelectedItem == null)
            {
                MessageBox.Show("Va rugam selectati o materie de sters!");
                return;
            }

            MaterieSelectata = (Disciplina)cmbStergeMaterie.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}