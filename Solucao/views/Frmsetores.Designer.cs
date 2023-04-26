namespace Solucao.views
{
    partial class Frmsetores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsetores));
            this.lbnPrincipal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbetiquetasetor = new Solucao.controls.novosComboBox();
            this.cmbetiquetalocal = new Solucao.controls.novosComboBox();
            this.txttagsetor = new Solucao.controls.novoTextBox();
            this.txttaglocal = new Solucao.controls.novoTextBox();
            this.txtcodigosetor = new Solucao.controls.novoTextBox();
            this.txtcodigolocal = new Solucao.controls.novoTextBox();
            this.btnExcluirSetor = new Solucao.controls.ModeloBotao();
            this.btnNovoSetor = new Solucao.controls.ModeloBotao();
            this.btnSalvarSetor = new Solucao.controls.ModeloBotao();
            this.btnExcluirLocal = new Solucao.controls.ModeloBotao();
            this.btnNovoLocal = new Solucao.controls.ModeloBotao();
            this.btnSalvarLocal = new Solucao.controls.ModeloBotao();
            this.txtsetor = new Solucao.controls.novoTextBox();
            this.txtlocal = new Solucao.controls.novoTextBox();
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
            this.lbnPrincipal.Size = new System.Drawing.Size(168, 35);
            this.lbnPrincipal.TabIndex = 0;
            this.lbnPrincipal.Text = "CADASTROS";
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(47, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Localização:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(611, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Setor:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(556, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 631);
            this.panel2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(47, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(611, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(47, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "Etiqueta:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(47, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "TAG:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(615, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "TAG:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(615, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 27);
            this.label8.TabIndex = 36;
            this.label8.Text = "Etiqueta:";
            // 
            // cmbetiquetasetor
            // 
            this.cmbetiquetasetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbetiquetasetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbetiquetasetor.BorderColor = System.Drawing.Color.DimGray;
            this.cmbetiquetasetor.BorderSize = 2;
            this.cmbetiquetasetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbetiquetasetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbetiquetasetor.ForeColor = System.Drawing.Color.DimGray;
            this.cmbetiquetasetor.IconColor = System.Drawing.Color.Gray;
            this.cmbetiquetasetor.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbetiquetasetor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbetiquetasetor.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbetiquetasetor.Location = new System.Drawing.Point(759, 189);
            this.cmbetiquetasetor.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbetiquetasetor.Name = "cmbetiquetasetor";
            this.cmbetiquetasetor.Padding = new System.Windows.Forms.Padding(2);
            this.cmbetiquetasetor.Size = new System.Drawing.Size(250, 30);
            this.cmbetiquetasetor.TabIndex = 10;
            this.cmbetiquetasetor.Texts = "";
            this.cmbetiquetasetor.Leave += new System.EventHandler(this.cmbetiquetasetor_Leave);
            // 
            // cmbetiquetalocal
            // 
            this.cmbetiquetalocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbetiquetalocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbetiquetalocal.BorderColor = System.Drawing.Color.DimGray;
            this.cmbetiquetalocal.BorderSize = 2;
            this.cmbetiquetalocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbetiquetalocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbetiquetalocal.ForeColor = System.Drawing.Color.DimGray;
            this.cmbetiquetalocal.IconColor = System.Drawing.Color.Gray;
            this.cmbetiquetalocal.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbetiquetalocal.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbetiquetalocal.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbetiquetalocal.Location = new System.Drawing.Point(191, 189);
            this.cmbetiquetalocal.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbetiquetalocal.Name = "cmbetiquetalocal";
            this.cmbetiquetalocal.Padding = new System.Windows.Forms.Padding(2);
            this.cmbetiquetalocal.Size = new System.Drawing.Size(250, 30);
            this.cmbetiquetalocal.TabIndex = 3;
            this.cmbetiquetalocal.Texts = "";
            this.cmbetiquetalocal.Leave += new System.EventHandler(this.cmbetiquetalocal_Leave);
            // 
            // txttagsetor
            // 
            this.txttagsetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttagsetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttagsetor.BorderColor = System.Drawing.Color.DimGray;
            this.txttagsetor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txttagsetor.BorderSize = 2;
            this.txttagsetor.Enabled = false;
            this.txttagsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttagsetor.ForeColor = System.Drawing.Color.DimGray;
            this.txttagsetor.Location = new System.Drawing.Point(690, 237);
            this.txttagsetor.Margin = new System.Windows.Forms.Padding(4);
            this.txttagsetor.Multiline = false;
            this.txttagsetor.Name = "txttagsetor";
            this.txttagsetor.Padding = new System.Windows.Forms.Padding(7);
            this.txttagsetor.PasswordChar = false;
            this.txttagsetor.Size = new System.Drawing.Size(250, 35);
            this.txttagsetor.TabIndex = 11;
            this.txttagsetor.UnderlinedStyle = true;
            // 
            // txttaglocal
            // 
            this.txttaglocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttaglocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttaglocal.BorderColor = System.Drawing.Color.DimGray;
            this.txttaglocal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txttaglocal.BorderSize = 2;
            this.txttaglocal.Enabled = false;
            this.txttaglocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaglocal.ForeColor = System.Drawing.Color.DimGray;
            this.txttaglocal.Location = new System.Drawing.Point(122, 237);
            this.txttaglocal.Margin = new System.Windows.Forms.Padding(4);
            this.txttaglocal.Multiline = false;
            this.txttaglocal.Name = "txttaglocal";
            this.txttaglocal.Padding = new System.Windows.Forms.Padding(7);
            this.txttaglocal.PasswordChar = false;
            this.txttaglocal.Size = new System.Drawing.Size(250, 35);
            this.txttaglocal.TabIndex = 4;
            this.txttaglocal.UnderlinedStyle = true;
            // 
            // txtcodigosetor
            // 
            this.txtcodigosetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcodigosetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcodigosetor.BorderColor = System.Drawing.Color.DimGray;
            this.txtcodigosetor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtcodigosetor.BorderSize = 2;
            this.txtcodigosetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigosetor.ForeColor = System.Drawing.Color.DimGray;
            this.txtcodigosetor.Location = new System.Drawing.Point(728, 81);
            this.txtcodigosetor.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigosetor.Multiline = false;
            this.txtcodigosetor.Name = "txtcodigosetor";
            this.txtcodigosetor.Padding = new System.Windows.Forms.Padding(7);
            this.txtcodigosetor.PasswordChar = false;
            this.txtcodigosetor.Size = new System.Drawing.Size(170, 35);
            this.txtcodigosetor.TabIndex = 8;
            this.txtcodigosetor.UnderlinedStyle = true;
            this.txtcodigosetor.Leave += new System.EventHandler(this.txtcodigosetor_Leave);
            // 
            // txtcodigolocal
            // 
            this.txtcodigolocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcodigolocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcodigolocal.BorderColor = System.Drawing.Color.DimGray;
            this.txtcodigolocal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtcodigolocal.BorderSize = 2;
            this.txtcodigolocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigolocal.ForeColor = System.Drawing.Color.DimGray;
            this.txtcodigolocal.Location = new System.Drawing.Point(164, 81);
            this.txtcodigolocal.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigolocal.Multiline = false;
            this.txtcodigolocal.Name = "txtcodigolocal";
            this.txtcodigolocal.Padding = new System.Windows.Forms.Padding(7);
            this.txtcodigolocal.PasswordChar = false;
            this.txtcodigolocal.Size = new System.Drawing.Size(170, 35);
            this.txtcodigolocal.TabIndex = 1;
            this.txtcodigolocal.UnderlinedStyle = true;
            this.txtcodigolocal.Leave += new System.EventHandler(this.txtcodigolocal_Leave);
            // 
            // btnExcluirSetor
            // 
            this.btnExcluirSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirSetor.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluirSetor.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnExcluirSetor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcluirSetor.BorderRadius = 15;
            this.btnExcluirSetor.BorderSize = 0;
            this.btnExcluirSetor.FlatAppearance.BorderSize = 0;
            this.btnExcluirSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirSetor.ForeColor = System.Drawing.Color.White;
            this.btnExcluirSetor.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirSetor.Image")));
            this.btnExcluirSetor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirSetor.Location = new System.Drawing.Point(913, 627);
            this.btnExcluirSetor.Name = "btnExcluirSetor";
            this.btnExcluirSetor.Size = new System.Drawing.Size(150, 40);
            this.btnExcluirSetor.TabIndex = 14;
            this.btnExcluirSetor.Text = "Excluir";
            this.btnExcluirSetor.TextColor = System.Drawing.Color.White;
            this.btnExcluirSetor.UseVisualStyleBackColor = false;
            this.btnExcluirSetor.Click += new System.EventHandler(this.btnExcluirSetor_Click);
            // 
            // btnNovoSetor
            // 
            this.btnNovoSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoSetor.BackColor = System.Drawing.Color.Orange;
            this.btnNovoSetor.BackgroundColor = System.Drawing.Color.Orange;
            this.btnNovoSetor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNovoSetor.BorderRadius = 15;
            this.btnNovoSetor.BorderSize = 0;
            this.btnNovoSetor.FlatAppearance.BorderSize = 0;
            this.btnNovoSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoSetor.ForeColor = System.Drawing.Color.White;
            this.btnNovoSetor.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoSetor.Image")));
            this.btnNovoSetor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoSetor.Location = new System.Drawing.Point(757, 627);
            this.btnNovoSetor.Name = "btnNovoSetor";
            this.btnNovoSetor.Size = new System.Drawing.Size(150, 40);
            this.btnNovoSetor.TabIndex = 13;
            this.btnNovoSetor.Text = "Novo";
            this.btnNovoSetor.TextColor = System.Drawing.Color.White;
            this.btnNovoSetor.UseVisualStyleBackColor = false;
            this.btnNovoSetor.Click += new System.EventHandler(this.btnNovoSetor_Click);
            // 
            // btnSalvarSetor
            // 
            this.btnSalvarSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarSetor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarSetor.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarSetor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalvarSetor.BorderRadius = 15;
            this.btnSalvarSetor.BorderSize = 0;
            this.btnSalvarSetor.FlatAppearance.BorderSize = 0;
            this.btnSalvarSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarSetor.ForeColor = System.Drawing.Color.White;
            this.btnSalvarSetor.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarSetor.Image")));
            this.btnSalvarSetor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarSetor.Location = new System.Drawing.Point(601, 627);
            this.btnSalvarSetor.Name = "btnSalvarSetor";
            this.btnSalvarSetor.Size = new System.Drawing.Size(150, 40);
            this.btnSalvarSetor.TabIndex = 12;
            this.btnSalvarSetor.Text = "Salvar";
            this.btnSalvarSetor.TextColor = System.Drawing.Color.White;
            this.btnSalvarSetor.UseVisualStyleBackColor = false;
            this.btnSalvarSetor.Click += new System.EventHandler(this.btnSalvarSetor_Click);
            // 
            // btnExcluirLocal
            // 
            this.btnExcluirLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirLocal.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluirLocal.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnExcluirLocal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcluirLocal.BorderRadius = 15;
            this.btnExcluirLocal.BorderSize = 0;
            this.btnExcluirLocal.FlatAppearance.BorderSize = 0;
            this.btnExcluirLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirLocal.ForeColor = System.Drawing.Color.White;
            this.btnExcluirLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirLocal.Image")));
            this.btnExcluirLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirLocal.Location = new System.Drawing.Point(354, 627);
            this.btnExcluirLocal.Name = "btnExcluirLocal";
            this.btnExcluirLocal.Size = new System.Drawing.Size(150, 40);
            this.btnExcluirLocal.TabIndex = 7;
            this.btnExcluirLocal.Text = "Excluir";
            this.btnExcluirLocal.TextColor = System.Drawing.Color.White;
            this.btnExcluirLocal.UseVisualStyleBackColor = false;
            this.btnExcluirLocal.Click += new System.EventHandler(this.btnExcluirLocal_Click);
            // 
            // btnNovoLocal
            // 
            this.btnNovoLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoLocal.BackColor = System.Drawing.Color.Orange;
            this.btnNovoLocal.BackgroundColor = System.Drawing.Color.Orange;
            this.btnNovoLocal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNovoLocal.BorderRadius = 15;
            this.btnNovoLocal.BorderSize = 0;
            this.btnNovoLocal.FlatAppearance.BorderSize = 0;
            this.btnNovoLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoLocal.ForeColor = System.Drawing.Color.White;
            this.btnNovoLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoLocal.Image")));
            this.btnNovoLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoLocal.Location = new System.Drawing.Point(198, 627);
            this.btnNovoLocal.Name = "btnNovoLocal";
            this.btnNovoLocal.Size = new System.Drawing.Size(150, 40);
            this.btnNovoLocal.TabIndex = 6;
            this.btnNovoLocal.Text = "Novo";
            this.btnNovoLocal.TextColor = System.Drawing.Color.White;
            this.btnNovoLocal.UseVisualStyleBackColor = false;
            this.btnNovoLocal.Click += new System.EventHandler(this.btnNovoLocal_Click);
            // 
            // btnSalvarLocal
            // 
            this.btnSalvarLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarLocal.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarLocal.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarLocal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalvarLocal.BorderRadius = 15;
            this.btnSalvarLocal.BorderSize = 0;
            this.btnSalvarLocal.FlatAppearance.BorderSize = 0;
            this.btnSalvarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarLocal.ForeColor = System.Drawing.Color.White;
            this.btnSalvarLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarLocal.Image")));
            this.btnSalvarLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarLocal.Location = new System.Drawing.Point(42, 627);
            this.btnSalvarLocal.Name = "btnSalvarLocal";
            this.btnSalvarLocal.Size = new System.Drawing.Size(150, 40);
            this.btnSalvarLocal.TabIndex = 5;
            this.btnSalvarLocal.Text = "Salvar";
            this.btnSalvarLocal.TextColor = System.Drawing.Color.White;
            this.btnSalvarLocal.UseVisualStyleBackColor = false;
            this.btnSalvarLocal.Click += new System.EventHandler(this.btnSalvarLocal_Click);
            // 
            // txtsetor
            // 
            this.txtsetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtsetor.BorderColor = System.Drawing.Color.DimGray;
            this.txtsetor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtsetor.BorderSize = 2;
            this.txtsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetor.ForeColor = System.Drawing.Color.DimGray;
            this.txtsetor.Location = new System.Drawing.Point(713, 131);
            this.txtsetor.Margin = new System.Windows.Forms.Padding(4);
            this.txtsetor.Multiline = false;
            this.txtsetor.Name = "txtsetor";
            this.txtsetor.Padding = new System.Windows.Forms.Padding(7);
            this.txtsetor.PasswordChar = false;
            this.txtsetor.Size = new System.Drawing.Size(250, 35);
            this.txtsetor.TabIndex = 9;
            this.txtsetor.UnderlinedStyle = true;
            // 
            // txtlocal
            // 
            this.txtlocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtlocal.BorderColor = System.Drawing.Color.DimGray;
            this.txtlocal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtlocal.BorderSize = 2;
            this.txtlocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocal.ForeColor = System.Drawing.Color.DimGray;
            this.txtlocal.Location = new System.Drawing.Point(234, 131);
            this.txtlocal.Margin = new System.Windows.Forms.Padding(4);
            this.txtlocal.Multiline = false;
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Padding = new System.Windows.Forms.Padding(7);
            this.txtlocal.PasswordChar = false;
            this.txtlocal.Size = new System.Drawing.Size(250, 35);
            this.txtlocal.TabIndex = 2;
            this.txtlocal.UnderlinedStyle = true;
            // 
            // Frmsetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 679);
            this.Controls.Add(this.cmbetiquetasetor);
            this.Controls.Add(this.cmbetiquetalocal);
            this.Controls.Add(this.txttagsetor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttaglocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcodigosetor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodigolocal);
            this.Controls.Add(this.btnExcluirSetor);
            this.Controls.Add(this.btnNovoSetor);
            this.Controls.Add(this.btnSalvarSetor);
            this.Controls.Add(this.btnExcluirLocal);
            this.Controls.Add(this.btnNovoLocal);
            this.Controls.Add(this.btnSalvarLocal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlocal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmsetores";
            this.Text = "Frmsetores";
            this.Load += new System.EventHandler(this.Frmsetores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private controls.novoTextBox txtlocal;
        private System.Windows.Forms.Label label2;
        private controls.novoTextBox txtsetor;
        private System.Windows.Forms.Panel panel2;
        private controls.ModeloBotao btnExcluirLocal;
        private controls.ModeloBotao btnNovoLocal;
        private controls.ModeloBotao btnSalvarLocal;
        private controls.ModeloBotao btnExcluirSetor;
        private controls.ModeloBotao btnNovoSetor;
        private controls.ModeloBotao btnSalvarSetor;
        private System.Windows.Forms.Label label3;
        private controls.novoTextBox txtcodigolocal;
        private System.Windows.Forms.Label label4;
        private controls.novoTextBox txtcodigosetor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private controls.novoTextBox txttaglocal;
        private controls.novoTextBox txttagsetor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private controls.novosComboBox cmbetiquetalocal;
        private controls.novosComboBox cmbetiquetasetor;
    }
}