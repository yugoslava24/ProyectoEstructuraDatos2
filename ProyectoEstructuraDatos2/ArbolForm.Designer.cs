
namespace ProyectoEstructuraDatos2
{
    partial class ArbolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArbolForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimi = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbArbol = new System.Windows.Forms.GroupBox();
            this.btnImprimirArbol = new System.Windows.Forms.Button();
            this.lblArbol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dtgArboles = new System.Windows.Forms.DataGridView();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.gbArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArboles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.panelTop.Controls.Add(this.btnMinimi);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(809, 31);
            this.panelTop.TabIndex = 23;
            // 
            // btnMinimi
            // 
            this.btnMinimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimi.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimi.Image")));
            this.btnMinimi.Location = new System.Drawing.Point(729, 2);
            this.btnMinimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimi.Name = "btnMinimi";
            this.btnMinimi.Size = new System.Drawing.Size(23, 20);
            this.btnMinimi.TabIndex = 26;
            this.btnMinimi.UseVisualStyleBackColor = true;
            this.btnMinimi.Click += new System.EventHandler(this.btnMinimi_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(756, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 20);
            this.btnMaximizar.TabIndex = 27;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(783, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 20);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbArbol
            // 
            this.gbArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbArbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.gbArbol.Controls.Add(this.btnImprimirArbol);
            this.gbArbol.Controls.Add(this.lblArbol);
            this.gbArbol.Controls.Add(this.label4);
            this.gbArbol.Controls.Add(this.txtNum);
            this.gbArbol.Controls.Add(this.btnMenuPrincipal);
            this.gbArbol.Controls.Add(this.btnPdf);
            this.gbArbol.Controls.Add(this.btnBuscar);
            this.gbArbol.Controls.Add(this.btnEliminar);
            this.gbArbol.Controls.Add(this.btnInsertar);
            this.gbArbol.Controls.Add(this.dtgArboles);
            this.gbArbol.Controls.Add(this.label2);
            this.gbArbol.Controls.Add(this.label1);
            this.gbArbol.Controls.Add(this.txtBuscar);
            this.gbArbol.Controls.Add(this.txtNombre);
            this.gbArbol.Location = new System.Drawing.Point(29, 129);
            this.gbArbol.Margin = new System.Windows.Forms.Padding(2);
            this.gbArbol.Name = "gbArbol";
            this.gbArbol.Padding = new System.Windows.Forms.Padding(2);
            this.gbArbol.Size = new System.Drawing.Size(750, 324);
            this.gbArbol.TabIndex = 24;
            this.gbArbol.TabStop = false;
            // 
            // btnImprimirArbol
            // 
            this.btnImprimirArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirArbol.Location = new System.Drawing.Point(641, 25);
            this.btnImprimirArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimirArbol.Name = "btnImprimirArbol";
            this.btnImprimirArbol.Size = new System.Drawing.Size(97, 27);
            this.btnImprimirArbol.TabIndex = 26;
            this.btnImprimirArbol.Text = "Imprimir";
            this.btnImprimirArbol.UseVisualStyleBackColor = true;
            this.btnImprimirArbol.Click += new System.EventHandler(this.btnImprimirArbol_Click);
            // 
            // lblArbol
            // 
            this.lblArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArbol.AutoSize = true;
            this.lblArbol.Location = new System.Drawing.Point(342, 190);
            this.lblArbol.Name = "lblArbol";
            this.lblArbol.Size = new System.Drawing.Size(0, 13);
            this.lblArbol.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Número:";
            // 
            // txtNum
            // 
            this.txtNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNum.Location = new System.Drawing.Point(56, 114);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 23;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(646, 294);
            this.btnMenuPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(97, 27);
            this.btnMenuPrincipal.TabIndex = 22;
            this.btnMenuPrincipal.Text = "Menú principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.Image")));
            this.btnPdf.Location = new System.Drawing.Point(673, 64);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(65, 57);
            this.btnPdf.TabIndex = 21;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(603, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 57);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(532, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 57);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
            this.btnInsertar.Location = new System.Drawing.Point(461, 64);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(65, 57);
            this.btnInsertar.TabIndex = 18;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dtgArboles
            // 
            this.dtgArboles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgArboles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArboles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contacto,
            this.Número});
            this.dtgArboles.Location = new System.Drawing.Point(33, 157);
            this.dtgArboles.Name = "dtgArboles";
            this.dtgArboles.RowHeadersWidth = 62;
            this.dtgArboles.Size = new System.Drawing.Size(267, 154);
            this.dtgArboles.TabIndex = 17;
            this.dtgArboles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArboles_CellClick);
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buscar por nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Location = new System.Drawing.Point(196, 79);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(56, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Implementa un árbol binario para almacenar contactos en una agenda.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(458, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cada nodo puede representar un contacto con información como nombre y número de t" +
    "eléfono:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Funcionalidad: Insertar, buscar por nombre, eliminar, imprimir y guardar en pdf.";
            // 
            // ArbolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(191)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(809, 474);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbArbol);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArbolForm";
            this.Text = "Árboles binarios";
            this.panelTop.ResumeLayout(false);
            this.gbArbol.ResumeLayout(false);
            this.gbArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArboles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMinimi;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbArbol;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtgArboles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.Label lblArbol;
        private System.Windows.Forms.Button btnImprimirArbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}