
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnParar = new System.Windows.Forms.Button();
            this.BtnResetar = new System.Windows.Forms.Button();
            this.RtxbComentario = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RButtonXP = new System.Windows.Forms.RadioButton();
            this.RButtonMineirando = new System.Windows.Forms.RadioButton();
            this.RButtonRecolhendo = new System.Windows.Forms.RadioButton();
            this.RButtonMeditando = new System.Windows.Forms.RadioButton();
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
            this.BtnIniciar.BackColor = System.Drawing.Color.Silver;
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
            this.BtnParar.BackColor = System.Drawing.Color.Silver;
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
            this.BtnResetar.BackColor = System.Drawing.Color.Silver;
            this.BtnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnResetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetar.Location = new System.Drawing.Point(12, 419);
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
            this.RtxbComentario.Location = new System.Drawing.Point(12, 253);
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
            this.label2.Location = new System.Drawing.Point(8, 230);
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
            // RButtonXP
            // 
            this.RButtonXP.AutoSize = true;
            this.RButtonXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButtonXP.ForeColor = System.Drawing.Color.White;
            this.RButtonXP.Location = new System.Drawing.Point(172, 120);
            this.RButtonXP.Name = "RButtonXP";
            this.RButtonXP.Size = new System.Drawing.Size(98, 24);
            this.RButtonXP.TabIndex = 6;
            this.RButtonXP.TabStop = true;
            this.RButtonXP.Text = "Caçando";
            this.RButtonXP.UseVisualStyleBackColor = true;
            // 
            // RButtonMineirando
            // 
            this.RButtonMineirando.AutoSize = true;
            this.RButtonMineirando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButtonMineirando.ForeColor = System.Drawing.Color.White;
            this.RButtonMineirando.Location = new System.Drawing.Point(172, 153);
            this.RButtonMineirando.Name = "RButtonMineirando";
            this.RButtonMineirando.Size = new System.Drawing.Size(115, 24);
            this.RButtonMineirando.TabIndex = 7;
            this.RButtonMineirando.TabStop = true;
            this.RButtonMineirando.Text = "Mineirando";
            this.RButtonMineirando.UseVisualStyleBackColor = true;
            // 
            // RButtonRecolhendo
            // 
            this.RButtonRecolhendo.AutoSize = true;
            this.RButtonRecolhendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButtonRecolhendo.ForeColor = System.Drawing.Color.White;
            this.RButtonRecolhendo.Location = new System.Drawing.Point(172, 183);
            this.RButtonRecolhendo.Name = "RButtonRecolhendo";
            this.RButtonRecolhendo.Size = new System.Drawing.Size(123, 24);
            this.RButtonRecolhendo.TabIndex = 8;
            this.RButtonRecolhendo.TabStop = true;
            this.RButtonRecolhendo.Text = "Recolhendo";
            this.RButtonRecolhendo.UseVisualStyleBackColor = true;
            // 
            // RButtonMeditando
            // 
            this.RButtonMeditando.AutoSize = true;
            this.RButtonMeditando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButtonMeditando.ForeColor = System.Drawing.Color.White;
            this.RButtonMeditando.Location = new System.Drawing.Point(172, 213);
            this.RButtonMeditando.Name = "RButtonMeditando";
            this.RButtonMeditando.Size = new System.Drawing.Size(111, 24);
            this.RButtonMeditando.TabIndex = 9;
            this.RButtonMeditando.TabStop = true;
            this.RButtonMeditando.Text = "Meditando";
            this.RButtonMeditando.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(448, 471);
            this.Controls.Add(this.RButtonMeditando);
            this.Controls.Add(this.RButtonRecolhendo);
            this.Controls.Add(this.RButtonMineirando);
            this.Controls.Add(this.RButtonXP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RtxbComentario);
            this.Controls.Add(this.BtnResetar);
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronometro MIR4 - V1.2";
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
        private System.Windows.Forms.RadioButton RButtonXP;
        private System.Windows.Forms.RadioButton RButtonMineirando;
        private System.Windows.Forms.RadioButton RButtonRecolhendo;
        private System.Windows.Forms.RadioButton RButtonMeditando;
    }
}

