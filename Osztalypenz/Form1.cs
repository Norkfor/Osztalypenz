using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Osztalypenz
{
    public partial class frmOsztalypenz : Form
    {
        List<Befizetes> befizetesek = new List<Befizetes>();
        int hanyadikTranz = 0;
        int osszOsszeg = 0;
        public frmOsztalypenz()
        {
            InitializeComponent();
        }

        private void AllapotBeolvasas()
        {
            try
            {
                StreamReader be = new StreamReader("osztalypenz.txt");
                while (!be.EndOfStream)
                {
                    befizetesek.Add(new Befizetes(be.ReadLine()));
                }
                be.Close();
                MessageBox.Show("A beolvasás sikeres volt!");
            }
            catch
            {
                MessageBox.Show("Még nem lett létrehozva az adatállomány!");
            }

        }

        private void AllapotMentes()
        {
            StreamWriter ki = new StreamWriter("osztalypenz.txt");
            foreach (Befizetes be in befizetesek)
            {
                ki.WriteLine($"{be.Befizetett};{be.Nev};{be.Osszeg};{be.Datum}");
            }
            ki.Close();
            MessageBox.Show("A mentés sikeres volt!");
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (rbBefizetes.Checked == false && rbKifizetes.Checked == false || tbNev.Text == "" || tbOsszeg.Text == "")
            {
                MessageBox.Show("Valamenyik elem nem lett kitöltve!");
            }
            else
            {

                if (rbBefizetes.Checked == true)
                {
                    Befizetes();
                }
                else
                {
                    if (osszOsszeg <= 0)
                    {
                        MessageBox.Show("Nincs elég fedezet a levételhez!");
                    }
                    else
                    {
                        Kivetel();
                    }
                }
            }
        }

        private void Kivetel()
        {
            hanyadikTranz++;
            befizetesek.Add(new Befizetes(false, tbNev.Text, Convert.ToInt32(tbOsszeg.Text), dtpDatum.Value));
            lbTranzakcio.Items.Add($"{hanyadikTranz}. tranzakció: {tbOsszeg.Text} Ft-ot kivettünk {tbNev.Text} részére. {dtpDatum.Value}");
            osszOsszeg -= Convert.ToInt32(tbOsszeg.Text);
            lblEgyenleg.Text = $"{osszOsszeg} Ft";
            AllapotMentes();
        }

        private void Befizetes()
        {
            hanyadikTranz++;
            befizetesek.Add(new Befizetes(true, tbNev.Text, Convert.ToInt32(tbOsszeg.Text), dtpDatum.Value));
            lbTranzakcio.Items.Add($"{hanyadikTranz}. tranzakció: {tbNev.Text} befizetett {tbOsszeg.Text} Ft-ot {dtpDatum.Value}");
            osszOsszeg += Convert.ToInt32(tbOsszeg.Text);
            lblEgyenleg.Text = $"{osszOsszeg} Ft";
            AllapotMentes();
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            AllapotBeolvasas();
            int hanyadik = 0;
            foreach (Befizetes be in befizetesek)
            {
                hanyadik++;
                if (!be.Befizetett)
                {
                    lbTranzakcio.Items.Add($"{hanyadik}. tranzakció: {be.Osszeg} Ft-ot kivettünk {be.Nev} részére. {be.Datum}");
                    osszOsszeg -= Convert.ToInt32(be.Osszeg);
                    lblEgyenleg.Text = $"{osszOsszeg} Ft";
                }
                else
                {
                    lbTranzakcio.Items.Add($"{hanyadik}. tranzakció: {be.Nev} befizetett {be.Osszeg} Ft-ot {be.Datum}");
                    osszOsszeg += Convert.ToInt32(be.Osszeg);
                    lblEgyenleg.Text = $"{osszOsszeg} Ft";
                }
            }
        }
    }
}
