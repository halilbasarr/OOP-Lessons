namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        //parametresiz ve geriye deðer döndüren metot
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblOrtalama.Text=ortalamaHesapla().ToString();
        }

        double ortalamaHesapla()
        {
            double vize = Convert.ToDouble(vizeTxt.Text);
            double final = Convert.ToDouble(finalTxt.Text);
            double ortalama = (vize * 0.4) + (final * 0.6);
            return ortalama;

        }
    }
}
