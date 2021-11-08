using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CronometroMIR4
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWath;
        public Form1()
        {
            InitializeComponent();
        }

        //

        
        string DataInicial { get; set; }

        public void BtnIniciar_Click(object sender, EventArgs e)
        {
            // Botão Iniciar Cronometro


            DateTime DataInicial = DateTime.Now;

            RtxbComentario.Text = "";

            stopWath.Start();
        }

        public void BtnParar_Click(object sender, EventArgs e)
        {
            // Botão Parar Cronometro
            stopWath.Stop();
        }

        public void BtnResetar_Click(object sender, EventArgs e)
        {
            // Botão Resetar / Salvar Cronometro

            

            DateTime DataFinal = DateTime.Now;


            string TudoJunto = 
                $"Data Inicial: {DataInicial}\n" +
                $"Tempo Decorrido: {label1.Text}\n" +
                $"Data Final: {DataFinal}\n" +
                $"Comentario: {RtxbComentario.Text}\n";

            using (System.IO.StreamWriter file =
                    
                    new System.IO.StreamWriter(@"MIR4.txt", true))
            {
                file.WriteLine(TudoJunto);
            }





            stopWath.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWath = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss}", stopWath.Elapsed);
        }
    }
}
