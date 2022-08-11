using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UçakBiletRezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lstListele.Items.Add("Rota: " + cmbNerden.Text + "-" + cmbNereye.Text + " " + "Tarih: " + msktxtTarih.Text + "-" + msktxtSaat.Text + " " + "Adı Soyadı: " + txtAd.Text + " " + txtSoyad.Text + " " + "TC: " + msktxtKimlik.Text + " " + "Telefon: " + msktxtTelefon.Text);
        }

        private void btndegis_Click(object sender, EventArgs e)
        {
            lblDegis.Text = cmbNereye.Text;
            cmbNereye.Text = cmbNerden.Text;
            cmbNerden.Text = lblDegis.Text;
        }
    }
}
