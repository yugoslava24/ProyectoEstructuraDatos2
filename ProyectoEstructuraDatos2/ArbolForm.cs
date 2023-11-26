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
    public partial class ArbolForm : Form
    {
        private bool mouse;
        private Point posicion;
        private Nodo raiz = null;

        public ArbolForm()
        {
            InitializeComponent();
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

        class Nodo
        {
            public string nombre;
            public string telefono;
            public Nodo izquierda;
            public Nodo derecha;

            public Nodo(string nombre, string telefono, Nodo izq, Nodo der)
            {
                this.nombre = nombre;
                this.telefono = telefono;
                izquierda = izq;
                derecha = der;
            }
        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra el programa
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;

            //maximiza la ventana
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
            menu.Show(); // para ir al menu principal
            this.Close(); //Para cerrar la ventana de arboles
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {

            // Verificar si los textbbox estan vacios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNum.Text))
            {
                MessageBox.Show("Por favor, ingrese tanto un nombre como un número.", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el formato del numero 
            if (!EsNumeroTelefonoValido(txtNum.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text;
            string telefono = txtNum.Text;
            CrearNodo(ref raiz, nombre, telefono);
            ActualizarDataGridView();
            LimpiarCampos();
        }

        private bool EsNumeroTelefonoValido(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
                return false;

            int contadorEspacios = 0;

            if (numero.StartsWith("+"))
                numero = numero.Substring(1); // Permite el uso de signo mas en los numeros por ejemplo (+505 83543638)

            foreach (char c in numero)
            {
                if (c == ' ')
                {
                    contadorEspacios++;
                    if (contadorEspacios > 1) // Si hay mass de un espacio, el numero es invalido
                        return false;
                }
                else if (!char.IsDigit(c))
                {
                    return false; // Si el caracter no es un digito el número es inválido
                }
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreAEliminar = txtNombre.Text; // Obtiene el nombre del textbox.

            if (!string.IsNullOrEmpty(nombreAEliminar))
            {
                EliminarNodo(ref raiz, nombreAEliminar);
                ActualizarDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Eliminar contacto");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            

            // Verifica si el TextBox esta vacio
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Detiene aca si el textbox esta vacio
            }

            string nombreBuscado = txtBuscar.Text;
            Nodo encontrado = BuscarPorNombre(raiz, nombreBuscado);

            if (encontrado != null)
            {
                MessageBox.Show($"Nombre: {encontrado.nombre}, Teléfono: {encontrado.telefono}", "Resultado de la búsqueda");
            }
            else
            {
                MessageBox.Show("El nombre no existe en la agenda.", "Resultado de la búsqueda");
            }

            // Limpiar el TextBox
            txtBuscar.Text = "";
        }





        private void dtgArboles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgArboles.Rows[e.RowIndex];

                // Verifica si las celdas no contienen valores nulos
                if (fila.Cells["Contacto"].Value != null && fila.Cells["Número"].Value != null)
                {
                    string nombre = fila.Cells["Contacto"].Value.ToString();
                    string telefono = fila.Cells["Número"].Value.ToString();

                    // Rellenar los textbox con la info que aparece en la fila seleccionada
                    txtNombre.Text = nombre;
                    txtNum.Text = telefono;
                }
                else
                {
                    // Mensaje de error si la fila que selecciona esta vacia
                    MessageBox.Show("No hay información en la fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ActualizarDataGridView()
        {
            dtgArboles.Rows.Clear();
            LlenarDataGridView(raiz);
        }

        private void LlenarDataGridView(Nodo t)
        {
            if (t != null)
            {
                // Agrega el nodo actual al datagrid
                dtgArboles.Rows.Add(t.nombre, t.telefono);

                // Llama recursivamente a la función para los subarboles izquierdo y derecho
                LlenarDataGridView(t.izquierda);
                LlenarDataGridView(t.derecha);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtNum.Clear();
            txtBuscar.Clear();

        }
        static void InsertarNodo(ref Nodo raiz, string nombre, string telefono)
        {
            if (raiz == null)
            {
                // Si la raiz es nula, crea una raiz
                CrearNodo(ref raiz, nombre, telefono);
            }
            else
            {
                // Si la raiz no es nula, llama a un metodo auxiliar para insertar el nodo en el lugar correcto
                InsertarNodoAux(ref raiz, nombre, telefono);
            }
        }

        static void InsertarNodoAux(ref Nodo nodo, string nombre, string telefono)
        {
            if (string.Compare(nombre, nodo.nombre) < 0)
            {
                // Si el nombre es menor que el nombre del nodo actual, va a la izquierda
                if (nodo.izquierda == null)
                {
                    // Si el subarbol izquierdo es nulo, crea un nuevo nodo
                    CrearNodo(ref nodo.izquierda, nombre, telefono);
                }
                else
                {
                    // Si el subarbol izquierdo no es nulo, llama recursivamente al metodo en el subarbol izquierdo
                    InsertarNodoAux(ref nodo.izquierda, nombre, telefono);
                }
            }
            else if (string.Compare(nombre, nodo.nombre) > 0)
            {
                // Si el nombre es mayor que el nombre del nodo actual, va a la derecha
                if (nodo.derecha == null)
                {
                   
                    CrearNodo(ref nodo.derecha, nombre, telefono);
                }
                else
                {
                    InsertarNodoAux(ref nodo.derecha, nombre, telefono);
                }
            }
            // Si el nombre ya existe, no guarda nada ya que no quiero nombres duplicados
        }

        static void CrearNodo(ref Nodo raiz, string nombre, string telefono)
        {
            if (raiz == null)
            {
                raiz = new Nodo(nombre, telefono, null, null);
            }
            else
            {
                InsertarNodo(ref raiz, nombre, telefono);
            }
        }

        static Nodo EncontrarSucesor(Nodo nodo)
        {
            while (nodo.izquierda != null)
            {
                nodo = nodo.izquierda;
            }
            return nodo;
        }
        private Nodo BuscarPorNombre(Nodo nodo, string nombre)
        {
            if (nodo == null)
            {
                return null; // El nombre no se encontro en el arbol
            }

            int comparacion = string.Compare(nombre, nodo.nombre);

            if (comparacion == 0)
            {
                return nodo; // Retorna cuando encuentra el nombre
            }
            else if (comparacion < 0)
            {
                return BuscarPorNombre(nodo.izquierda, nombre); // Buscar en el subarbol izquierdo
            }
            else
            {
                return BuscarPorNombre(nodo.derecha, nombre); // Buscar en el subarbol derecho
            }
        }

        static void EliminarNodo(ref Nodo raiz, string nombre)
        {
            Nodo padre = null;
            Nodo actual = raiz;

            while (actual != null && actual.nombre != nombre)
            {
                padre = actual;
                if (string.Compare(nombre, actual.nombre) < 0)
                    actual = actual.izquierda;
                else
                    actual = actual.derecha;
            }

            if (actual == null)
            {
                MessageBox.Show("El contacto no existe en la agenda.", "Eliminar contacto");
                return;
            }

            if (actual.izquierda == null && actual.derecha == null)
            {
                if (padre == null)
                    raiz = null;
                else if (padre.izquierda == actual)
                    padre.izquierda = null;
                else
                    padre.derecha = null;
            }
            else if (actual.izquierda != null && actual.derecha != null)
            {
                Nodo sucesor = EncontrarSucesor(actual.derecha);
                actual.nombre = sucesor.nombre;
                actual.telefono = sucesor.telefono;
                EliminarNodo(ref actual.derecha, sucesor.nombre);
            }
            else
            {
                Nodo hijo = (actual.izquierda != null) ? actual.izquierda : actual.derecha;
                if (padre == null)
                    raiz = hijo;
                else if (padre.izquierda == actual)
                    padre.izquierda = hijo;
                else
                    padre.derecha = hijo;
            }
        }

     




        private void btnPdf_Click(object sender, EventArgs e)
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
            var plantilla = Properties.Resources.plantilla.ToString();
            var sb = new StringBuilder();

            foreach (DataGridViewRow row in dtgArboles.Rows)
            {
                if (!row.IsNewRow)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>",
                                    row.Cells["Contacto"].Value?.ToString() ?? "",
                                    row.Cells["Número"].Value?.ToString() ?? "");
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
                iTextSharp.text.Image imgDerecha = iTextSharp.text.Image.GetInstance(Properties.Resources.logoFacultad, System.Drawing.Imaging.ImageFormat.Png);// Para poner los logos en el pdf
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




        private string RecorridoInorder(Nodo nodo)
        {
            if (nodo == null)
            {
                return "";
            }

            // Recorrido: izquierda, nodo actual, derecha
            return RecorridoInorder(nodo.izquierda) +
                   $"Nombre: {nodo.nombre}, Teléfono: {nodo.telefono}\n" +
                   RecorridoInorder(nodo.derecha);
        }

        private void btnImprimirArbol_Click(object sender, EventArgs e)
        {
            lblArbol.Text = RecorridoInorder(raiz); 
        }

       
    }
}
