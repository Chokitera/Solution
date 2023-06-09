﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.controls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class novosComboBox : UserControl
    {
        //Atributos
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        //Eventos
        public event EventHandler OnSelectedIndexChanged;//Default event

        //Construtor
        public novosComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: Lista aberta
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Evento padrão
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);//Atualizar o texto

            //Botão: Icone
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);//Abrir a lista
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Desenha o icone

            //Label: Texto
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            //->Evento do Mouse
            lblText.Click += new EventHandler(Surface_Click);//ComboBox selecionado
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //Controle do usuário
            this.Controls.Add(lblText);//2
            this.Controls.Add(btnIcon);//1
            this.Controls.Add(cmbList);//0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Tamanho da borda
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor; //Cor da borda
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        //Propriedades
        //-> Aparencia
        [Category("Novo Layout")]
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("Novo Layout")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();//Redesenha o icone
            }
        }

        [Category("Novo Layout")]
        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("Novo Layout")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("Novo Layout")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Cor da borda
            }
        }

        [Category("Novo Layout")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);//Tamanho da borda
                AdjustComboBoxDimensions();
            }
        }

        [Category("Novo Layout")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("Novo Layout")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;//Opcional
            }
        }

        [Category("Novo Layout")]
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("Novo Layout")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }
        //Properties
        //-> Data
        [Category("Novo Layout - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }

        [Category("Novo Layout - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [Category("Novo Layout - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }

        [Category("Novo Layout - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
        }

        [Category("Novo Layout - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }

        [Category("Novo Layout - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }

        [Category("Novo Layout - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }

        [Category("Novo Layout - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return cmbList.DisplayMember; }
            set { cmbList.DisplayMember = value; }
        }

        [Category("Novo Layout - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return cmbList.ValueMember; }
            set { cmbList.ValueMember = value; }
        }

        //Métodos privados
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        //Métodos nos eventos

        //-> Eventos padrões
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Atualiza o texto
            lblText.Text = cmbList.Text;
        }

        //-> Desenha o icone
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Atributos
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            //Desenho da seta do ComboBox
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        //-> Ações com os itens
        private void Icon_Click(object sender, EventArgs e)
        {
            //Abre a lista para baixo
            cmbList.Select();
            cmbList.DroppedDown = true;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            //Evento do Mouse
            this.OnClick(e);
            //Escolher o item
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;//Abre a lista para baixo
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Atualiza o Texto
            lblText.Text = cmbList.Text;
        }

        //->Evento do Mouse
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        //::::+

        //Overridden métodos
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
