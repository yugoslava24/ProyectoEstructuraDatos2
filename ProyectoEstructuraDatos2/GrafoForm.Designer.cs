
namespace ProyectoEstructuraDatos2
{
    partial class GrafoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafoForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimi = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbGrafos = new System.Windows.Forms.GroupBox();
            this.btnEliminarConexion = new System.Windows.Forms.Button();
            this.txtBuscarParada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEliminarParada = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgParadas = new System.Windows.Forms.DataGridView();
            this.btnImprimirGrafo = new System.Windows.Forms.Button();
            this.comboBoxParada2 = new System.Windows.Forms.ComboBox();
            this.comboBoxParada1 = new System.Windows.Forms.ComboBox();
            this.txtNombreParada = new System.Windows.Forms.TextBox();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnAgregarConexion = new System.Windows.Forms.Button();
            this.btnBuscarParada = new System.Windows.Forms.Button();
            this.btnEliminarParada = new System.Windows.Forms.Button();
            this.btnAgregarParada = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.gbGrafos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParadas)).BeginInit();
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
            this.panelTop.TabIndex = 22;
            // 
            // btnMinimi
            // 
            this.btnMinimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimi.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimi.Image")));
            this.btnMinimi.Location = new System.Drawing.Point(725, 2);
            this.btnMinimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimi.Name = "btnMinimi";
            this.btnMinimi.Size = new System.Drawing.Size(23, 20);
            this.btnMinimi.TabIndex = 23;
            this.btnMinimi.UseVisualStyleBackColor = true;
            this.btnMinimi.Click += new System.EventHandler(this.btnMinimi_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(752, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 20);
            this.btnMaximizar.TabIndex = 24;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(779, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 20);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbGrafos
            // 
            this.gbGrafos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGrafos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.gbGrafos.Controls.Add(this.lblGrafo);
            this.gbGrafos.Controls.Add(this.btnImprimir);
            this.gbGrafos.Controls.Add(this.btnEliminarConexion);
            this.gbGrafos.Controls.Add(this.txtBuscarParada);
            this.gbGrafos.Controls.Add(this.label6);
            this.gbGrafos.Controls.Add(this.label5);
            this.gbGrafos.Controls.Add(this.comboBoxEliminarParada);
            this.gbGrafos.Controls.Add(this.label4);
            this.gbGrafos.Controls.Add(this.label3);
            this.gbGrafos.Controls.Add(this.label2);
            this.gbGrafos.Controls.Add(this.label1);
            this.gbGrafos.Controls.Add(this.dtgParadas);
            this.gbGrafos.Controls.Add(this.btnImprimirGrafo);
            this.gbGrafos.Controls.Add(this.comboBoxParada2);
            this.gbGrafos.Controls.Add(this.comboBoxParada1);
            this.gbGrafos.Controls.Add(this.txtNombreParada);
            this.gbGrafos.Controls.Add(this.btnMenuPrincipal);
            this.gbGrafos.Controls.Add(this.btnAgregarConexion);
            this.gbGrafos.Controls.Add(this.btnBuscarParada);
            this.gbGrafos.Controls.Add(this.btnEliminarParada);
            this.gbGrafos.Controls.Add(this.btnAgregarParada);
            this.gbGrafos.Location = new System.Drawing.Point(27, 109);
            this.gbGrafos.Margin = new System.Windows.Forms.Padding(2);
            this.gbGrafos.Name = "gbGrafos";
            this.gbGrafos.Padding = new System.Windows.Forms.Padding(2);
            this.gbGrafos.Size = new System.Drawing.Size(748, 338);
            this.gbGrafos.TabIndex = 23;
            this.gbGrafos.TabStop = false;
            // 
            // btnEliminarConexion
            // 
            this.btnEliminarConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarConexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarConexion.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarConexion.Image")));
            this.btnEliminarConexion.Location = new System.Drawing.Point(585, 130);
            this.btnEliminarConexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarConexion.Name = "btnEliminarConexion";
            this.btnEliminarConexion.Size = new System.Drawing.Size(65, 57);
            this.btnEliminarConexion.TabIndex = 49;
            this.btnEliminarConexion.UseVisualStyleBackColor = false;
            this.btnEliminarConexion.Click += new System.EventHandler(this.btnEliminarConexion_Click);
            // 
            // txtBuscarParada
            // 
            this.txtBuscarParada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscarParada.Location = new System.Drawing.Point(255, 54);
            this.txtBuscarParada.Name = "txtBuscarParada";
            this.txtBuscarParada.Size = new System.Drawing.Size(133, 20);
            this.txtBuscarParada.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ingrese la parada a buscar:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Parada a eliminar:";
            // 
            // comboBoxEliminarParada
            // 
            this.comboBoxEliminarParada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxEliminarParada.FormattingEnabled = true;
            this.comboBoxEliminarParada.Location = new System.Drawing.Point(312, 130);
            this.comboBoxEliminarParada.Name = "comboBoxEliminarParada";
            this.comboBoxEliminarParada.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEliminarParada.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Paradas de destino:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Paradas de origen:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Seleccione paradas a conectar:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ingrese número o nombre de parada:";
            // 
            // dtgParadas
            // 
            this.dtgParadas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgParadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParadas.Location = new System.Drawing.Point(37, 169);
            this.dtgParadas.Name = "dtgParadas";
            this.dtgParadas.RowHeadersWidth = 62;
            this.dtgParadas.Size = new System.Drawing.Size(267, 154);
            this.dtgParadas.TabIndex = 39;
            // 
            // btnImprimirGrafo
            // 
            this.btnImprimirGrafo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirGrafo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimirGrafo.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirGrafo.Image")));
            this.btnImprimirGrafo.Location = new System.Drawing.Point(655, 130);
            this.btnImprimirGrafo.Name = "btnImprimirGrafo";
            this.btnImprimirGrafo.Size = new System.Drawing.Size(65, 57);
            this.btnImprimirGrafo.TabIndex = 38;
            this.btnImprimirGrafo.UseVisualStyleBackColor = false;
            this.btnImprimirGrafo.Click += new System.EventHandler(this.btnImprimirGrafo_Click);
            // 
            // comboBoxParada2
            // 
            this.comboBoxParada2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxParada2.FormattingEnabled = true;
            this.comboBoxParada2.Location = new System.Drawing.Point(171, 130);
            this.comboBoxParada2.Name = "comboBoxParada2";
            this.comboBoxParada2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParada2.TabIndex = 36;
            // 
            // comboBoxParada1
            // 
            this.comboBoxParada1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxParada1.FormattingEnabled = true;
            this.comboBoxParada1.Location = new System.Drawing.Point(31, 130);
            this.comboBoxParada1.Name = "comboBoxParada1";
            this.comboBoxParada1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParada1.TabIndex = 35;
            // 
            // txtNombreParada
            // 
            this.txtNombreParada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreParada.Location = new System.Drawing.Point(28, 54);
            this.txtNombreParada.Name = "txtNombreParada";
            this.txtNombreParada.Size = new System.Drawing.Size(131, 20);
            this.txtNombreParada.TabIndex = 34;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(642, 307);
            this.btnMenuPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(97, 27);
            this.btnMenuPrincipal.TabIndex = 33;
            this.btnMenuPrincipal.Text = "Menú principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnAgregarConexion
            // 
            this.btnAgregarConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarConexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarConexion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarConexion.Image")));
            this.btnAgregarConexion.Location = new System.Drawing.Point(514, 54);
            this.btnAgregarConexion.Name = "btnAgregarConexion";
            this.btnAgregarConexion.Size = new System.Drawing.Size(65, 57);
            this.btnAgregarConexion.TabIndex = 32;
            this.btnAgregarConexion.UseVisualStyleBackColor = false;
            this.btnAgregarConexion.Click += new System.EventHandler(this.btnAgregarConexion_Click);
            // 
            // btnBuscarParada
            // 
            this.btnBuscarParada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarParada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarParada.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarParada.Image")));
            this.btnBuscarParada.Location = new System.Drawing.Point(655, 54);
            this.btnBuscarParada.Name = "btnBuscarParada";
            this.btnBuscarParada.Size = new System.Drawing.Size(65, 57);
            this.btnBuscarParada.TabIndex = 31;
            this.btnBuscarParada.UseVisualStyleBackColor = false;
            this.btnBuscarParada.Click += new System.EventHandler(this.btnBuscarParada_Click);
            // 
            // btnEliminarParada
            // 
            this.btnEliminarParada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarParada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarParada.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarParada.Image")));
            this.btnEliminarParada.Location = new System.Drawing.Point(584, 54);
            this.btnEliminarParada.Name = "btnEliminarParada";
            this.btnEliminarParada.Size = new System.Drawing.Size(65, 57);
            this.btnEliminarParada.TabIndex = 30;
            this.btnEliminarParada.UseVisualStyleBackColor = false;
            this.btnEliminarParada.Click += new System.EventHandler(this.btnEliminarParada_Click);
            // 
            // btnAgregarParada
            // 
            this.btnAgregarParada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarParada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarParada.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarParada.Image")));
            this.btnAgregarParada.Location = new System.Drawing.Point(443, 54);
            this.btnAgregarParada.Name = "btnAgregarParada";
            this.btnAgregarParada.Size = new System.Drawing.Size(65, 57);
            this.btnAgregarParada.TabIndex = 29;
            this.btnAgregarParada.UseVisualStyleBackColor = false;
            this.btnAgregarParada.Click += new System.EventHandler(this.btnAgregarParada_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(548, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Funcionalidad: Insertar, buscar por nombre o número, agregar o quitar conexión, e" +
    "liminar,  imprimir y guardar en pdf.";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(490, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Implementar un grafo dirigido para almacenar paradas de buses con sus conexiones " +
    "(Origen - Destino).";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(623, 22);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 27);
            this.btnImprimir.TabIndex = 50;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblGrafo
            // 
            this.lblGrafo.AutoSize = true;
            this.lblGrafo.Location = new System.Drawing.Point(334, 193);
            this.lblGrafo.Name = "lblGrafo";
            this.lblGrafo.Size = new System.Drawing.Size(0, 13);
            this.lblGrafo.TabIndex = 51;
            // 
            // GrafoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(191)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(809, 474);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbGrafos);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrafoForm";
            this.Text = "Grafos";
            this.panelTop.ResumeLayout(false);
            this.gbGrafos.ResumeLayout(false);
            this.gbGrafos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimi;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.GroupBox gbGrafos;
        private System.Windows.Forms.Button btnAgregarConexion;
        private System.Windows.Forms.Button btnBuscarParada;
        private System.Windows.Forms.Button btnEliminarParada;
        private System.Windows.Forms.Button btnAgregarParada;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.ComboBox comboBoxParada2;
        private System.Windows.Forms.ComboBox comboBoxParada1;
        private System.Windows.Forms.TextBox txtNombreParada;
        private System.Windows.Forms.Button btnImprimirGrafo;
        private System.Windows.Forms.DataGridView dtgParadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEliminarParada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarParada;
        private System.Windows.Forms.Button btnEliminarConexion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblGrafo;
    }
}