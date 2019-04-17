namespace form_player_on_screen
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
            this.btnColetarCoordenadas = new System.Windows.Forms.Button();
            this.txtCoordenadas = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnProcurarAlarme = new System.Windows.Forms.Button();
            this.ofdAlarmSound = new System.Windows.Forms.OpenFileDialog();
            this.txtAlarmPath = new System.Windows.Forms.TextBox();
            this.btnTestarSom = new System.Windows.Forms.Button();
            this.btnColetarCor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColetarCoordenadas
            // 
            this.btnColetarCoordenadas.Location = new System.Drawing.Point(13, 12);
            this.btnColetarCoordenadas.Name = "btnColetarCoordenadas";
            this.btnColetarCoordenadas.Size = new System.Drawing.Size(259, 23);
            this.btnColetarCoordenadas.TabIndex = 0;
            this.btnColetarCoordenadas.Text = "Coletar posicao (após 5seg)";
            this.btnColetarCoordenadas.UseVisualStyleBackColor = true;
            this.btnColetarCoordenadas.Click += new System.EventHandler(this.btnColetarCoordenadas_Click);
            // 
            // txtCoordenadas
            // 
            this.txtCoordenadas.Location = new System.Drawing.Point(12, 41);
            this.txtCoordenadas.Name = "txtCoordenadas";
            this.txtCoordenadas.ReadOnly = true;
            this.txtCoordenadas.Size = new System.Drawing.Size(259, 20);
            this.txtCoordenadas.TabIndex = 1;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(13, 69);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 2;
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(13, 111);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(260, 46);
            this.pnlColor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 256);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(259, 62);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnProcurarAlarme
            // 
            this.btnProcurarAlarme.Location = new System.Drawing.Point(11, 172);
            this.btnProcurarAlarme.Name = "btnProcurarAlarme";
            this.btnProcurarAlarme.Size = new System.Drawing.Size(258, 23);
            this.btnProcurarAlarme.TabIndex = 6;
            this.btnProcurarAlarme.Text = "Procurar Alarme";
            this.btnProcurarAlarme.UseVisualStyleBackColor = true;
            this.btnProcurarAlarme.Click += new System.EventHandler(this.btnProcurarAlarme_Click);
            // 
            // ofdAlarmSound
            // 
            this.ofdAlarmSound.FileName = "openFileDialog1";
            // 
            // txtAlarmPath
            // 
            this.txtAlarmPath.Location = new System.Drawing.Point(11, 201);
            this.txtAlarmPath.Name = "txtAlarmPath";
            this.txtAlarmPath.ReadOnly = true;
            this.txtAlarmPath.Size = new System.Drawing.Size(259, 20);
            this.txtAlarmPath.TabIndex = 7;
            // 
            // btnTestarSom
            // 
            this.btnTestarSom.Location = new System.Drawing.Point(12, 227);
            this.btnTestarSom.Name = "btnTestarSom";
            this.btnTestarSom.Size = new System.Drawing.Size(259, 23);
            this.btnTestarSom.TabIndex = 8;
            this.btnTestarSom.Text = "Testar Som";
            this.btnTestarSom.UseVisualStyleBackColor = true;
            this.btnTestarSom.Click += new System.EventHandler(this.btnTestarSom_Click);
            // 
            // btnColetarCor
            // 
            this.btnColetarCor.Location = new System.Drawing.Point(11, 69);
            this.btnColetarCor.Name = "btnColetarCor";
            this.btnColetarCor.Size = new System.Drawing.Size(262, 23);
            this.btnColetarCor.TabIndex = 9;
            this.btnColetarCor.Text = "Coletar Cor da posicao";
            this.btnColetarCor.UseVisualStyleBackColor = true;
            this.btnColetarCor.Click += new System.EventHandler(this.btnColetarCor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.btnColetarCor);
            this.Controls.Add(this.btnTestarSom);
            this.Controls.Add(this.txtAlarmPath);
            this.Controls.Add(this.btnProcurarAlarme);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtCoordenadas);
            this.Controls.Add(this.btnColetarCoordenadas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColetarCoordenadas;
        private System.Windows.Forms.TextBox txtCoordenadas;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnProcurarAlarme;
        private System.Windows.Forms.OpenFileDialog ofdAlarmSound;
        private System.Windows.Forms.TextBox txtAlarmPath;
        private System.Windows.Forms.Button btnTestarSom;
        private System.Windows.Forms.Button btnColetarCor;
    }
}

