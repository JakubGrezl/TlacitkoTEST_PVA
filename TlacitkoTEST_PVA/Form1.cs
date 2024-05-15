namespace TlacitkoTEST_PVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new PocitaciTlacitko());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new ZnicitelneTlacitko(checkBox1));

        }
    }
}
