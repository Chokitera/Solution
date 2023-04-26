namespace Solucao.controls
{
    partial class AcoesChamados
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcoesChamados));
            this.label1 = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.mtbInicio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbTempo = new System.Windows.Forms.MaskedTextBox();
            this.mtbFim = new System.Windows.Forms.MaskedTextBox();
            this.cmbAtividade = new Solucao.controls.novosComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusto = new Solucao.controls.novoTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconExcluir = new System.Windows.Forms.PictureBox();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.iconInicio = new System.Windows.Forms.PictureBox();
            this.iconFim = new System.Windows.Forms.PictureBox();
            this.ckbVisibilidade = new Solucao.controls.ModeloCheckBox();
            this.espacoAcoesChamados1 = new Solucao.controls.EspacoAcoesChamados();
            ((System.ComponentModel.ISupportInitialize)(this.iconExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Data";
            // 
            // mtbData
            // 
            this.mtbData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbData.Location = new System.Drawing.Point(10, 154);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(101, 29);
            this.mtbData.TabIndex = 2;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            this.mtbData.Enter += new System.EventHandler(this.mtbData_Enter);
            this.mtbData.Leave += new System.EventHandler(this.mtbData_Leave);
            // 
            // mtbInicio
            // 
            this.mtbInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbInicio.Location = new System.Drawing.Point(135, 154);
            this.mtbInicio.Mask = "90:00";
            this.mtbInicio.Name = "mtbInicio";
            this.mtbInicio.Size = new System.Drawing.Size(65, 29);
            this.mtbInicio.TabIndex = 3;
            this.mtbInicio.ValidatingType = typeof(System.DateTime);
            this.mtbInicio.TextChanged += new System.EventHandler(this.mtbFim_TextChanged);
            this.mtbInicio.Leave += new System.EventHandler(this.mtbInicio_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(132, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Início";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(236, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fim";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(343, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tempo";
            // 
            // mtbTempo
            // 
            this.mtbTempo.Enabled = false;
            this.mtbTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTempo.Location = new System.Drawing.Point(346, 154);
            this.mtbTempo.Mask = "90:00";
            this.mtbTempo.Name = "mtbTempo";
            this.mtbTempo.Size = new System.Drawing.Size(65, 29);
            this.mtbTempo.TabIndex = 5;
            this.mtbTempo.ValidatingType = typeof(System.DateTime);
            this.mtbTempo.Leave += new System.EventHandler(this.mtbTempo_Leave);
            // 
            // mtbFim
            // 
            this.mtbFim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFim.Location = new System.Drawing.Point(239, 154);
            this.mtbFim.Mask = "90:00";
            this.mtbFim.Name = "mtbFim";
            this.mtbFim.Size = new System.Drawing.Size(65, 29);
            this.mtbFim.TabIndex = 4;
            this.mtbFim.ValidatingType = typeof(System.DateTime);
            this.mtbFim.TextChanged += new System.EventHandler(this.mtbFim_TextChanged);
            this.mtbFim.Leave += new System.EventHandler(this.mtbFim_Leave);
            // 
            // cmbAtividade
            // 
            this.cmbAtividade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAtividade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbAtividade.BorderColor = System.Drawing.Color.DimGray;
            this.cmbAtividade.BorderSize = 2;
            this.cmbAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbAtividade.ForeColor = System.Drawing.Color.DimGray;
            this.cmbAtividade.IconColor = System.Drawing.Color.Gray;
            this.cmbAtividade.Items.AddRange(new object[] {
            "Agendamento",
            "Análise",
            "Atendimento",
            "Compra",
            "Deslogamento",
            "Teste"});
            this.cmbAtividade.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbAtividade.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbAtividade.Location = new System.Drawing.Point(439, 151);
            this.cmbAtividade.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbAtividade.Name = "cmbAtividade";
            this.cmbAtividade.Padding = new System.Windows.Forms.Padding(2);
            this.cmbAtividade.Size = new System.Drawing.Size(200, 30);
            this.cmbAtividade.TabIndex = 6;
            this.cmbAtividade.Texts = "";
            this.cmbAtividade.Leave += new System.EventHandler(this.cmbAtividade_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(436, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Atividade";
            // 
            // txtCusto
            // 
            this.txtCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCusto.BorderColor = System.Drawing.Color.DimGray;
            this.txtCusto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCusto.BorderSize = 2;
            this.txtCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.ForeColor = System.Drawing.Color.DimGray;
            this.txtCusto.Location = new System.Drawing.Point(664, 147);
            this.txtCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusto.Multiline = false;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Padding = new System.Windows.Forms.Padding(7);
            this.txtCusto.PasswordChar = false;
            this.txtCusto.Size = new System.Drawing.Size(88, 35);
            this.txtCusto.TabIndex = 7;
            this.txtCusto.UnderlinedStyle = true;
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(661, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Custo";
            // 
            // iconExcluir
            // 
            this.iconExcluir.Image = ((System.Drawing.Image)(resources.GetObject("iconExcluir.Image")));
            this.iconExcluir.Location = new System.Drawing.Point(795, 147);
            this.iconExcluir.Name = "iconExcluir";
            this.iconExcluir.Size = new System.Drawing.Size(32, 29);
            this.iconExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExcluir.TabIndex = 70;
            this.iconExcluir.TabStop = false;
            this.iconExcluir.Click += new System.EventHandler(this.iconExcluir_Click);
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbDescricao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescricao.Location = new System.Drawing.Point(10, 8);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(817, 107);
            this.rtbDescricao.TabIndex = 1;
            this.rtbDescricao.Text = "";
            this.rtbDescricao.Leave += new System.EventHandler(this.rtbDescricao_Leave);
            // 
            // iconInicio
            // 
            this.iconInicio.Image = ((System.Drawing.Image)(resources.GetObject("iconInicio.Image")));
            this.iconInicio.Location = new System.Drawing.Point(205, 155);
            this.iconInicio.Name = "iconInicio";
            this.iconInicio.Size = new System.Drawing.Size(23, 28);
            this.iconInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconInicio.TabIndex = 72;
            this.iconInicio.TabStop = false;
            this.iconInicio.Click += new System.EventHandler(this.iconInicio_Click);
            // 
            // iconFim
            // 
            this.iconFim.Image = ((System.Drawing.Image)(resources.GetObject("iconFim.Image")));
            this.iconFim.Location = new System.Drawing.Point(309, 155);
            this.iconFim.Name = "iconFim";
            this.iconFim.Size = new System.Drawing.Size(23, 28);
            this.iconFim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconFim.TabIndex = 73;
            this.iconFim.TabStop = false;
            this.iconFim.Click += new System.EventHandler(this.iconFim_Click);
            // 
            // ckbVisibilidade
            // 
            this.ckbVisibilidade.AutoSize = true;
            this.ckbVisibilidade.Location = new System.Drawing.Point(782, 119);
            this.ckbVisibilidade.MinimumSize = new System.Drawing.Size(45, 22);
            this.ckbVisibilidade.Name = "ckbVisibilidade";
            this.ckbVisibilidade.OffBackColor = System.Drawing.Color.Silver;
            this.ckbVisibilidade.OffToggleColor = System.Drawing.Color.MediumSlateBlue;
            this.ckbVisibilidade.OnBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ckbVisibilidade.OnToggleColor = System.Drawing.Color.Silver;
            this.ckbVisibilidade.Size = new System.Drawing.Size(45, 22);
            this.ckbVisibilidade.TabIndex = 8;
            this.ckbVisibilidade.UseVisualStyleBackColor = true;
            this.ckbVisibilidade.CheckedChanged += new System.EventHandler(this.ckbVisibilidade_CheckedChanged);
            // 
            // espacoAcoesChamados1
            // 
            this.espacoAcoesChamados1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.espacoAcoesChamados1.Location = new System.Drawing.Point(0, 191);
            this.espacoAcoesChamados1.Name = "espacoAcoesChamados1";
            this.espacoAcoesChamados1.Size = new System.Drawing.Size(834, 47);
            this.espacoAcoesChamados1.TabIndex = 75;
            // 
            // AcoesChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.espacoAcoesChamados1);
            this.Controls.Add(this.ckbVisibilidade);
            this.Controls.Add(this.iconFim);
            this.Controls.Add(this.iconInicio);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.iconExcluir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAtividade);
            this.Controls.Add(this.mtbFim);
            this.Controls.Add(this.mtbTempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.label1);
            this.Name = "AcoesChamados";
            this.Size = new System.Drawing.Size(834, 240);
            this.Load += new System.EventHandler(this.AcoesChamados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.MaskedTextBox mtbInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbTempo;
        private System.Windows.Forms.MaskedTextBox mtbFim;
        private novosComboBox cmbAtividade;
        private System.Windows.Forms.Label label5;
        private novoTextBox txtCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox iconExcluir;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.PictureBox iconInicio;
        private System.Windows.Forms.PictureBox iconFim;
        private ModeloCheckBox ckbVisibilidade;
        private EspacoAcoesChamados espacoAcoesChamados1;
    }
}
