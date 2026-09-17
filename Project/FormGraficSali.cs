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
using System.Drawing.Printing;

namespace Project
{
    public partial class FormGraficSali : Form
    {
        private List<ElementOrar> _orar;

        const int margine = 10;
        Color culoareBars = Color.Blue;
        Font fontText = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        Color culoareText = Color.Black;

        public FormGraficSali(List<ElementOrar> orar)
        {
            InitializeComponent();
            this._orar = orar;
            this.Text = "Grad Ocupare Saptamanal";
            this.Size = new Size(800, 500);
            this.Paint += FormGraficSali_Paint;
            this.Resize += (s, e) => this.Invalidate();
        }

        private void FormGraficSali_Paint(object sender, PaintEventArgs e)
        {
            if (_orar == null || _orar.Count == 0)
            {
                e.Graphics.DrawString("Nu exista date in orar!", fontText, Brushes.Black, 20, 20);
                return;
            }

            string[] zileleSaptamanii = { "Luni", "Marti", "Miercuri", "Joi", "Vineri", "Sambata", "Duminica" };
            int[] valoriZile = new int[7];

            for (int i = 0; i < zileleSaptamanii.Length; i++)
            {
                valoriZile[i] = _orar.Count(x => x.Ziua == zileleSaptamanii[i]);
            }

            Graphics g = e.Graphics;
            Rectangle rectangle = new Rectangle(this.ClientRectangle.X + margine,
                                                this.ClientRectangle.Y + 4 * margine,
                                                this.ClientRectangle.Width - 2 * margine,
                                                this.ClientRectangle.Height - 5 * margine);

            Pen pen = new Pen(Color.Red, 3);
            g.DrawRectangle(pen, rectangle);

            double vMax = valoriZile.Max();
            if (vMax == 0) vMax = 1;

            double latime = (double)rectangle.Width / 7 / 3;
            double distanta = (double)(rectangle.Width - 7 * latime) / (7 + 1);

            Brush brBars = new SolidBrush(culoareBars);
            Brush brFont = new SolidBrush(culoareText);

            Rectangle[] rectangles = new Rectangle[7];

            for (int i = 0; i < 7; i++)
            {
                int inaltimeBara = (int)((valoriZile[i] / vMax) * rectangle.Height);

                rectangles[i] = new Rectangle(
                    (int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                    (int)(rectangle.Location.Y + rectangle.Height - inaltimeBara),
                    (int)latime,
                    inaltimeBara
                );

                string eticheta = $"{zileleSaptamanii[i]} ({valoriZile[i]})";
                g.DrawString(eticheta, fontText, brFont,
                             new Point(rectangles[i].X, rectangles[i].Y - 20));
            }

            g.FillRectangles(brBars, rectangles);

            for (int i = 0; i < 6; i++)
            {
                g.DrawLine(pen,
                    new Point((int)(rectangles[i].X + latime / 2), rectangles[i].Y),
                    new Point((int)(rectangles[i + 1].X + latime / 2), rectangles[i + 1].Y));
            }
        }

        private void ImprimareGrafic(object sender, PrintPageEventArgs e)
        {
            string[] zileleSaptamanii = { "Luni", "Marti", "Miercuri", "Joi", "Vineri", "Sambata", "Duminica" };
            int[] valoriZile = new int[7];

            for (int i = 0; i < zileleSaptamanii.Length; i++)
            {
                valoriZile[i] = _orar.Count(x => x.Ziua == zileleSaptamanii[i]);
            }

            Graphics g = e.Graphics;

            Rectangle rectangle = new Rectangle(e.PageBounds.X + margine,
                                                e.PageBounds.Y + 4 * margine,
                                                e.PageBounds.Width - 2 * margine,
                                                e.PageBounds.Height - 5 * margine);

            Pen pen = new Pen(Color.Red, 3);
            g.DrawRectangle(pen, rectangle);

            double vMax = valoriZile.Max();
            if (vMax == 0) vMax = 1;

            double latime = (double)rectangle.Width / 7 / 3;
            double distanta = (double)(rectangle.Width - 7 * latime) / (7 + 1);

            Brush brBars = new SolidBrush(culoareBars);
            Brush brFont = new SolidBrush(culoareText);

            Rectangle[] rectangles = new Rectangle[7];

            for (int i = 0; i < 7; i++)
            {
                int inaltimeBara = (int)((valoriZile[i] / vMax) * rectangle.Height);

                rectangles[i] = new Rectangle(
                    (int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                    (int)(rectangle.Location.Y + rectangle.Height - inaltimeBara),
                    (int)latime,
                    inaltimeBara
                );

                string eticheta = $"{zileleSaptamanii[i]} ({valoriZile[i]})";
                g.DrawString(eticheta, fontText, brFont,
                             new Point(rectangles[i].X, rectangles[i].Y - 20));
            }

            g.FillRectangles(brBars, rectangles);

            for (int i = 0; i < 6; i++)
            {
                g.DrawLine(pen,
                    new Point((int)(rectangles[i].X + latime / 2), rectangles[i].Y),
                    new Point((int)(rectangles[i + 1].X + latime / 2), rectangles[i + 1].Y));
            }
        }
    }
}
