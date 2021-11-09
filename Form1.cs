using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CronometroMIR4
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWath;
        public Form1()
        {
            InitializeComponent();
        }
        /*
        HISTORICO DE ATUALIZAÇÕES

        (V 1.1)
            ADD BOTÕES DE ESCOLHA PARA CAÇA, MINERIO, MEDITAR E RECOLHER

        (V 1.2)
            Mudança no visual do app

        

        




        */

        string DataInicial { get; set; }

        public void BtnIniciar_Click(object sender, EventArgs e)
        {
            // Botão Iniciar Cronometro

            // Consulta a data atual e salva ela na variavel "DataInicial"
            DateTime DataInicial = DateTime.Now;

            // Limpa o texto do RichTextBox Comentario
            RtxbComentario.Text = "";

            // Inicia o cronometro
            stopWath.Start();
        }



        public void BtnParar_Click(object sender, EventArgs e)
        {
            // Botão Parar Cronometro

            // Para o cronometro
            stopWath.Stop();
        }



        public void BtnResetar_Click(object sender, EventArgs e)
        {
            // Botão Resetar / Salvar Cronometro


            // VERIFICAÇÃO DOS BOTÕES RADIAIS
            string BotaoRadial = "Nenhum botão selecionado";

            if (RButtonXP.Checked == true)
            {
                BotaoRadial = "Caçando";
            }
            if (RButtonMineirando.Checked == true)
            {
                BotaoRadial = "Mineirando";
            }
            if (RButtonRecolhendo.Checked == true)
            {
                BotaoRadial = "Recolhendo Ervas";
            }
            if (RButtonMeditando.Checked == true)
            {
                BotaoRadial = "Meditando";
            }


            // Consulta a data atual e salva ela na variavel "DataFinal"
            DateTime DataFinal = DateTime.Now;

            // Define o texto que vai ser escrito no txt e a ordem dele
            string TudoJunto =
                $"Data Inicial: {DataInicial}\n" +
                $"Tempo Decorrido: {label1.Text}\n" +
                $"Data Final: {DataFinal}\n" +
                $"Ação executada: {BotaoRadial}\n" +
                $"Comentario: {RtxbComentario.Text}\n";

            // Exporta os dados para o arquivo txt
            using (System.IO.StreamWriter file =

                    // Define o caminho para salvar o arquivo txt
                    new System.IO.StreamWriter(@"MIR4.txt", true))
            {
                // Escreve os dados no arquivo
                file.WriteLine(TudoJunto);
            }

            // Para o cronometro
            stopWath.Reset();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            stopWath = new Stopwatch();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Define o formato da hora que vai aparecer no cronometro 
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss}", stopWath.Elapsed);
        }
    }
}
