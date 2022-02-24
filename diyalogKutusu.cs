using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesajKutumuz
{
    internal class DiyalogKutusu
    {
        public int ust = 200;
        public int sol = 200;
        public int genislik = 450;
        public int yukseklik = 250;
        public string? MesajBaslik { get; set; }
        public string? MesajMetni { get; set; }
        public int DugmeSayisi { get; set; }
        public int MesajTipi { get; set; }
        public string? MesajSonucu { get; set; }

        public void Goster()
        {
            diyalogKalip _form = new diyalogKalip();
            _form.Top = ust;
            _form.Left = sol;
            _form.Width = genislik;
            _form.Height = yukseklik;
            _form.Text = MesajBaslik;
            _form.Controls["richTextBox1"].Text = MesajMetni;
            _form.Controls["pictureBox1"].Visible = MesajTipi == 0 ? true : false;
            _form.Controls["pictureBox2"].Visible = MesajTipi == 2 ? true : false;
            _form.Controls["pictureBox3"].Visible = MesajTipi == 1 ? true : false;
            if (DugmeSayisi == 1)
            {
                _form.Controls["button1"].Visible = false;
                _form.Controls["button2"].Visible = false;
                _form.Controls["button3"].Visible = true;
            }
            if (DugmeSayisi == 2)
            {
                _form.Controls["button1"].Visible = true;
                _form.Controls["button2"].Visible = false;
                _form.Controls["button3"].Visible = true;
            }
            if (DugmeSayisi == 3)
            {
                _form.Controls["button1"].Visible = true;
                _form.Controls["button2"].Visible = true;
                _form.Controls["button3"].Visible = true;
            }

            DialogResult sonuc = _form.ShowDialog();
            if (sonuc == DialogResult.Yes)
            {
                MesajSonucu = "Evet";
            }
            else if (sonuc == DialogResult.No)
            {
                MesajSonucu = "Hayır";
            }
            else if (sonuc == DialogResult.Cancel)
            {
                MesajSonucu = "Vazgeç";
            }
        }
    }
}