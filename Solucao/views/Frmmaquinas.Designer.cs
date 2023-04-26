namespace Solucao.views
{
    partial class Frmmaquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmaquinas));
            this.lbnPrincipal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.MaskedTextBox();
            this.cmbPlano = new Solucao.controls.novosComboBox();
            this.cmblocal = new Solucao.controls.novosComboBox();
            this.cmbsetor = new Solucao.controls.novosComboBox();
            this.txtncm = new Solucao.controls.novoTextBox();
            this.cmbsituacao = new Solucao.controls.novosComboBox();
            this.btnExcluir = new Solucao.controls.ModeloBotao();
            this.btnNovo = new Solucao.controls.ModeloBotao();
            this.btnSalvar = new Solucao.controls.ModeloBotao();
            this.txtequipamento = new Solucao.controls.novoTextBox();
            this.txtcodigo = new Solucao.controls.novoTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnPrincipal
            // 
            this.lbnPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbnPrincipal.AutoSize = true;
            this.lbnPrincipal.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbnPrincipal.Location = new System.Drawing.Point(490, 7);
            this.lbnPrincipal.Name = "lbnPrincipal";
            this.lbnPrincipal.Size = new System.Drawing.Size(159, 35);
            this.lbnPrincipal.TabIndex = 0;
            this.lbnPrincipal.Text = "MÁQUINAS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbnPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 49);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(123, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "Equipamento:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(123, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(123, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Setor:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(607, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data Garantia:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(649, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Situação:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(607, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 30;
            this.label6.Text = "NCM:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(123, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 27);
            this.label7.TabIndex = 32;
            this.label7.Text = "Localização:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(123, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "Plano:";
            // 
            // txtCusto
            // 
            this.txtCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCusto.Location = new System.Drawing.Point(821, 285);
            this.txtCusto.Mask = "00/00/0000";
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(137, 26);
            this.txtCusto.TabIndex = 35;
            this.txtCusto.ValidatingType = typeof(System.DateTime);
            // 
            // cmbPlano
            // 
            this.cmbPlano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPlano.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPlano.BorderColor = System.Drawing.Color.DimGray;
            this.cmbPlano.BorderSize = 2;
            this.cmbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPlano.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPlano.IconColor = System.Drawing.Color.Gray;
            this.cmbPlano.Items.AddRange(new object[] {
            "Trocar Óleo em 3 Meses",
            "Limpeza de Disco",
            "Higienização"});
            this.cmbPlano.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPlano.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPlano.Location = new System.Drawing.Point(240, 337);
            this.cmbPlano.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Padding = new System.Windows.Forms.Padding(2);
            this.cmbPlano.Size = new System.Drawing.Size(320, 30);
            this.cmbPlano.TabIndex = 33;
            this.cmbPlano.Texts = "";
            // 
            // cmblocal
            // 
            this.cmblocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmblocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmblocal.BorderColor = System.Drawing.Color.DimGray;
            this.cmblocal.BorderSize = 2;
            this.cmblocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmblocal.ForeColor = System.Drawing.Color.DimGray;
            this.cmblocal.IconColor = System.Drawing.Color.Gray;
            this.cmblocal.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmblocal.ListTextColor = System.Drawing.Color.DimGray;
            this.cmblocal.Location = new System.Drawing.Point(310, 232);
            this.cmblocal.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmblocal.Name = "cmblocal";
            this.cmblocal.Padding = new System.Windows.Forms.Padding(2);
            this.cmblocal.Size = new System.Drawing.Size(250, 30);
            this.cmblocal.TabIndex = 4;
            this.cmblocal.Texts = "";
            // 
            // cmbsetor
            // 
            this.cmbsetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbsetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbsetor.BorderColor = System.Drawing.Color.DimGray;
            this.cmbsetor.BorderSize = 2;
            this.cmbsetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbsetor.ForeColor = System.Drawing.Color.DimGray;
            this.cmbsetor.IconColor = System.Drawing.Color.Gray;
            this.cmbsetor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbsetor.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbsetor.Location = new System.Drawing.Point(240, 284);
            this.cmbsetor.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbsetor.Name = "cmbsetor";
            this.cmbsetor.Padding = new System.Windows.Forms.Padding(2);
            this.cmbsetor.Size = new System.Drawing.Size(320, 30);
            this.cmbsetor.TabIndex = 6;
            this.cmbsetor.Texts = "";
            // 
            // txtncm
            // 
            this.txtncm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtncm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtncm.BorderColor = System.Drawing.Color.DimGray;
            this.txtncm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtncm.BorderSize = 2;
            this.txtncm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtncm.ForeColor = System.Drawing.Color.DimGray;
            this.txtncm.Location = new System.Drawing.Point(682, 227);
            this.txtncm.Margin = new System.Windows.Forms.Padding(4);
            this.txtncm.Multiline = false;
            this.txtncm.Name = "txtncm";
            this.txtncm.Padding = new System.Windows.Forms.Padding(7);
            this.txtncm.PasswordChar = false;
            this.txtncm.Size = new System.Drawing.Size(362, 35);
            this.txtncm.TabIndex = 5;
            this.txtncm.UnderlinedStyle = true;
            // 
            // cmbsituacao
            // 
            this.cmbsituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbsituacao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbsituacao.BorderColor = System.Drawing.Color.DimGray;
            this.cmbsituacao.BorderSize = 2;
            this.cmbsituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbsituacao.ForeColor = System.Drawing.Color.DimGray;
            this.cmbsituacao.IconColor = System.Drawing.Color.Gray;
            this.cmbsituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbsituacao.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbsituacao.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbsituacao.Location = new System.Drawing.Point(794, 127);
            this.cmbsituacao.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbsituacao.Name = "cmbsituacao";
            this.cmbsituacao.Padding = new System.Windows.Forms.Padding(2);
            this.cmbsituacao.Size = new System.Drawing.Size(250, 30);
            this.cmbsituacao.TabIndex = 2;
            this.cmbsituacao.Texts = "";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluir.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcluir.BorderRadius = 15;
            this.btnExcluir.BorderSize = 0;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(440, 610);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextColor = System.Drawing.Color.White;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovo.BackColor = System.Drawing.Color.Orange;
            this.btnNovo.BackgroundColor = System.Drawing.Color.Orange;
            this.btnNovo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNovo.BorderRadius = 15;
            this.btnNovo.BorderSize = 0;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(284, 610);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(150, 40);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextColor = System.Drawing.Color.White;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalvar.BorderRadius = 15;
            this.btnSalvar.BorderSize = 0;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(128, 610);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 40);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtequipamento
            // 
            this.txtequipamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtequipamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtequipamento.BorderColor = System.Drawing.Color.DimGray;
            this.txtequipamento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtequipamento.BorderSize = 2;
            this.txtequipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtequipamento.ForeColor = System.Drawing.Color.DimGray;
            this.txtequipamento.Location = new System.Drawing.Point(310, 174);
            this.txtequipamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtequipamento.Multiline = false;
            this.txtequipamento.Name = "txtequipamento";
            this.txtequipamento.Padding = new System.Windows.Forms.Padding(7);
            this.txtequipamento.PasswordChar = false;
            this.txtequipamento.Size = new System.Drawing.Size(734, 35);
            this.txtequipamento.TabIndex = 3;
            this.txtequipamento.UnderlinedStyle = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcodigo.BorderColor = System.Drawing.Color.DimGray;
            this.txtcodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtcodigo.BorderSize = 2;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtcodigo.Location = new System.Drawing.Point(240, 119);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Multiline = false;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Padding = new System.Windows.Forms.Padding(7);
            this.txtcodigo.PasswordChar = false;
            this.txtcodigo.Size = new System.Drawing.Size(250, 35);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.UnderlinedStyle = true;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // Frmmaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 679);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.cmbPlano);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmblocal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbsetor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtncm);
            this.Controls.Add(this.cmbsituacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtequipamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmmaquinas";
            this.Text = "1100, 679";
            this.Load += new System.EventHandler(this.Frmmaquinas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnPrincipal;
        private System.Windows.Forms.Panel panel1;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnNovo;
        private controls.ModeloBotao btnSalvar;
        private System.Windows.Forms.Label label4;
        private controls.novoTextBox txtequipamento;
        private System.Windows.Forms.Label label1;
        private controls.novoTextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private controls.novosComboBox cmbsituacao;
        private System.Windows.Forms.Label label6;
        private controls.novoTextBox txtncm;
        private controls.novosComboBox cmbsetor;
        private controls.novosComboBox cmblocal;
        private System.Windows.Forms.Label label7;
        private controls.novosComboBox cmbPlano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCusto;
    }
}