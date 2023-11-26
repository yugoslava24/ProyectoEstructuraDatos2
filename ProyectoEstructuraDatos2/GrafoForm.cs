using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace ProyectoEstructuraDatos2
{
    public partial class GrafoForm : Form
    {

        private bool mouse;
        private Point posicion;
        private GrafoAutobuses grafoAutobuses = new GrafoAutobuses();
        public GrafoForm()
        {
            InitializeComponent();

            //Para que no se pueda escribir en los combobox
            comboBoxParada1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxParada2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEliminarParada.DropDownStyle = ComboBoxStyle.DropDownList;

            this.MouseDown += new MouseEventHandler(FormularioMouseAbajo);
            this.MouseMove += new MouseEventHandler(FormularioMouseMovimiento);
            this.MouseUp += new MouseEventHandler(FormularioMouseArriba);

        }

        void FormularioMouseAbajo(object sender, MouseEventArgs e)
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


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la app
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            //Maximiza la ventana
        }

        private void btnMinimi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
            //Minimiza la ventana
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();

            this.Close(); //Para cerrar la ventana de grafos
        }


        // Verifica si una parada ya existe
        private bool ParadaYaExiste(string nombreParada)
        {
            // Verifica si la parada ya existe
          
            return comboBoxParada1.Items.Contains(nombreParada) ||
                   comboBoxParada2.Items.Contains(nombreParada) ||
                   comboBoxEliminarParada.Items.Contains(nombreParada);
        }
        private void btnAgregarParada_Click(object sender, EventArgs e)
        {
            // Verifica si el textbox esta vacio
            if (string.IsNullOrWhiteSpace(txtNombreParada.Text))
            {
                MessageBox.Show("Por favor, ingrese una parada.", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Sirve para detener la ejecucion
            }

            string parada = txtNombreParada.Text;

            // Verifica si la parada existe
            if (ParadaYaExiste(parada))
            {
                MessageBox.Show("La parada ya existe.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            grafoAutobuses.AgregarParada(parada);
            comboBoxParada1.Items.Add(parada);
            comboBoxParada2.Items.Add(parada);
            comboBoxEliminarParada.Items.Add(parada);

            LlenarDataGridView();

            // Limpia el textbox
            txtNombreParada.Text = "";
        }



        private void btnAgregarConexion_Click(object sender, EventArgs e)
        {
            // Verifica si ambos combobox tienen una seleccion
            if (comboBoxParada1.SelectedItem == null || comboBoxParada2.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione paradas en ambos campos.", "Selección faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string parada1 = comboBoxParada1.SelectedItem.ToString();
            string parada2 = comboBoxParada2.SelectedItem.ToString();
            grafoAutobuses.AgregarConexion(parada1, parada2);

            LlenarDataGridView(); // Llama al metodo para actualizar el datagridview

            // Limpia lo que se selecciona en el combobox
            comboBoxParada1.SelectedItem = null;
            comboBoxParada2.SelectedItem = null;
        }

        private void btnBuscarParada_Click(object sender, EventArgs e)
        {


            string paradaBuscada = txtBuscarParada.Text.Trim();

            if (!string.IsNullOrEmpty(paradaBuscada))
            {
                bool paradaEncontrada = MostrarParadaEspecifica(paradaBuscada);
                if (!paradaEncontrada)
                {
                    MessageBox.Show($"La parada '{paradaBuscada}' no existe.", "Parada no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre de una parada para buscar.", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Limpia el textbox
            txtBuscarParada.Text = "";



        }

        private void btnEliminarParada_Click(object sender, EventArgs e)
        {
           

            if (comboBoxEliminarParada.SelectedItem != null)
            {
                string paradaAEliminar = comboBoxEliminarParada.SelectedItem.ToString();

                // Verificar si la parada tiene conexiones
                if (grafoAutobuses.TieneConexiones(paradaAEliminar))
                {
                    MessageBox.Show("No se puede eliminar la parada porque tiene conexiones.", "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Elimina la parada
                grafoAutobuses.EliminarParada(paradaAEliminar);

                // Actualiza los combobox
                comboBoxEliminarParada.Items.Remove(paradaAEliminar);
                comboBoxParada1.Items.Remove(paradaAEliminar);
                comboBoxParada2.Items.Remove(paradaAEliminar);

                // Actualizar el datagridview
                ActualizarDataGridView();

                MessageBox.Show($"Parada '{paradaAEliminar}' eliminada.", "Parada Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una parada para eliminar.", "Selección faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void ActualizarDataGridView()
        {
            List<ParadaConexiones> listaParadas = new List<ParadaConexiones>();

            foreach (var parada in grafoAutobuses.Grafo)
            {
                listaParadas.Add(new ParadaConexiones
                {
                    Origen = parada.Key,
                    Destino = string.Join(", ", parada.Value)
                });
            }

            dtgParadas.DataSource = null;
            dtgParadas.DataSource = listaParadas;
        }
        private void btnImprimirGrafo_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf", // Establece un filtro para mostrar solo pdf
                Title = "Guardar PDF como", // Titulo del cuadro
                DefaultExt = "pdf", // Extension por defecto
                AddExtension = true // Agrega automaticamente la extension si no se escribe
            };

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string paginahtml_texto = GenerarHTML();
                    GuardarPDF(guardar.FileName, paginahtml_texto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el PDF: {ex.Message}");
                }
            }
        }

        private string GenerarHTML()
        {
            var plantilla = Properties.Resources.plantillaGrafo.ToString();
            var sb = new StringBuilder();

            foreach (DataGridViewRow row in dtgParadas.Rows)
            {
                if (!row.IsNewRow)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>",
                                    row.Cells["Origen"].Value?.ToString() ?? "",
                                    row.Cells["Destino"].Value?.ToString() ?? "");
                }
            }

            return plantilla.Replace("@FILAS", sb.ToString());
        }


        private void GuardarPDF(string nombreArchivo, string contenidoHtml)
        {
            using (var stream = new FileStream(nombreArchivo, FileMode.Create))
            using (var pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25))
            using (var writer = PdfWriter.GetInstance(pdfDoc, stream))
            {
                pdfDoc.Open();

                // Primera imagen (Derecha)
                iTextSharp.text.Image imgDerecha = iTextSharp.text.Image.GetInstance(Properties.Resources.logoFacultad, System.Drawing.Imaging.ImageFormat.Png); // Para poner los logos en el pdf
                imgDerecha.ScaleToFit(60, 60);
                imgDerecha.Alignment = iTextSharp.text.Image.UNDERLYING;
                float posXDerecha = pdfDoc.Right - imgDerecha.ScaledWidth - pdfDoc.RightMargin;
                float posYDerecha = pdfDoc.Top - (imgDerecha.ScaledHeight / 2) - (pdfDoc.TopMargin / 2);
                imgDerecha.SetAbsolutePosition(posXDerecha, posYDerecha);
                pdfDoc.Add(imgDerecha);

                // Segunda imagen (Izquierda)
                iTextSharp.text.Image imgIzquierda = iTextSharp.text.Image.GetInstance(Properties.Resources.unanLogo, System.Drawing.Imaging.ImageFormat.Png); 
                imgIzquierda.ScaleToFit(60, 60);
                imgIzquierda.Alignment = iTextSharp.text.Image.UNDERLYING;
                float posXIzquierda = pdfDoc.Left + pdfDoc.LeftMargin;
                float posYIzquierda = pdfDoc.Top - (imgIzquierda.ScaledHeight / 2) - (pdfDoc.TopMargin / 2);
                imgIzquierda.SetAbsolutePosition(posXIzquierda, posYIzquierda);
                pdfDoc.Add(imgIzquierda);


                // Procesar el contenido HTML
                using (var sr = new StringReader(contenidoHtml))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
            }
        }

        class ParadaConexiones
        {
            public string Origen { get; set; }
            public string Destino { get; set; }
        }

        
        private void LlenarDataGridView()
        {
            var listaParadas = new List<ParadaConexiones>();

            foreach (var parada in grafoAutobuses.Grafo)
            {
                listaParadas.Add(new ParadaConexiones
                {
                    Origen = parada.Key,
                    Destino = string.Join(", ", parada.Value)
                });
            }

            dtgParadas.DataSource = listaParadas;
        }

      

        private bool MostrarParadaEspecifica(string paradaBuscada)
        {
            if (grafoAutobuses.Grafo.ContainsKey(paradaBuscada))
            {
                var listaFiltrada = new List<ParadaConexiones>();

               
                listaFiltrada.Add(new ParadaConexiones
                {
                    Origen = paradaBuscada,
                    Destino = string.Join(", ", grafoAutobuses.Grafo[paradaBuscada])
                });

                //Muestra los resultados
                dtgParadas.DataSource = listaFiltrada;

                return true; // Parada encontrada
            }

            return false; // Parada no encontrada
        }

        
        class GrafoAutobuses
        {
            public Dictionary<string, List<string>> Grafo { get; private set; }

            public GrafoAutobuses()
            {
                Grafo = new Dictionary<string, List<string>>();
            }

            public void AgregarParada(string parada)
            {
                if (!Grafo.ContainsKey(parada))
                {
                    Grafo[parada] = new List<string>();
                }
            }

            public void AgregarConexion(string parada1, string parada2)
            {
                AgregarParada(parada1);
                AgregarParada(parada2);

                if (!Grafo[parada1].Contains(parada2))
                {
                    Grafo[parada1].Add(parada2);
                }
            }

            public bool TieneConexiones(string parada)
            {
                if (Grafo.ContainsKey(parada) && Grafo[parada].Count > 0)
                {
                    return true;
                }
                return false;
            }
            public void EliminarParada(string parada)
            {
                if (Grafo.ContainsKey(parada))
                {
                    // Primero elimina la parada de las listas de destinos de otras paradas
                    foreach (var entrada in Grafo)
                    {
                        entrada.Value.Remove(parada);
                    }

                    // Despues elimina la parada y todas sus conexiones salientes
                    Grafo.Remove(parada);
                }
            }

            public void EliminarConexion(string origen, string destino)
            {
                if (Grafo.ContainsKey(origen) && Grafo[origen].Contains(destino))
                {
                    Grafo[origen].Remove(destino);
                }
            }


        }

        private void btnEliminarConexion_Click(object sender, EventArgs e)
        {
            if (comboBoxParada1.SelectedItem == null || comboBoxParada2.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione paradas en ambos campos.", "Selección faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string origen = comboBoxParada1.SelectedItem.ToString();
            string destino = comboBoxParada2.SelectedItem.ToString();
            grafoAutobuses.EliminarConexion(origen, destino);
            LlenarDataGridView();
        }
        private string ImprimirGrafo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var parada in grafoAutobuses.Grafo)
            {
                sb.Append($"Parada de origen: {parada.Key}, parada de destino: {string.Join(", ", parada.Value)}\n");
            }
            return sb.ToString();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lblGrafo.Text = ImprimirGrafo();
        }
    }
  
}