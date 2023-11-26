using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuraDatos2
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        private bool mouse;
        private Point posicion;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(FormularioMouseAbajo);
            this.MouseMove += new MouseEventHandler(FormularioMouseMovimiento);
            this.MouseUp += new MouseEventHandler(FormularioMouseArriba);
        }

        void FormularioMouseAbajo (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse = true;
                posicion = e.Location;
            }
        }

        void FormularioMouseMovimiento(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point(
                    (this.Location.X - posicion.X) + e.X,
                    (this.Location.Y - posicion.Y) + e.Y);

                this.Update();
            }
        }

        void FormularioMouseArriba(object sender, MouseEventArgs e)
        {
            mouse = false;
        }



        private void btnArboles_Click(object sender, EventArgs e)
        {
            ArbolForm arbolForm = new ArbolForm();
            arbolForm.Show();

            this.Hide(); //Para ocultar la ventana actual
        }

        private void btnGrafos_Click(object sender, EventArgs e)
        {
            GrafoForm grafoForm = new GrafoForm();
            grafoForm.Show();

            this.Hide(); //Para ocultar la ventana actual
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
    }
}
