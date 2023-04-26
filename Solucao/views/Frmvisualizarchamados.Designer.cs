namespace Solucao.views
{
    partial class Frmvisualizarchamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmvisualizarchamados));
            this.label6 = new System.Windows.Forms.Label();
            this.rtbdescricao = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new Solucao.controls.novoTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSetor = new Solucao.controls.novosComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLocal = new Solucao.controls.novosComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEquipamento = new Solucao.controls.novosComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsolicitante = new Solucao.controls.novoTextBox();
            this.btnSair = new Solucao.controls.ModeloBotao();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnPrincipal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStatus = new Solucao.controls.novosComboBox();
            this.txtResponsavel = new Solucao.controls.novoTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(613, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 42;
            this.label6.Text = "Resp.:";
            // 
            // rtbdescricao
            // 
            this.rtbdescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbdescricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbdescricao.Enabled = false;
            this.rtbdescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbdescricao.ForeColor = System.Drawing.Color.DimGray;
            this.rtbdescricao.Location = new System.Drawing.Point(133, 326);
            this.rtbdescricao.Name = "rtbdescricao";
            this.rtbdescricao.ReadOnly = true;
            this.rtbdescricao.Size = new System.Drawing.Size(845, 254);
            this.rtbdescricao.TabIndex = 40;
            this.rtbdescricao.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(128, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.BorderColor = System.Drawing.Color.DimGray;
            this.txtTitulo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTitulo.BorderSize = 2;
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo.Location = new System.Drawing.Point(245, 264);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.Size = new System.Drawing.Size(733, 35);
            this.txtTitulo.TabIndex = 38;
            this.txtTitulo.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(611, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 37;
            this.label4.Text = "Setor:";
            // 
            // cmbSetor
            // 
            this.cmbSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSetor.BorderColor = System.Drawing.Color.DimGray;
            this.cmbSetor.BorderSize = 2;
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSetor.Enabled = false;
            this.cmbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSetor.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSetor.IconColor = System.Drawing.Color.Gray;
            this.cmbSetor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSetor.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSetor.Location = new System.Drawing.Point(727, 209);
            this.cmbSetor.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Padding = new System.Windows.Forms.Padding(2);
            this.cmbSetor.Size = new System.Drawing.Size(251, 30);
            this.cmbSetor.TabIndex = 36;
            this.cmbSetor.Texts = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(126, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "Localização:";
            // 
            // cmbLocal
            // 
            this.cmbLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbLocal.BorderColor = System.Drawing.Color.DimGray;
            this.cmbLocal.BorderSize = 2;
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbLocal.Enabled = false;
            this.cmbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbLocal.ForeColor = System.Drawing.Color.DimGray;
            this.cmbLocal.IconColor = System.Drawing.Color.Gray;
            this.cmbLocal.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbLocal.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbLocal.Location = new System.Drawing.Point(313, 209);
            this.cmbLocal.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Padding = new System.Windows.Forms.Padding(2);
            this.cmbLocal.Size = new System.Drawing.Size(250, 30);
            this.cmbLocal.TabIndex = 34;
            this.cmbLocal.Texts = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(126, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Equipamento:";
            // 
            // cmbEquipamento
            // 
            this.cmbEquipamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEquipamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEquipamento.BorderColor = System.Drawing.Color.DimGray;
            this.cmbEquipamento.BorderSize = 2;
            this.cmbEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbEquipamento.Enabled = false;
            this.cmbEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbEquipamento.ForeColor = System.Drawing.Color.DimGray;
            this.cmbEquipamento.IconColor = System.Drawing.Color.Gray;
            this.cmbEquipamento.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbEquipamento.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbEquipamento.Location = new System.Drawing.Point(313, 162);
            this.cmbEquipamento.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbEquipamento.Name = "cmbEquipamento";
            this.cmbEquipamento.Padding = new System.Windows.Forms.Padding(2);
            this.cmbEquipamento.Size = new System.Drawing.Size(250, 30);
            this.cmbEquipamento.TabIndex = 32;
            this.cmbEquipamento.Texts = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(126, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 31;
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
            this.txtsolicitante.Location = new System.Drawing.Point(313, 110);
            this.txtsolicitante.Margin = new System.Windows.Forms.Padding(4);
            this.txtsolicitante.Multiline = false;
            this.txtsolicitante.Name = "txtsolicitante";
            this.txtsolicitante.Padding = new System.Windows.Forms.Padding(7);
            this.txtsolicitante.PasswordChar = false;
            this.txtsolicitante.Size = new System.Drawing.Size(250, 35);
            this.txtsolicitante.TabIndex = 30;
            this.txtsolicitante.UnderlinedStyle = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.Crimson;
            this.btnSair.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnSair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSair.BorderRadius = 15;
            this.btnSair.BorderSize = 0;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(133, 627);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 40);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbnPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 49);
            this.panel1.TabIndex = 26;
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
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(613, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 27);
            this.label7.TabIndex = 44;
            this.label7.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbStatus.BorderColor = System.Drawing.Color.DimGray;
            this.cmbStatus.BorderSize = 2;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cmbStatus.IconColor = System.Drawing.Color.Gray;
            this.cmbStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbStatus.Location = new System.Drawing.Point(727, 162);
            this.cmbStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Padding = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Size = new System.Drawing.Size(251, 30);
            this.cmbStatus.TabIndex = 43;
            this.cmbStatus.Texts = "";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResponsavel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResponsavel.BorderColor = System.Drawing.Color.DimGray;
            this.txtResponsavel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtResponsavel.BorderSize = 2;
            this.txtResponsavel.Enabled = false;
            this.txtResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavel.ForeColor = System.Drawing.Color.DimGray;
            this.txtResponsavel.Location = new System.Drawing.Point(728, 110);
            this.txtResponsavel.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponsavel.Multiline = false;
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Padding = new System.Windows.Forms.Padding(7);
            this.txtResponsavel.PasswordChar = false;
            this.txtResponsavel.Size = new System.Drawing.Size(250, 35);
            this.txtResponsavel.TabIndex = 45;
            this.txtResponsavel.UnderlinedStyle = true;
            // 
            // Frmvisualizarchamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 679);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmvisualizarchamados";
            this.Text = "Frmvisualizarchamados";
            this.Load += new System.EventHandler(this.Frmvisualizarchamados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbdescricao;
        private System.Windows.Forms.Label label5;
        private controls.novoTextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private controls.novosComboBox cmbSetor;
        private System.Windows.Forms.Label label3;
        private controls.novosComboBox cmbLocal;
        private System.Windows.Forms.Label label2;
        private controls.novosComboBox cmbEquipamento;
        private System.Windows.Forms.Label label1;
        private controls.novoTextBox txtsolicitante;
        private controls.ModeloBotao btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnPrincipal;
        private System.Windows.Forms.Label label7;
        private controls.novosComboBox cmbStatus;
        private controls.novoTextBox txtResponsavel;
    }
}