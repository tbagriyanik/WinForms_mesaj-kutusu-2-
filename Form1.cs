namespace mesajKutumuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiyalogKutusu bizimNesne = new DiyalogKutusu();
            
            bizimNesne.MesajMetni = textBox1.Text;
            bizimNesne.MesajBaslik = textBox2.Text;
            bizimNesne.DugmeSayisi = radioButton1.Checked ? 1 : radioButton2.Checked ? 2 : radioButton3.Checked ? 3 : 1;
            bizimNesne.MesajTipi = comboBox1.SelectedIndex > -1 ? comboBox1.SelectedIndex : 0;

            label1.Text = "Diyalog Sonucu : ";
            bizimNesne.Goster();
            label1.Text = "Diyalog Sonucu : " + bizimNesne.MesajSonucu;
        }
    }
}