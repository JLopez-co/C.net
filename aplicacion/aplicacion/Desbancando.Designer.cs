namespace aplicacion
{
    partial class Desbancando
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desbancando));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MontoJ = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.Banca = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.LMensaje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MontoJ);
            this.groupBox1.Controls.Add(this.lblJugador);
            this.groupBox1.Controls.Add(this.Banca);
            this.groupBox1.Controls.Add(this.btnDetener);
            this.groupBox1.Controls.Add(this.LMensaje);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Juego";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MontoJ
            // 
            this.MontoJ.AutoSize = true;
            this.MontoJ.ForeColor = System.Drawing.Color.Black;
            this.MontoJ.Location = new System.Drawing.Point(62, 124);
            this.MontoJ.Name = "MontoJ";
            this.MontoJ.Size = new System.Drawing.Size(0, 13);
            this.MontoJ.TabIndex = 7;
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Location = new System.Drawing.Point(79, 85);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(0, 13);
            this.lblJugador.TabIndex = 6;
            // 
            // Banca
            // 
            this.Banca.AutoSize = true;
            this.Banca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Banca.Location = new System.Drawing.Point(85, 39);
            this.Banca.Name = "Banca";
            this.Banca.Size = new System.Drawing.Size(0, 13);
            this.Banca.TabIndex = 5;
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(62, 192);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // LMensaje
            // 
            this.LMensaje.AutoSize = true;
            this.LMensaje.ForeColor = System.Drawing.Color.Red;
            this.LMensaje.Location = new System.Drawing.Point(44, 160);
            this.LMensaje.Name = "LMensaje";
            this.LMensaje.Size = new System.Drawing.Size(110, 13);
            this.LMensaje.TabIndex = 0;
            this.LMensaje.Text = "Dale. ¿Que esperas?.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "El Poso tiene";
            // 
            // Desbancando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 261);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Desbancando";
            this.Text = "Desbancando";
            this.Load += new System.EventHandler(this.Desbancando_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label LMensaje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Banca;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label MontoJ;
        private System.Windows.Forms.Label label1;
    }
}