
namespace CronometroMIR4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnParar = new System.Windows.Forms.Button();
            this.BtnResetar = new System.Windows.Forms.Button();
            this.RtxbComentario = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(12, 120);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(127, 57);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "INICIAR";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnParar
            // 
            this.BtnParar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnParar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParar.Location = new System.Drawing.Point(310, 120);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(127, 57);
            this.BtnParar.TabIndex = 2;
            this.BtnParar.Text = "PARAR";
            this.BtnParar.UseVisualStyleBackColor = false;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // BtnResetar
            // 
            this.BtnResetar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnResetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetar.Location = new System.Drawing.Point(12, 369);
            this.BtnResetar.Name = "BtnResetar";
            this.BtnResetar.Size = new System.Drawing.Size(425, 40);
            this.BtnResetar.TabIndex = 3;
            this.BtnResetar.Text = "RESETAR / SALVAR";
            this.BtnResetar.UseVisualStyleBackColor = false;
            this.BtnResetar.Click += new System.EventHandler(this.BtnResetar_Click);
            // 
            // RtxbComentario
            // 
            this.RtxbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxbComentario.Location = new System.Drawing.Point(12, 203);
            this.RtxbComentario.Name = "RtxbComentario";
            this.RtxbComentario.Size = new System.Drawing.Size(425, 160);
            this.RtxbComentario.TabIndex = 4;
            this.RtxbComentario.Text = "O arquivo de texto gerado vai ser salvo no mesmo diretorio do app.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "COMENTARIO:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(448, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RtxbComentario);
            this.Controls.Add(this.BtnResetar);
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronometro MIR4 - V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.Button BtnResetar;
        private System.Windows.Forms.RichTextBox RtxbComentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

