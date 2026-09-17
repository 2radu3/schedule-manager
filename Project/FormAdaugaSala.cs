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
    public partial class FormAdaugaSala : Form
    {
        public Sala SalaNoua { get; set; }
        private List<Sala> _saliExistente;

        public FormAdaugaSala(List<Sala> sali)
        {
            InitializeComponent();
            _saliExistente = sali;

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string numeNou = tbNume.Text.Trim();

            if (string.IsNullOrWhiteSpace(tbNume.Text))
            {
                MessageBox.Show("Introduceti numele salii!");
                this.DialogResult = DialogResult.None;
                return;
            }

            bool existaDeja = _saliExistente.Any(s => s.Denumire.Equals(numeNou, StringComparison.OrdinalIgnoreCase));

            if (existaDeja)
            {
                MessageBox.Show("Sala exista deja in sistem", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SalaNoua = new Sala
            {
                Denumire = tbNume.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}