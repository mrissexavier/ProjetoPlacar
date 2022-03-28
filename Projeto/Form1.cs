using System.Text;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarArquivo();
            CarregarImagem(pb_clube1, lbl_nomeClube1.Text);
            CarregarImagem(pb_clube2, lbl_nomeClube2.Text);
        }

        private void CarregarArquivo()
        {
            //string texto = File.ReadAllText("jogo.txt", Encoding.UTF8);
            string texto = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                    texto = File.ReadAllText(openFileDialog1.FileName);

            string[]  parametros = texto.Split(';');
            lbl_nomeClube1.Text = parametros[0];
            lbl_nomeClube2.Text = parametros[1];
            lbl_resultado1.Text = parametros[2];
            lbl_resultado2.Text = parametros[3];
            min = int.Parse(parametros[4]);
            seg = int.Parse(parametros[5]);
            lbl_timer.Text =
            texto = "";
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
                lbl_parte.Text = "1º tempo";
            else
                lbl_parte.Text = "2º tempo";

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
            if(min == 90)
            {
                string resultadoFinal =
                    lbl_nomeClube1.Text + ";" +
                    lbl_nomeClube2.Text + ";" +
                    lbl_resultado1.Text + ";" +
                    lbl_resultado2.Text + ";" +
                    min + ";" +
                    seg ;

                //File.WriteAllText("jogo.txt", resultadoFinal);

                Stream myStream;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt) | *.txt|All files (*.*) | *.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if((myStream = saveFileDialog1.OpenFile()) != null)
                        myStream.Close();
                    File.WriteAllText(saveFileDialog1.FileName, resultadoFinal);
                }



                min = 0;
                seg = 0;
                lbl_timer.Text = "00:00";
                btn_comecar.Text = "Começar Jogo";
                lbl_resultado1.Text = "0";
                lbl_resultado2.Text = "0";
                lbl_parte.Text = "1º tempo";
            }
            else
            {
                cronometro.Enabled = true;
                btn_comecar.Visible = false;
                AtivarBotoes();
            }
        }

        private void AtivarBotoes()
        {
           btn_mais1.Enabled = true;
            btn_menos1.Enabled = true;
            btn_mais2.Enabled = true;
            btn_menos2.Enabled = true;
        }

        private void DesativarBotoes()
        {
            btn_mais1.Enabled = false;
            btn_menos1.Enabled = false;
            btn_mais2.Enabled = false;
            btn_menos2.Enabled = false;
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
                lbl_parte.Text = "1º tempo";
            else
                lbl_parte.Text = "2º tempo";
           
            if ((min == 45 && seg == 0) || (min == 90))
            {
                cronometro.Enabled = false;
                btn_comecar.Visible = true;
                DesativarBotoes();

                if (min == 45)
                    btn_comecar.Text = "Começar 2º tempo";
                else if (min == 90)
                    btn_comecar.Text = "Gravar e recomeçar";
            }
        }
    }
}