
namespace ProyectoEstructuraDatos2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnArboles = new System.Windows.Forms.Button();
            this.btnGrafos = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimi = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArboles
            // 
            this.btnArboles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArboles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnArboles.Location = new System.Drawing.Point(118, 268);
            this.btnArboles.Margin = new System.Windows.Forms.Padding(2);
            this.btnArboles.Name = "btnArboles";
            this.btnArboles.Size = new System.Drawing.Size(113, 46);
            this.btnArboles.TabIndex = 0;
            this.btnArboles.Text = "Arboles";
            this.btnArboles.UseVisualStyleBackColor = false;
            this.btnArboles.Click += new System.EventHandler(this.btnArboles_Click);
            // 
            // btnGrafos
            // 
            this.btnGrafos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGrafos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGrafos.Location = new System.Drawing.Point(430, 268);
            this.btnGrafos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafos.Name = "btnGrafos";
            this.btnGrafos.Size = new System.Drawing.Size(113, 46);
            this.btnGrafos.TabIndex = 1;
            this.btnGrafos.Text = "Grafos";
            this.btnGrafos.UseVisualStyleBackColor = false;
            this.btnGrafos.Click += new System.EventHandler(this.btnGrafos_Click);
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
            this.panelTop.Size = new System.Drawing.Size(670, 31);
            this.panelTop.TabIndex = 2;
            // 
            // btnMinimi
            // 
            this.btnMinimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimi.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimi.Image")));
            this.btnMinimi.Location = new System.Drawing.Point(592, 2);
            this.btnMinimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimi.Name = "btnMinimi";
            this.btnMinimi.Size = new System.Drawing.Size(23, 20);
            this.btnMinimi.TabIndex = 29;
            this.btnMinimi.UseVisualStyleBackColor = true;
            this.btnMinimi.Click += new System.EventHandler(this.btnMinimi_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(619, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 20);
            this.btnMaximizar.TabIndex = 30;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(645, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 20);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ProyectoEstructuraDatos2.Properties.Resources.arbolbinario;
            this.pictureBox1.Location = new System.Drawing.Point(118, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 124);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::ProyectoEstructuraDatos2.Properties.Resources.grafos;
            this.pictureBox2.Location = new System.Drawing.Point(430, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 133);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(670, 389);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnGrafos);
            this.Controls.Add(this.btnArboles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnArboles;
        private System.Windows.Forms.Button btnGrafos;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMinimi;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

