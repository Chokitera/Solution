namespace Solucao.controls
{
    partial class Chamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamado));
            this.pnlurgencia = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsetor = new Solucao.controls.novoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstatus = new Solucao.controls.novoTextBox();
            this.rtbdescricao = new System.Windows.Forms.RichTextBox();
            this.lblnumerochamado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresponsavel = new Solucao.controls.novoTextBox();
            this.btnVisualizar = new Solucao.controls.ModeloBotao();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsolicitante = new Solucao.controls.novoTextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlurgencia
            // 
            this.pnlurgencia.BackColor = System.Drawing.Color.Red;
            this.pnlurgencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlurgencia.Location = new System.Drawing.Point(0, 0);
            this.pnlurgencia.Name = "pnlurgencia";
            this.pnlurgencia.Size = new System.Drawing.Size(24, 310);
            this.pnlurgencia.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtsetor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtstatus);
            this.panel2.Controls.Add(this.rtbdescricao);
            this.panel2.Controls.Add(this.lblnumerochamado);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtresponsavel);
            this.panel2.Controls.Add(this.btnVisualizar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtsolicitante);
            this.panel2.Controls.Add(this.lbltitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(24, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 310);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(283, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "-";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(292, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 15);
            this.lblHora.TabIndex = 36;
            this.lblHora.Text = "11:15";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(213, 3);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(73, 15);
            this.lblData.TabIndex = 35;
            this.lblData.Text = "01/01/2023";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Setor:";
            // 
            // txtsetor
            // 
            this.txtsetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtsetor.BorderColor = System.Drawing.Color.White;
            this.txtsetor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtsetor.BorderSize = 2;
            this.txtsetor.Enabled = false;
            this.txtsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetor.ForeColor = System.Drawing.Color.White;
            this.txtsetor.Location = new System.Drawing.Point(99, 109);
            this.txtsetor.Margin = new System.Windows.Forms.Padding(4);
            this.txtsetor.Multiline = false;
            this.txtsetor.Name = "txtsetor";
            this.txtsetor.Padding = new System.Windows.Forms.Padding(7);
            this.txtsetor.PasswordChar = false;
            this.txtsetor.Size = new System.Drawing.Size(151, 30);
            this.txtsetor.TabIndex = 33;
            this.txtsetor.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Status:";
            // 
            // txtstatus
            // 
            this.txtstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtstatus.BorderColor = System.Drawing.Color.White;
            this.txtstatus.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtstatus.BorderSize = 2;
            this.txtstatus.Enabled = false;
            this.txtstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.ForeColor = System.Drawing.Color.White;
            this.txtstatus.Location = new System.Drawing.Point(99, 137);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtstatus.Multiline = false;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Padding = new System.Windows.Forms.Padding(7);
            this.txtstatus.PasswordChar = false;
            this.txtstatus.Size = new System.Drawing.Size(151, 30);
            this.txtstatus.TabIndex = 31;
            this.txtstatus.UnderlinedStyle = true;
            // 
            // rtbdescricao
            // 
            this.rtbdescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rtbdescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbdescricao.ForeColor = System.Drawing.Color.White;
            this.rtbdescricao.Location = new System.Drawing.Point(32, 172);
            this.rtbdescricao.Name = "rtbdescricao";
            this.rtbdescricao.ReadOnly = true;
            this.rtbdescricao.Size = new System.Drawing.Size(267, 95);
            this.rtbdescricao.TabIndex = 30;
            this.rtbdescricao.Text = "";
            // 
            // lblnumerochamado
            // 
            this.lblnumerochamado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnumerochamado.AutoSize = true;
            this.lblnumerochamado.Font = new System.Drawing.Font("Segoe UI Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblnumerochamado.ForeColor = System.Drawing.Color.White;
            this.lblnumerochamado.Location = new System.Drawing.Point(3, 3);
            this.lblnumerochamado.Name = "lblnumerochamado";
            this.lblnumerochamado.Size = new System.Drawing.Size(89, 15);
            this.lblnumerochamado.TabIndex = 29;
            this.lblnumerochamado.Text = "CHAMADO #1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Responsável:";
            // 
            // txtresponsavel
            // 
            this.txtresponsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtresponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtresponsavel.BorderColor = System.Drawing.Color.White;
            this.txtresponsavel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtresponsavel.BorderSize = 2;
            this.txtresponsavel.Enabled = false;
            this.txtresponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresponsavel.ForeColor = System.Drawing.Color.White;
            this.txtresponsavel.Location = new System.Drawing.Point(148, 79);
            this.txtresponsavel.Margin = new System.Windows.Forms.Padding(4);
            this.txtresponsavel.Multiline = false;
            this.txtresponsavel.Name = "txtresponsavel";
            this.txtresponsavel.Padding = new System.Windows.Forms.Padding(7);
            this.txtresponsavel.PasswordChar = false;
            this.txtresponsavel.Size = new System.Drawing.Size(151, 30);
            this.txtresponsavel.TabIndex = 27;
            this.txtresponsavel.UnderlinedStyle = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(168)))));
            this.btnVisualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(168)))));
            this.btnVisualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVisualizar.BorderRadius = 15;
            this.btnVisualizar.BorderSize = 0;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(99, 269);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(124, 38);
            this.btnVisualizar.TabIndex = 26;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextColor = System.Drawing.Color.White;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Solicitante:";
            // 
            // txtsolicitante
            // 
            this.txtsolicitante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsolicitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtsolicitante.BorderColor = System.Drawing.Color.White;
            this.txtsolicitante.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtsolicitante.BorderSize = 2;
            this.txtsolicitante.Enabled = false;
            this.txtsolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsolicitante.ForeColor = System.Drawing.Color.White;
            this.txtsolicitante.Location = new System.Drawing.Point(148, 47);
            this.txtsolicitante.Margin = new System.Windows.Forms.Padding(4);
            this.txtsolicitante.Multiline = false;
            this.txtsolicitante.Name = "txtsolicitante";
            this.txtsolicitante.Padding = new System.Windows.Forms.Padding(7);
            this.txtsolicitante.PasswordChar = false;
            this.txtsolicitante.Size = new System.Drawing.Size(151, 30);
            this.txtsolicitante.TabIndex = 24;
            this.txtsolicitante.UnderlinedStyle = true;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI Black", 16.75F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(2, 15);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(99, 31);
            this.lbltitulo.TabIndex = 23;
            this.lbltitulo.Text = "TÍTULO";
            // 
            // Chamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlurgencia);
            this.Name = "Chamado";
            this.Size = new System.Drawing.Size(355, 310);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlurgencia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbdescricao;
        private System.Windows.Forms.Label lblnumerochamado;
        private System.Windows.Forms.Label label2;
        private novoTextBox txtresponsavel;
        private ModeloBotao btnVisualizar;
        private System.Windows.Forms.Label label4;
        private novoTextBox txtsolicitante;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private novoTextBox txtstatus;
        private System.Windows.Forms.Label label5;
        private novoTextBox txtsetor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
    }
}
