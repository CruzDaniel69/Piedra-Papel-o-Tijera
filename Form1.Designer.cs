namespace Piedra_papel_tijera
{
    partial class frmPiedraPapelTijera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPiedraPapelTijera));
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.gbJugador1 = new System.Windows.Forms.GroupBox();
            this.gbMaquina = new System.Windows.Forms.GroupBox();
            this.rbtnPiedra1 = new System.Windows.Forms.RadioButton();
            this.rbtnPapel1 = new System.Windows.Forms.RadioButton();
            this.rbtnTijera1 = new System.Windows.Forms.RadioButton();
            this.rbtnPiedra2 = new System.Windows.Forms.RadioButton();
            this.rbtnPapel2 = new System.Windows.Forms.RadioButton();
            this.rbtnTijera2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.gbJugador1.SuspendLayout();
            this.gbMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(27, 18);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(35, 13);
            this.lblScore1.TabIndex = 0;
            this.lblScore1.Text = "Score";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(585, 18);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(35, 13);
            this.lblScore2.TabIndex = 1;
            this.lblScore2.Text = "Score";
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(643, 15);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(80, 20);
            this.txtScore2.TabIndex = 2;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(68, 15);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(74, 20);
            this.txtScore1.TabIndex = 3;
            // 
            // gbJugador1
            // 
            this.gbJugador1.Controls.Add(this.rbtnTijera1);
            this.gbJugador1.Controls.Add(this.rbtnPapel1);
            this.gbJugador1.Controls.Add(this.rbtnPiedra1);
            this.gbJugador1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbJugador1.Location = new System.Drawing.Point(12, 59);
            this.gbJugador1.Name = "gbJugador1";
            this.gbJugador1.Size = new System.Drawing.Size(200, 303);
            this.gbJugador1.TabIndex = 4;
            this.gbJugador1.TabStop = false;
            this.gbJugador1.Text = "Jugador1";
            // 
            // gbMaquina
            // 
            this.gbMaquina.Controls.Add(this.rbtnPiedra2);
            this.gbMaquina.Controls.Add(this.rbtnPapel2);
            this.gbMaquina.Controls.Add(this.rbtnTijera2);
            this.gbMaquina.Enabled = false;
            this.gbMaquina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbMaquina.Location = new System.Drawing.Point(579, 59);
            this.gbMaquina.Name = "gbMaquina";
            this.gbMaquina.Size = new System.Drawing.Size(200, 303);
            this.gbMaquina.TabIndex = 0;
            this.gbMaquina.TabStop = false;
            this.gbMaquina.Text = "Maquina";
            // 
            // rbtnPiedra1
            // 
            this.rbtnPiedra1.AutoSize = true;
            this.rbtnPiedra1.Location = new System.Drawing.Point(45, 54);
            this.rbtnPiedra1.Name = "rbtnPiedra1";
            this.rbtnPiedra1.Size = new System.Drawing.Size(55, 17);
            this.rbtnPiedra1.TabIndex = 0;
            this.rbtnPiedra1.TabStop = true;
            this.rbtnPiedra1.Text = "Piedra";
            this.rbtnPiedra1.UseVisualStyleBackColor = true;
            // 
            // rbtnPapel1
            // 
            this.rbtnPapel1.AutoSize = true;
            this.rbtnPapel1.Location = new System.Drawing.Point(45, 130);
            this.rbtnPapel1.Name = "rbtnPapel1";
            this.rbtnPapel1.Size = new System.Drawing.Size(52, 17);
            this.rbtnPapel1.TabIndex = 1;
            this.rbtnPapel1.TabStop = true;
            this.rbtnPapel1.Text = "Papel";
            this.rbtnPapel1.UseVisualStyleBackColor = true;
            // 
            // rbtnTijera1
            // 
            this.rbtnTijera1.AutoSize = true;
            this.rbtnTijera1.Location = new System.Drawing.Point(45, 222);
            this.rbtnTijera1.Name = "rbtnTijera1";
            this.rbtnTijera1.Size = new System.Drawing.Size(51, 17);
            this.rbtnTijera1.TabIndex = 2;
            this.rbtnTijera1.TabStop = true;
            this.rbtnTijera1.Text = "Tijera";
            this.rbtnTijera1.UseVisualStyleBackColor = true;
            // 
            // rbtnPiedra2
            // 
            this.rbtnPiedra2.AutoSize = true;
            this.rbtnPiedra2.Location = new System.Drawing.Point(59, 54);
            this.rbtnPiedra2.Name = "rbtnPiedra2";
            this.rbtnPiedra2.Size = new System.Drawing.Size(55, 17);
            this.rbtnPiedra2.TabIndex = 3;
            this.rbtnPiedra2.TabStop = true;
            this.rbtnPiedra2.Text = "Piedra";
            this.rbtnPiedra2.UseVisualStyleBackColor = true;
            // 
            // rbtnPapel2
            // 
            this.rbtnPapel2.AutoSize = true;
            this.rbtnPapel2.Location = new System.Drawing.Point(62, 130);
            this.rbtnPapel2.Name = "rbtnPapel2";
            this.rbtnPapel2.Size = new System.Drawing.Size(52, 17);
            this.rbtnPapel2.TabIndex = 4;
            this.rbtnPapel2.TabStop = true;
            this.rbtnPapel2.Text = "Papel";
            this.rbtnPapel2.UseVisualStyleBackColor = true;
            // 
            // rbtnTijera2
            // 
            this.rbtnTijera2.AutoSize = true;
            this.rbtnTijera2.Location = new System.Drawing.Point(59, 222);
            this.rbtnTijera2.Name = "rbtnTijera2";
            this.rbtnTijera2.Size = new System.Drawing.Size(51, 17);
            this.rbtnTijera2.TabIndex = 5;
            this.rbtnTijera2.TabStop = true;
            this.rbtnTijera2.Text = "Tijera";
            this.rbtnTijera2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Piedra_papel_tijera.Properties.Resources.iconfinder_gymfightpunchboxing_glovessports_and_competitionboxingathleteolympictrainingglovessport_4394759_119509;
            this.pictureBox1.Location = new System.Drawing.Point(344, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 99);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJugar.Location = new System.Drawing.Point(274, 242);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(238, 68);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            // 
            // frmPiedraPapelTijera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbMaquina);
            this.Controls.Add(this.gbJugador1);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPiedraPapelTijera";
            this.Text = "Piedra Papel o Tijera";
            this.gbJugador1.ResumeLayout(false);
            this.gbJugador1.PerformLayout();
            this.gbMaquina.ResumeLayout(false);
            this.gbMaquina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.GroupBox gbJugador1;
        private System.Windows.Forms.GroupBox gbMaquina;
        private System.Windows.Forms.RadioButton rbtnTijera1;
        private System.Windows.Forms.RadioButton rbtnPapel1;
        private System.Windows.Forms.RadioButton rbtnPiedra1;
        private System.Windows.Forms.RadioButton rbtnPiedra2;
        private System.Windows.Forms.RadioButton rbtnPapel2;
        private System.Windows.Forms.RadioButton rbtnTijera2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnJugar;
    }
}

