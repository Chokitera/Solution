namespace Solucao.views
{
    partial class Frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprincipal));
            this.lbnPrincipal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.tmrHorario = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ptbNoturno = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckbVisualizarConcluidos = new Solucao.controls.ModeloCheckBox();
            this.ckbVisualizarCancelados = new Solucao.controls.ModeloCheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNoturno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnPrincipal
            // 
            this.lbnPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbnPrincipal.AutoSize = true;
            this.lbnPrincipal.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbnPrincipal.Location = new System.Drawing.Point(490, 7);
            this.lbnPrincipal.Name = "lbnPrincipal";
            this.lbnPrincipal.Size = new System.Drawing.Size(151, 35);
            this.lbnPrincipal.TabIndex = 0;
            this.lbnPrincipal.Text = "PRINCIPAL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbnPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 49);
            this.panel1.TabIndex = 1;
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.lblSaudacao.Location = new System.Drawing.Point(12, 73);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(461, 35);
            this.lblSaudacao.TabIndex = 2;
            this.lblSaudacao.Text = "OLÁ, @USUÁRIO. SEJA BEM VINDO!";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.lblHora.Location = new System.Drawing.Point(184, 641);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(111, 35);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Horário";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.lblData.Location = new System.Drawing.Point(11, 641);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(153, 35);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "01/01/2023";
            // 
            // tmrHorario
            // 
            this.tmrHorario.Interval = 1000;
            this.tmrHorario.Tick += new System.EventHandler(this.tmrHorario_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(160, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // ptbNoturno
            // 
            this.ptbNoturno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbNoturno.Image = ((System.Drawing.Image)(resources.GetObject("ptbNoturno.Image")));
            this.ptbNoturno.Location = new System.Drawing.Point(1023, 611);
            this.ptbNoturno.Name = "ptbNoturno";
            this.ptbNoturno.Size = new System.Drawing.Size(65, 58);
            this.ptbNoturno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNoturno.TabIndex = 6;
            this.ptbNoturno.TabStop = false;
            this.ptbNoturno.Visible = false;
            this.ptbNoturno.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(405, 649);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(278, 27);
            this.label17.TabIndex = 44;
            this.label17.Text = "Chamados Cancelados";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(405, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 46;
            this.label2.Text = "Chamados Concluído";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(350, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 35);
            this.label3.TabIndex = 47;
            this.label3.Text = "A SOLUÇÃO PARA SEU NEGÓCIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(356, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 1);
            this.panel4.TabIndex = 51;
            // 
            // ckbVisualizarConcluidos
            // 
            this.ckbVisualizarConcluidos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ckbVisualizarConcluidos.AutoSize = true;
            this.ckbVisualizarConcluidos.Location = new System.Drawing.Point(675, 626);
            this.ckbVisualizarConcluidos.MinimumSize = new System.Drawing.Size(45, 22);
            this.ckbVisualizarConcluidos.Name = "ckbVisualizarConcluidos";
            this.ckbVisualizarConcluidos.OffBackColor = System.Drawing.Color.Gray;
            this.ckbVisualizarConcluidos.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.ckbVisualizarConcluidos.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.ckbVisualizarConcluidos.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.ckbVisualizarConcluidos.Size = new System.Drawing.Size(45, 22);
            this.ckbVisualizarConcluidos.TabIndex = 45;
            this.ckbVisualizarConcluidos.UseVisualStyleBackColor = true;
            // 
            // ckbVisualizarCancelados
            // 
            this.ckbVisualizarCancelados.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ckbVisualizarCancelados.AutoSize = true;
            this.ckbVisualizarCancelados.Location = new System.Drawing.Point(689, 654);
            this.ckbVisualizarCancelados.MinimumSize = new System.Drawing.Size(45, 22);
            this.ckbVisualizarCancelados.Name = "ckbVisualizarCancelados";
            this.ckbVisualizarCancelados.OffBackColor = System.Drawing.Color.Gray;
            this.ckbVisualizarCancelados.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.ckbVisualizarCancelados.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.ckbVisualizarCancelados.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.ckbVisualizarCancelados.Size = new System.Drawing.Size(45, 22);
            this.ckbVisualizarCancelados.TabIndex = 43;
            this.ckbVisualizarCancelados.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1023, 545);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 679);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbVisualizarConcluidos);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ckbVisualizarCancelados);
            this.Controls.Add(this.ptbNoturno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmprincipal";
            this.Text = "Frmprincipal";
            this.Load += new System.EventHandler(this.Frmprincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNoturno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer tmrHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbNoturno;
        private System.Windows.Forms.Label label17;
        private controls.ModeloCheckBox ckbVisualizarCancelados;
        private System.Windows.Forms.Label label2;
        private controls.ModeloCheckBox ckbVisualizarConcluidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}