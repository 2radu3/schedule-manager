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
    public partial class FormAfisareOrar : Form
    {
        public FormAfisareOrar(List<ElementOrar> dateOrar, string numeProfesor)
        {
            InitializeComponent();
            this.Text = "Orar pentru: " + numeProfesor;
            ConstruiesteMatriceOrar(dateOrar);
        }

        private void ConstruiesteMatriceOrar(List<ElementOrar> date)
        {
            dvgOrarPopup.DataSource = null;
            dvgOrarPopup.Columns.Clear();
            dvgOrarPopup.Rows.Clear();

            dvgOrarPopup.Columns.Add("OraCol", "Ora");
            dvgOrarPopup.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;

            string[] zile = { "Luni", "Marti", "Miercuri", "Joi", "Vineri", "Sambata", "Duminica" };
            foreach (var zi in zile)
            {
                dvgOrarPopup.Columns.Add(zi, zi);
            }

            string[] intervale = { "07:30", "09:10", "10:50", "12:30", "14:10", "15:50", "17:30", "19:10" };

            foreach (var interval in intervale)
            {
                int r = dvgOrarPopup.Rows.Add();
                dvgOrarPopup.Rows[r].Cells[0].Value = interval;
                dvgOrarPopup.Rows[r].Height = 60;

                foreach (var curs in date)
                {
                    if (curs.IntervalOrar != null && curs.IntervalOrar.Contains(interval))
                    {
                        int indexColoana = Array.IndexOf(zile, curs.Ziua) + 1;

                        if (indexColoana > 0)
                        {
                            string info = $"{curs.DisciplinaSarcina}\n{curs.ProfesorSarcina.TitluAcademic} {curs.ProfesorSarcina.Nume} {curs.ProfesorSarcina.Prenume}\nSala: {curs.SalaSarcina.Denumire}";
                            dvgOrarPopup.Rows[r].Cells[indexColoana].Value = info;
                        }
                    }
                }
            }

            dvgOrarPopup.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dvgOrarPopup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgOrarPopup.AllowUserToAddRows = false;
            dvgOrarPopup.ReadOnly = true;
        }
    }
}
