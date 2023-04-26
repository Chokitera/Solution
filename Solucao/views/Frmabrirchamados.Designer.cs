namespace Solucao.views
{
    partial class Frmabrirchamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmabrirchamados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnPrincipal = new System.Windows.Forms.Label();
            this.btnCancelar = new Solucao.controls.ModeloBotao();
            this.btnLimpar = new Solucao.controls.ModeloBotao();
            this.btnSalvar = new Solucao.controls.ModeloBotao();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsolicitante = new Solucao.controls.novoTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new Solucao.controls.novoTextBox();
            this.rtbdescricao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbData = new Solucao.controls.novosComboBox();
            this.cmbSetor = new Solucao.controls.novosComboBox();
            this.cmbLocal = new Solucao.controls.novosComboBox();
            this.cmbEquipamento = new Solucao.controls.novosComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbnPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 49);
            this.panel1.TabIndex = 3;
            // 
            // lbnPrincipal
            // 
            this.lbnPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbnPrincipal.AutoSize = true;
            this.lbnPrincipal.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbnPrincipal.Location = new System.Drawing.Point(490, 7);
            this.lbnPrincipal.Name = "lbnPrincipal";
            this.lbnPrincipal.Size = new System.Drawing.Size(152, 35);
            this.lbnPrincipal.TabIndex = 0;
            this.lbnPrincipal.Text = "CHAMADO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(440, 610);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpar.BackgroundColor = System.Drawing.Color.Orange;
            this.btnLimpar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpar.BorderRadius = 15;
            this.btnLimpar.BorderSize = 0;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(284, 610);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextColor = System.Drawing.Color.White;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(128, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Solicitante:";
            // 
            // txtsolicitante
            // 
            this.txtsolicitante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsolicitante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtsolicitante.BorderColor = System.Drawing.Color.DimGray;
            this.txtsolicitante.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtsolicitante.BorderSize = 2;
            this.txtsolicitante.Enabled = false;
            this.txtsolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsolicitante.ForeColor = System.Drawing.Color.DimGray;
            this.txtsolicitante.Location = new System.Drawing.Point(315, 121);
            this.txtsolicitante.Margin = new System.Windows.Forms.Padding(4);
            this.txtsolicitante.Multiline = false;
            this.txtsolicitante.Name = "txtsolicitante";
            this.txtsolicitante.Padding = new System.Windows.Forms.Padding(7);
            this.txtsolicitante.PasswordChar = false;
            this.txtsolicitante.Size = new System.Drawing.Size(250, 35);
            this.txtsolicitante.TabIndex = 13;
            this.txtsolicitante.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(128, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Equipamento:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(128, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Localização:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(625, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Setor:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(128, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.BorderColor = System.Drawing.Color.DimGray;
            this.txtTitulo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTitulo.BorderSize = 2;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo.Location = new System.Drawing.Point(245, 272);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.Size = new System.Drawing.Size(733, 35);
            this.txtTitulo.TabIndex = 21;
            this.txtTitulo.UnderlinedStyle = true;
            // 
            // rtbdescricao
            // 
            this.rtbdescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbdescricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbdescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbdescricao.ForeColor = System.Drawing.Color.DimGray;
            this.rtbdescricao.Location = new System.Drawing.Point(133, 334);
            this.rtbdescricao.Name = "rtbdescricao";
            this.rtbdescricao.Size = new System.Drawing.Size(845, 254);
            this.rtbdescricao.TabIndex = 23;
            this.rtbdescricao.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(625, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 25;
            this.label6.Text = "Data:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 71);
            this.panel2.TabIndex = 26;
            // 
            // cmbData
            // 
            this.cmbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbData.BorderColor = System.Drawing.Color.DimGray;
            this.cmbData.BorderSize = 2;
            this.cmbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbData.Enabled = false;
            this.cmbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbData.ForeColor = System.Drawing.Color.DimGray;
            this.cmbData.IconColor = System.Drawing.Color.Gray;
            this.cmbData.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbData.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbData.Location = new System.Drawing.Point(727, 173);
            this.cmbData.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbData.Name = "cmbData";
            this.cmbData.Padding = new System.Windows.Forms.Padding(2);
            this.cmbData.Size = new System.Drawing.Size(251, 30);
            this.cmbData.TabIndex = 24;
            this.cmbData.Texts = "";
            // 
            // cmbSetor
            // 
            this.cmbSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSetor.BorderColor = System.Drawing.Color.DimGray;
            this.cmbSetor.BorderSize = 2;
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSetor.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSetor.IconColor = System.Drawing.Color.Gray;
            this.cmbSetor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSetor.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSetor.Location = new System.Drawing.Point(727, 220);
            this.cmbSetor.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Padding = new System.Windows.Forms.Padding(2);
            this.cmbSetor.Size = new System.Drawing.Size(251, 30);
            this.cmbSetor.TabIndex = 19;
            this.cmbSetor.Texts = "";
            // 
            // cmbLocal
            // 
            this.cmbLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbLocal.BorderColor = System.Drawing.Color.DimGray;
            this.cmbLocal.BorderSize = 2;
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbLocal.ForeColor = System.Drawing.Color.DimGray;
            this.cmbLocal.IconColor = System.Drawing.Color.Gray;
            this.cmbLocal.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbLocal.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbLocal.Location = new System.Drawing.Point(315, 220);
            this.cmbLocal.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Padding = new System.Windows.Forms.Padding(2);
            this.cmbLocal.Size = new System.Drawing.Size(250, 30);
            this.cmbLocal.TabIndex = 17;
            this.cmbLocal.Texts = "";
            // 
            // cmbEquipamento
            // 
            this.cmbEquipamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEquipamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEquipamento.BorderColor = System.Drawing.Color.DimGray;
            this.cmbEquipamento.BorderSize = 2;
            this.cmbEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbEquipamento.ForeColor = System.Drawing.Color.DimGray;
            this.cmbEquipamento.IconColor = System.Drawing.Color.Gray;
            this.cmbEquipamento.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbEquipamento.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbEquipamento.Location = new System.Drawing.Point(315, 173);
            this.cmbEquipamento.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbEquipamento.Name = "cmbEquipamento";
            this.cmbEquipamento.Padding = new System.Windows.Forms.Padding(2);
            this.cmbEquipamento.Size = new System.Drawing.Size(250, 30);
            this.cmbEquipamento.TabIndex = 15;
            this.cmbEquipamento.Texts = "";
            // 
            // Frmabrirchamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbData);
            this.Controls.Add(this.rtbdescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEquipamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsolicitante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmabrirchamados";
            this.Text = "Frmabrirchamados";
            this.Load += new System.EventHandler(this.Frmabrirchamados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnPrincipal;
        private controls.ModeloBotao btnCancelar;
        private controls.ModeloBotao btnLimpar;
        private controls.ModeloBotao btnSalvar;
        private System.Windows.Forms.Label label1;
        private controls.novoTextBox txtsolicitante;
        private controls.novosComboBox cmbEquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private controls.novosComboBox cmbLocal;
        private System.Windows.Forms.Label label4;
        private controls.novosComboBox cmbSetor;
        private System.Windows.Forms.Label label5;
        private controls.novoTextBox txtTitulo;
        private System.Windows.Forms.RichTextBox rtbdescricao;
        private System.Windows.Forms.Label label6;
        private controls.novosComboBox cmbData;
        private System.Windows.Forms.Panel panel2;
    }
}