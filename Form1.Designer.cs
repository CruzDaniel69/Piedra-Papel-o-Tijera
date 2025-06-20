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
            this.rbtnTijera1 = new System.Windows.Forms.RadioButton();
            this.rbtnPapel1 = new System.Windows.Forms.RadioButton();
            this.rbtnPiedra1 = new System.Windows.Forms.RadioButton();
            this.gbMaquina = new System.Windows.Forms.GroupBox();
            this.rbtnPiedra2 = new System.Windows.Forms.RadioButton();
            this.rbtnPapel2 = new System.Windows.Forms.RadioButton();
            this.rbtnTijera2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblGanador = new System.Windows.Forms.Label();
            this.gbJugador1.SuspendLayout();
            this.gbMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(31, 22);
            this.lblScore1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(39, 16);
            this.lblScore1.TabIndex = 0;
            this.lblScore1.Text = "Score";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(682, 22);
            this.lblScore2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(39, 16);
            this.lblScore2.TabIndex = 1;
            this.lblScore2.Text = "Score";
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(750, 18);
            this.txtScore2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(93, 23);
            this.txtScore2.TabIndex = 2;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(79, 18);
            this.txtScore1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(86, 23);
            this.txtScore1.TabIndex = 3;
            // 
            // gbJugador1
            // 
            this.gbJugador1.Controls.Add(this.rbtnTijera1);
            this.gbJugador1.Controls.Add(this.rbtnPapel1);
            this.gbJugador1.Controls.Add(this.rbtnPiedra1);
            this.gbJugador1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbJugador1.Location = new System.Drawing.Point(14, 73);
            this.gbJugador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbJugador1.Name = "gbJugador1";
            this.gbJugador1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbJugador1.Size = new System.Drawing.Size(233, 373);
            this.gbJugador1.TabIndex = 4;
            this.gbJugador1.TabStop = false;
            this.gbJugador1.Text = "Jugador1";
            // 
            // rbtnTijera1
            // 
            this.rbtnTijera1.AutoSize = true;
            this.rbtnTijera1.Location = new System.Drawing.Point(52, 273);
            this.rbtnTijera1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTijera1.Name = "rbtnTijera1";
            this.rbtnTijera1.Size = new System.Drawing.Size(56, 20);
            this.rbtnTijera1.TabIndex = 2;
            this.rbtnTijera1.TabStop = true;
            this.rbtnTijera1.Text = "Tijera";
            this.rbtnTijera1.UseVisualStyleBackColor = true;
            // 
            // rbtnPapel1
            // 
            this.rbtnPapel1.AutoSize = true;
            this.rbtnPapel1.Location = new System.Drawing.Point(52, 167);
            this.rbtnPapel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnPapel1.Name = "rbtnPapel1";
            this.rbtnPapel1.Size = new System.Drawing.Size(55, 20);
            this.rbtnPapel1.TabIndex = 1;
            this.rbtnPapel1.TabStop = true;
            this.rbtnPapel1.Text = "Papel";
            this.rbtnPapel1.UseVisualStyleBackColor = true;
            // 
            // rbtnPiedra1
            // 
            this.rbtnPiedra1.AutoSize = true;
            this.rbtnPiedra1.Location = new System.Drawing.Point(52, 66);
            this.rbtnPiedra1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnPiedra1.Name = "rbtnPiedra1";
            this.rbtnPiedra1.Size = new System.Drawing.Size(60, 20);
            this.rbtnPiedra1.TabIndex = 0;
            this.rbtnPiedra1.TabStop = true;
            this.rbtnPiedra1.Text = "Piedra";
            this.rbtnPiedra1.UseVisualStyleBackColor = true;
            // 
            // gbMaquina
            // 
            this.gbMaquina.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbMaquina.Controls.Add(this.rbtnPiedra2);
            this.gbMaquina.Controls.Add(this.rbtnPapel2);
            this.gbMaquina.Controls.Add(this.rbtnTijera2);
            this.gbMaquina.Enabled = false;
            this.gbMaquina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbMaquina.Location = new System.Drawing.Point(676, 73);
            this.gbMaquina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMaquina.Name = "gbMaquina";
            this.gbMaquina.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMaquina.Size = new System.Drawing.Size(233, 373);
            this.gbMaquina.TabIndex = 0;
            this.gbMaquina.TabStop = false;
            this.gbMaquina.Text = "Maquina";
            // 
            // rbtnPiedra2
            // 
            this.rbtnPiedra2.AutoSize = true;
            this.rbtnPiedra2.Location = new System.Drawing.Point(69, 66);
            this.rbtnPiedra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnPiedra2.Name = "rbtnPiedra2";
            this.rbtnPiedra2.Size = new System.Drawing.Size(60, 20);
            this.rbtnPiedra2.TabIndex = 3;
            this.rbtnPiedra2.TabStop = true;
            this.rbtnPiedra2.Text = "Piedra";
            this.rbtnPiedra2.UseVisualStyleBackColor = true;
            // 
            // rbtnPapel2
            // 
            this.rbtnPapel2.AutoSize = true;
            this.rbtnPapel2.Location = new System.Drawing.Point(69, 167);
            this.rbtnPapel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnPapel2.Name = "rbtnPapel2";
            this.rbtnPapel2.Size = new System.Drawing.Size(55, 20);
            this.rbtnPapel2.TabIndex = 4;
            this.rbtnPapel2.TabStop = true;
            this.rbtnPapel2.Text = "Papel";
            this.rbtnPapel2.UseVisualStyleBackColor = true;
            // 
            // rbtnTijera2
            // 
            this.rbtnTijera2.AutoSize = true;
            this.rbtnTijera2.Location = new System.Drawing.Point(69, 273);
            this.rbtnTijera2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTijera2.Name = "rbtnTijera2";
            this.rbtnTijera2.Size = new System.Drawing.Size(56, 20);
            this.rbtnTijera2.TabIndex = 5;
            this.rbtnTijera2.TabStop = true;
            this.rbtnTijera2.Text = "Tijera";
            this.rbtnTijera2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Piedra_papel_tijera.Properties.Resources.iconfinder_gymfightpunchboxing_glovessports_and_competitionboxingathleteolympictrainingglovessport_4394759_119509;
            this.pictureBox1.Location = new System.Drawing.Point(401, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 122);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJugar.Location = new System.Drawing.Point(320, 298);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(278, 84);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGanador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGanador.Location = new System.Drawing.Point(431, 265);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(54, 16);
            this.lblGanador.TabIndex = 7;
            this.lblGanador.Text = "Ganador";
            // 
            // frmPiedraPapelTijera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbMaquina);
            this.Controls.Add(this.gbJugador1);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblGanador;
    }
}

