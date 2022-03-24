namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarImagem(pb_clube1, lbl_nomeClube1.Text);
            CarregarImagem(pb_clube2, lbl_nomeClube2.Text);

        }

        private void CarregarImagem(PictureBox pb_clube, string text)
        {
            if (text.Equals("Real Madrid"))
                pb_clube.Image = Properties.Resources.Real_Madrid;
            else if (text.Equals("Barcelona"))
                pb_clube.Image = Properties.Resources.logo_barcelona_2048;
            else if (text.Equals("Grêmio"))
                pb_clube.Image = Properties.Resources.gremio_logo_escudo;
            else if (text.Equals("Internacional"))
                pb_clube.Image = Properties.Resources.logo_internacional_1536;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_menos1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_resultado1.Text) ;
            if (score > 0)
            {
                score--;
                lbl_resultado1.Text = score.ToString();
            }
        }

        private void btn_mais1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_resultado1.Text) + 1;
           lbl_resultado1.Text = score.ToString();
        }

        private void btn_menos2_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_resultado2.Text) ;
            if (score > 0)
            {
                score--;
                lbl_resultado2.Text = score.ToString();
            }
        }

        private void btn_mais2_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_resultado2.Text) + 1;
            lbl_resultado2.Text = score.ToString();
        }

        int min = 0, seg = 0;

        private void btn_comecar_Click(object sender, EventArgs e)
        {
            cronometro.Enabled = true;
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }

            string texto = "";
            if (min < 10)
                texto += "0" + min;
            else
                texto += min;

            if (seg < 10)
                texto += ":0" + seg;
            else
                texto += ":" + seg;
            lbl_timer.Text = texto;

            if (min < 45)
                lbl_parte.Text = "1ª parte";
            else
                lbl_parte.Text = "2ª parte";
           
            if ((min == 45 && seg == 0) || (min == 90) )
                cronometro.Enabled = false;
        }
    }
}