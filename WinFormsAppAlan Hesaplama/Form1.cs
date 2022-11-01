namespace WinFormsAppAlan_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* double x =((5+4)/3)*5-7;
             double y =  Math.Pow(x,2);
             textBox1.Text = y.ToString();
            */

            //Kare alaný hesaplama
            int kareKenarUzaunluk = Convert.ToInt32(textBoxKenar.Text);
            int alanKare = kareKenarUzaunluk * kareKenarUzaunluk;  // Math.Pow(kareKenarUzaunluk,2);
            labelKare.Text = alanKare.ToString();

            //Dikdörtgen alan hesaplama
            int dikdortgenKýsaKenar = Convert.ToInt32(textBoxKisaKenar.Text);
            int dikdortgenUzunKenar = Convert.ToInt32(textBoxUzunKenar.Text);
            int alanDikdortgen = dikdortgenKýsaKenar * dikdortgenUzunKenar;
            labelDiktortgen.Text = alanDikdortgen.ToString();

            //Daire Alan Hesaplama
            int yaricap = Convert.ToInt32(textBoxYariCap.Text);
            int alanDaire =(int) Math.PI * (yaricap * yaricap);
            labelDaire.Text = alanDaire.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}