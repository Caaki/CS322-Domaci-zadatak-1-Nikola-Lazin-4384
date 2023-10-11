namespace CS322_Domaci_zadatak_1_Nikola_Lazin_4384
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = ime_tb.Text;
                string prezime = prezime_tb.Text;
                string adresa = adresa_tb.Text;
            
                if(ime.Contains(' ') || prezime.Contains(' '))
                {
                    throw new Exception("Ime i prezime moraju da budu jedna rec");
                }
                if(!adresa.Contains(' '))
                {
                    throw new Exception("Morate unedti celu adresu!");
                }

                MessageBox.Show(ime + " " + prezime +", " + adresa);
                ime_tb.ResetText();
                prezime_tb.ResetText();
                adresa_tb.ResetText();
                alert_lb.ResetText();

            }
            catch (Exception ex)
            {
                alert_lb.Text = ex.Message;

            }
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}