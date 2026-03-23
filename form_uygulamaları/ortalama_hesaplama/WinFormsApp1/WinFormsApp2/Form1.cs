namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(txtVize.Text);
            int final = Convert.ToInt32(txtFinal.Text);
            lblOrtalama.Text = ortalamaHesapla(vize, final).ToString();
        }

        double ortalamaHesapla(int sayi1, int sayi2)
        {
            double ortalama = (sayi1 * 40) + (sayi2 * 60);

            return ortalama;
        }
    }
}
