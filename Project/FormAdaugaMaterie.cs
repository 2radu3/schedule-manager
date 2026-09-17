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
    public partial class FormAdaugaMaterie : Form
    {
        public Disciplina MaterieNoua { get; private set; }
        private List<Disciplina> _disciplineExistente;

        public FormAdaugaMaterie(List<Disciplina> discipline)
        {
            InitializeComponent();
            _disciplineExistente = discipline;
        }

        private void btnAdaugaMaterie_Click(object sender, EventArgs e)
        {
            string numeMaterie = tbAdaugaMaterie.Text.Trim();

            if (string.IsNullOrWhiteSpace(numeMaterie))
            {
                MessageBox.Show("Introduceti numele disciplinei!", "Camp gol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool exista = _disciplineExistente.Any(d => d.Denumire.Equals(numeMaterie, StringComparison.OrdinalIgnoreCase));

            if (exista)
            {
                MessageBox.Show("Disciplina exista deja!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nouId = _disciplineExistente.Count > 0 ? _disciplineExistente.Max(d => d.Id) + 1 : 1;

            MaterieNoua = new Disciplina
            {
                Id = nouId,
                Denumire = numeMaterie
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
