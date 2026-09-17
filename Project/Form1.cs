using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project
{
    public partial class Form1 : Form
    {
        private List<Sala> listaSali;
        private List<Disciplina> listaDiscipline;
        private List<string> listaIntervaleOrare;
        private List<Profesor> listaProfesori;

        private List<ElementOrar> listaOrarGlobal = new List<ElementOrar>();

        public Form1()
        {
            InitializeComponent();

            listaProfesori = new List<Profesor>();

            listaProfesori.Add(new Profesor { Id = 1, Nume = "Ionescu", Prenume = "Andrei", TitluAcademic = "Conf. Dr." });

            ActualizeazaTabel();
            ActualizeazaInterfata();
        }

        private void ActualizeazaTabel()
        {
            dgvProfesori.DataSource = null;
            dgvProfesori.DataSource = listaProfesori;
            cmbProfesor.DataSource = null;
            cmbProfesor.DataSource = listaProfesori;
            cmbProfesor.SelectedIndex = -1;
        }

        private void InitializareValoriDefault()
        {
            listaSali = new List<Sala>
            {
                new Sala {Denumire = "Amf. III", Capacitate = 100 },
                new Sala {Denumire = "2104", Capacitate = 100 },
                new Sala {Denumire = "2016", Capacitate = 20 },
                new Sala {Denumire = "B202", Capacitate = 30 },
                new Sala {Denumire = "2415", Capacitate = 20 },
                new Sala {Denumire = "2017", Capacitate = 25 },
                new Sala {Denumire = "2102", Capacitate = 100 },
                new Sala {Denumire = "2013B", Capacitate = 20 },
                new Sala {Denumire = "2103", Capacitate = 100 }
            };

            listaDiscipline = new List<Disciplina>
            {
                new Disciplina { Id = 1, Denumire = "Programarea Aplicatiilor Windows" },
                new Disciplina { Id = 2, Denumire = "SGBD Oracle" },
                new Disciplina { Id = 3, Denumire = "Programare multiparadigma - Java" },
                new Disciplina { Id = 3, Denumire = "Macroeconomie Cantitativa" },
                new Disciplina { Id = 3, Denumire = "Programare evolutiva si algoritmi genetici" },
                new Disciplina { Id = 3, Denumire = "Managementul riscului in afaceri internationale" },
                new Disciplina { Id = 3, Denumire = "Structuri de Date" }
            };

            listaIntervaleOrare = new List<string> { "07:30", "09:10", "10:50", "12:30", "14:10", "15:50", "17:30", "19:10" };
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(tbNume.Text) || string.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                MessageBox.Show("Castele nu pot fi lasate goale!", "Eroare de completare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTitlu.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza un titlu academic!", "Eroare selectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Profesor nou = new Profesor
            {
                Id = listaProfesori.Count + 1,
                Nume = tbNume.Text,
                Prenume = tbPrenume.Text,
                TitluAcademic = cmbTitlu.Text
            };

            listaProfesori.Add(nou);

            AdaugaProfesorInDB(nou.Nume, nou.Prenume, nou.TitluAcademic);

            ActualizeazaTabel();

            tbNume.Clear();
            tbPrenume.Clear();
            cmbTitlu.SelectedIndex = -1;

            //SalveazaInFisierText();
            ActualizeazaInterfata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializareValoriDefault();
            //IncarcaDinFisierText();
            IncarcaProfesoriDinDB();

            cmbProfesor.DataSource = null;
            cmbProfesor.DataSource = listaProfesori;
            cmbProfesor.SelectedIndex = -1;

            cmbSala.DataSource = listaSali;
            cmbSala.SelectedIndex = -1;

            cmbDisciplina.DataSource = listaDiscipline;
            cmbDisciplina.SelectedIndex = -1;

            cmbOra.DataSource = listaIntervaleOrare;
            cmbOra.SelectedIndex = -1;

            dgvProfesori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProfesori.ScrollBars = ScrollBars.Vertical;
            dgvProfesori.ReadOnly = true;
            dgvProfesori.AllowUserToAddRows = false;
            dgvProfesori.RowHeadersVisible = false;
            dgvProfesori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ContextMenuStrip meniuContextualProfesori = new ContextMenuStrip();

            ToolStripMenuItem optiuneSterge = new ToolStripMenuItem("Sterge Profesor Selectat");

            optiuneSterge.Click += OptiuneSterge_Click;

            meniuContextualProfesori.Items.Add(optiuneSterge);

            dgvProfesori.ContextMenuStrip = meniuContextualProfesori;

            //IncarcaProfesoriXML_();
        }

        private void OptiuneSterge_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void btnAdaugaInOrar_Click(object sender, EventArgs e)
        {
            Profesor profSelectat = (Profesor)cmbProfesor.SelectedItem;
            Sala salaSelectata = (Sala)cmbSala.SelectedItem;
            Disciplina discSelectata = (Disciplina)cmbDisciplina.SelectedItem;
            string oraSelectata = cmbOra.SelectedItem?.ToString();
            string ziuaNoua = cmbZiua.SelectedItem?.ToString();

            if (profSelectat == null || salaSelectata == null || discSelectata == null || string.IsNullOrEmpty(oraSelectata) || ziuaNoua == null)
            {
                MessageBox.Show("Selecteaza profesorul, sala, disciplina, ziua si ora!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var programare in listaOrarGlobal)
            {
                if (programare.Ziua == ziuaNoua && programare.IntervalOrar == oraSelectata)
                {
                    if (programare.SalaSarcina.Denumire == salaSelectata.Denumire)
                    {
                        MessageBox.Show($"Sala {salaSelectata.Denumire} este deja ocupata de {programare.ProfesorSarcina.Nume} la aceasta ora.", "Eroare suprapunere", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (programare.ProfesorSarcina.Id == profSelectat.Id)
                    {
                        MessageBox.Show($"{profSelectat.Nume} are deja un curs in sala {programare.SalaSarcina.Denumire} la aceasta ora.", "Eroare suprapunere", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            ElementOrar intrareNoua = new ElementOrar
            {
                Id = listaOrarGlobal.Count + 1,
                ProfesorSarcina = profSelectat,
                SalaSarcina = salaSelectata,
                DisciplinaSarcina = discSelectata,
                Ziua = cmbZiua.SelectedItem.ToString(),
                IntervalOrar = oraSelectata
            };

            listaOrarGlobal.Add(intrareNoua);

            MessageBox.Show($"Adaugat cu succes pentru {profSelectat.Nume}!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //SalveazaInFisierText();
        }

        private void btnAfiseazaOrar_Click(object sender, EventArgs e)
        {
            Profesor profCautat = (Profesor)cmbProfesor.SelectedItem;

            if (profCautat == null)
            {
                MessageBox.Show("Selecteaza un profesor!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ElementOrar> orarFiltrat = new List<ElementOrar>();
            foreach (var item in listaOrarGlobal)
            {
                if (item.ProfesorSarcina.Id == profCautat.Id)
                {
                    orarFiltrat.Add(item);
                }
            }

            FormAfisareOrar fereastraPopUp = new FormAfisareOrar(orarFiltrat, profCautat.ToString());
            fereastraPopUp.ShowDialog();
        }

        private void SalveazaInFisierText()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("profesori.txt"))
                {
                    foreach (var p in listaProfesori)
                    {
                        sw.WriteLine($"{p.Id}|{p.Nume}|{p.Prenume}|{p.TitluAcademic}");
                    }
                }

                using (StreamWriter sw = new StreamWriter("orar.txt"))
                {
                    foreach (var o in listaOrarGlobal)
                    {
                        sw.WriteLine($"{o.Id}|{o.ProfesorSarcina.Id}|{o.SalaSarcina.Id}|{o.DisciplinaSarcina.Id}|{o.Ziua}|{o.IntervalOrar}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void IncarcaDinFisierText()
        {
            if (!File.Exists("profesori.txt")) return;

            try
            {
                listaProfesori.Clear();
                string[] liniiProf = File.ReadAllLines("profesori.txt");
                foreach (var linie in liniiProf)
                {
                    var date = linie.Split('|');
                    listaProfesori.Add(new Profesor
                    {
                        Id = int.Parse(date[0]),
                        Nume = date[1],
                        Prenume = date[2],
                        TitluAcademic = date[3]
                    });
                }

                if (File.Exists("orar.txt"))
                {
                    listaOrarGlobal.Clear();
                    string[] liniiOrar = File.ReadAllLines("orar.txt");
                    foreach (var linie in liniiOrar)
                    {
                        var d = linie.Split('|');

                        int idProf = int.Parse(d[1]);
                        int idSala = int.Parse(d[2]);
                        int idDisc = int.Parse(d[3]);

                        listaOrarGlobal.Add(new ElementOrar
                        {
                            Id = int.Parse(d[0]),
                            ProfesorSarcina = listaProfesori.FirstOrDefault(p => p.Id == idProf),
                            SalaSarcina = listaSali.FirstOrDefault(s => s.Id == idSala),
                            DisciplinaSarcina = listaDiscipline.FirstOrDefault(disc => disc.Id == idDisc),
                            Ziua = d[4],
                            IntervalOrar = d[5]
                        });
                    }
                }

                ActualizeazaTabel();
                ActualizeazaInterfata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }

        private void btnStergeOrar_Click(object sender, EventArgs e)
        {
            Profesor profSelectat = (Profesor)cmbProfesor.SelectedItem;
            Sala salaSelectata = (Sala)cmbSala.SelectedItem;
            string ziuaSelectata = cmbZiua.SelectedItem?.ToString();
            string oraSelectata = cmbOra.SelectedItem?.ToString();

            if (profSelectat == null || salaSelectata == null || ziuaSelectata == null || oraSelectata == null)
            {
                MessageBox.Show("Selectati toate campurile pentru a identifica elementul de sters!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool gasit = false;
            for (int i = listaOrarGlobal.Count - 1; i >= 0; i--)
            {
                var item = listaOrarGlobal[i];

                if (item.ProfesorSarcina.Nume == profSelectat.Nume &&
                    item.SalaSarcina.Denumire == salaSelectata.Denumire &&
                    item.Ziua == ziuaSelectata &&
                    item.IntervalOrar == oraSelectata)
                {
                    listaOrarGlobal.RemoveAt(i);
                    gasit = true;
                    break;
                }
            }

            if (gasit)
            {
                //SalveazaInFisierText();
                MessageBox.Show("Programarea a fost stearsa cu succes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nu s-a gasit nicio programare care sa corespunda acestor selectii!");
            }
            //ActualizeazaInterfata();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalveazaInFisierText();
            MessageBox.Show("Datele au fost salvate cu succes!", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("profesori.txt") && File.Exists("orar.txt"))
            {
                IncarcaDinFisierText();
                //ActualizeazaComboBoxProfesori();
                cmbProfesor.DataSource = null;
                cmbProfesor.DataSource = listaProfesori;
                MessageBox.Show("Datele au fost incarcate", "Incarcare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nu s-au gasit fisierele de salvare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeazaInterfata()
        {
            int nr = listaProfesori.Count;

            this.Text = $"Program Gestiune Orar - {nr} Profesori Inregistrati";

            lblStatistici.Text = $"In sistem sunt inregistrati {nr} profesori.";
        }

        private void tbCautare_TextChanged(object sender, EventArgs e)
        {
            string filtru = tbCautare.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtru))
            {
                dgvProfesori.DataSource = null;
                dgvProfesori.DataSource = listaProfesori;
            }
            else
            {
                var rezultateFiltrate = listaProfesori
                    .Where(p => (p.Nume != null && p.Nume.ToLower().Contains(filtru)) ||
                                (p.Prenume != null && p.Prenume.ToLower().Contains(filtru)))
                    .ToList();

                dgvProfesori.DataSource = null;
                dgvProfesori.DataSource = rezultateFiltrate;
            }

            lblStatistici.Text = $"Rezultate gasite: {dgvProfesori.Rows.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProfesori.SelectedRows.Count > 0)
            {
                Profesor profDeSters = (Profesor)dgvProfesori.SelectedRows[0].DataBoundItem;

                var confirmare = MessageBox.Show($"Sigur vrei sa stergi profesorul {profDeSters.Nume}?",
                                 "Confirmare Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmare == DialogResult.Yes)
                {
                    listaProfesori.Remove(profDeSters);

                    listaOrarGlobal.RemoveAll(o => o.ProfesorSarcina.Id == profDeSters.Id);

                    ActualizeazaTabel();
                    cmbProfesor.DataSource = null;
                    cmbProfesor.DataSource = listaProfesori;
                    ActualizeazaInterfata();
                    //SalveazaInFisierText();

                    MessageBox.Show("Profesorul a fost sters.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecteaza un rand intreg din tabel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProfesori_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProfesori.SelectedRows.Count > 0)
            {
                Profesor profSelectatInTabel = (Profesor)dgvProfesori.SelectedRows[0].DataBoundItem;

                if (profSelectatInTabel != null)
                {
                    cmbProfesor.SelectedItem = profSelectatInTabel;
                }
            }
        }

        private void dgvProfesori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Profesor profSelectat = (Profesor)dgvProfesori.Rows[e.RowIndex].DataBoundItem;

                if (profSelectat != null)
                {
                    foreach (var item in cmbProfesor.Items)
                    {
                        if (((Profesor)item).Id == profSelectat.Id)
                        {
                            cmbProfesor.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAdaugaSala frm = new FormAdaugaSala(listaSali))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.SalaNoua != null)
                    {
                        listaSali.Add(frm.SalaNoua);

                        AdaugaSalaInDB(frm.SalaNoua);

                        cmbSala.DataSource = null;
                        cmbSala.DataSource = listaSali;
                        cmbSala.SelectedIndex = -1;

                        MessageBox.Show("Sala a fost adaugata cu succes!");
                    }
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormStergeSala frm = new FormStergeSala(listaSali))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Sala salaDeSters = frm.SalaSelectata;

                    if (salaDeSters != null)
                    {
                        var confirmare = MessageBox.Show($"Stergeti sala {salaDeSters.Denumire}?",
                                                         "Confirmare Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmare == DialogResult.Yes)
                        {
                            listaSali.Remove(salaDeSters);

                            listaOrarGlobal.RemoveAll(o => o.SalaSarcina.Denumire == salaDeSters.Denumire);

                            cmbSala.DataSource = null;
                            cmbSala.DataSource = listaSali;
                            cmbSala.SelectedIndex = -1;

                            MessageBox.Show("Sala a fost stearsa!");

                            // SalveazaInFisierText();
                        }
                    }
                }
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormAdaugaMaterie frm = new FormAdaugaMaterie(listaDiscipline))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.MaterieNoua != null)
                    {
                        listaDiscipline.Add(frm.MaterieNoua);

                        cmbDisciplina.DataSource = null;
                        cmbDisciplina.DataSource = listaDiscipline;
                        cmbDisciplina.DisplayMember = "Denumire";
                        cmbDisciplina.SelectedIndex = -1;

                        MessageBox.Show("Materia a fost adaugata cu succes!");
                    }
                }
            }
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormStergeMaterie frm = new FormStergeMaterie(listaDiscipline))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Disciplina deSters = frm.MaterieSelectata;

                    if (deSters != null)
                    {
                        var confirmare = MessageBox.Show($"Stergeti materia '{deSters.Denumire}'?",
                                                         "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmare == DialogResult.Yes)
                        {
                            listaDiscipline.Remove(deSters);

                            listaOrarGlobal.RemoveAll(o => o.DisciplinaSarcina.Id == deSters.Id);

                            cmbDisciplina.DataSource = null;
                            cmbDisciplina.DataSource = listaDiscipline;
                            cmbDisciplina.SelectedIndex = -1;

                            MessageBox.Show("Materia a fost stearsa.");

                            // SalveazaInFisierText();
                        }
                    }
                }
            }
        }

        private void saveBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.dat)|*.dat";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();

                        bf.Serialize(fs, listaProfesori);
                        bf.Serialize(fs, listaOrarGlobal);
                    }

                    MessageBox.Show("S-a salvat cu succes in format binar!", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fisiere binare (*.dat)|*.dat";
            ofd.Title = "Selecteaza fisierul pentru restaurare date";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();

                        listaProfesori = (List<Profesor>)bf.Deserialize(fs);

                        listaOrarGlobal = (List<ElementOrar>)bf.Deserialize(fs);
                    }

                    ActualizeazaTabel();
                    ActualizeazaInterfata();

                    cmbProfesor.DataSource = null;
                    cmbProfesor.DataSource = listaProfesori;

                    MessageBox.Show("Datele au fost restaurate cu succes!", "Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la citire: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void graficSaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGraficSali fereastraGrafic = new FormGraficSali(listaOrarGlobal);

            fereastraGrafic.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Profesor profSelectat = (Profesor)cmbProfesor.SelectedItem;

            if (profSelectat == null)
            {
                MessageBox.Show("Va rugam sa selectati un profesor din lista", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var orarFiltrat = listaOrarGlobal.Where(o => o.ProfesorSarcina.Id == profSelectat.Id).ToList();

            if (orarFiltrat.Count == 0)
            {
                MessageBox.Show($"Profesorul {profSelectat.Nume} nu are nicio programare in orar.", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;

            pd.PrintPage += (s, ev) => DesenareTabelImprimanta(ev, orarFiltrat, profSelectat.ToString());

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd };
            ppd.ShowDialog();
        }

        private void DesenareTabelImprimanta(PrintPageEventArgs e, List<ElementOrar> date, string numeProfesor)
        {
            Graphics g = e.Graphics;

            Font fontTitlu = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fontCelule = new Font("Arial", 9);

            float x = 50;
            float y = 50;
            float latimeOra = 80;
            float latimeZi = 110;
            float inaltimeRand = 60;

            g.DrawString("ORAR PROFESOR: " + numeProfesor.ToUpper(), fontTitlu, Brushes.Black, x, y);
            y += 50;

            string[] zile = { "Luni", "Marti", "Miercuri", "Joi", "Vineri", "Sambata", "Duminica" };
            string[] intervale = { "07:30", "09:10", "10:50", "12:30", "14:10", "15:50", "17:30", "19:10" };

            g.FillRectangle(Brushes.LightGray, x, y, latimeOra, 30);
            g.DrawRectangle(Pens.Black, x, y, latimeOra, 30);
            g.DrawString("Ora", fontHeader, Brushes.Black, x + 10, y + 7);

            for (int i = 0; i < zile.Length; i++)
            {
                float posX = x + latimeOra + (i * latimeZi);
                g.FillRectangle(Brushes.LightGray, posX, y, latimeZi, 30);
                g.DrawRectangle(Pens.Black, posX, y, latimeZi, 30);
                g.DrawString(zile[i], fontHeader, Brushes.Black, posX + 10, y + 7);
            }
            y += 30;

            foreach (var interval in intervale)
            {
                g.DrawRectangle(Pens.Black, x, y, latimeOra, inaltimeRand);
                g.DrawString(interval, fontHeader, Brushes.Black, x + 10, y + 20);

                for (int i = 0; i < zile.Length; i++)
                {
                    float posX = x + latimeOra + (i * latimeZi);
                    g.DrawRectangle(Pens.Black, posX, y, latimeZi, inaltimeRand);

                    var curs = date.FirstOrDefault(d => d.Ziua == zile[i] && d.IntervalOrar.Contains(interval));

                    if (curs != null)
                    {
                        string info = $"{curs.DisciplinaSarcina.Denumire}\nSala: {curs.SalaSarcina.Denumire}";
                        RectangleF rectCelula = new RectangleF(posX + 2, y + 2, latimeZi - 4, inaltimeRand - 4);
                        g.DrawString(info, fontCelule, Brushes.Black, rectCelula);
                    }
                }
                y += inaltimeRand;
            }
        }

        private void IncarcaProfesoriXML()
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(@"Profesori.xml");

                XmlNodeList xnList = xmlDocument.SelectNodes("/catalog");

                listaProfesori.Clear();

                foreach (XmlNode xn in xnList)
                {
                    XmlNodeList xmlNodeList = xn.ChildNodes;

                    foreach (XmlNode node in xmlNodeList)
                    {
                        int id = Convert.ToInt32(node["id"].InnerText);
                        string nume = node["nume"].InnerText;
                        string prenume = node["prenume"].InnerText;
                        string titluAcademic = node["titluAcademic"].InnerText;

                        Profesor prof = new Profesor
                        {
                            Id = id,
                            Nume = nume,
                            Prenume = prenume,
                            TitluAcademic = titluAcademic
                        };

                        listaProfesori.Add(prof);
                    }
                }

                ActualizeazaTabel();
                cmbProfesor.DataSource = null;
                cmbProfesor.DataSource = listaProfesori;

                MessageBox.Show("Datele au fost incarcate din XML cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea XML: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True");

        private void IncarcaProfesoriDinDB()
        {
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Profesori", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listaProfesori.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Profesor p = new Profesor
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nume = row["Nume"].ToString(),
                        Prenume = row["Prenume"].ToString(),
                        TitluAcademic = row["TitluAcademic"].ToString()
                    };
                    listaProfesori.Add(p);
                }

                ActualizeazaTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citire din DB: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AdaugaProfesorInDB(string nume, string prenume, string titlu)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Profesori (Nume, Prenume, TitluAcademic) VALUES (@nume, @prenume, @titlu)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@prenume", prenume);
                cmd.Parameters.AddWithValue("@titlu", titlu);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Profesorul a fost adaugat in baza de date!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la inserare: " + ex.Message);
            }
            finally
            {
                connection.Close();
                IncarcaProfesoriDinDB();
            }
        }

        private void AdaugaSalaInDB(Sala s)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Sali (Denumire, Capacitate, Tip) VALUES (@den, @cap, @tip)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@den", s.Denumire);
                cmd.Parameters.AddWithValue("@cap", s.Capacitate > 0 ? s.Capacitate : 30);
                cmd.Parameters.AddWithValue("@tip", string.IsNullOrEmpty(s.Tip) ? "Sala curs" : s.Tip);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Sala {s.Denumire} a fost salvata in baza de date!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la inserarea salii in DB: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncarcaProfesoriXML();
        }
    }
}
