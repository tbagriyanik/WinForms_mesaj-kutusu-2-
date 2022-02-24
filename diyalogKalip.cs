using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesajKutumuz
{
    public partial class diyalogKalip : Form
    {
        public diyalogKalip()
        {
            InitializeComponent();
        }

        //Başka formdaki nesneye ulaşmak için
        //Form1 form1 = (Form1)Application.OpenForms["Form1"];

        DialogResult sonuc = DialogResult.Cancel; //varsayılan

        private void button1_Click(object sender, EventArgs e)
        {//tamam
            //form1.Controls["label1"].Text = "Diyalog Sonucu: Tamam";
            sonuc = DialogResult.Yes;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//olmaz            
            sonuc = DialogResult.No;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {//vazgeç            
            sonuc = DialogResult.Cancel;
            Close();
        }

        private void diyalogKalip_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = sonuc;
            Dispose(); //nesne hafızadan atılır
        }
    }
}
