using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormStergeSala : Form
    {

        public Sala SalaSelectata { get; private set; }

        public FormStergeSala(List<Sala> sali)
        {
            InitializeComponent();

            cmbSaliDeSters.DataSource = sali;
            cmbSaliDeSters.DisplayMember = "Denumire";
            cmbSaliDeSters.SelectedIndex = -1;
        }

        private void btnStergeSala_Click(object sender, EventArgs e)
        {
            if (cmbSaliDeSters.SelectedItem == null)
            {
                MessageBox.Show("Va rugam selectati o sala!");
                this.DialogResult = DialogResult.None;
                return;
            }

            SalaSelectata = (Sala)cmbSaliDeSters.SelectedItem;
            this.DialogResult = DialogResult.OK;

        }
    }

}