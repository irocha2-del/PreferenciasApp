namespace PreferenciasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //==============================
            //1.- VALIDAR NOMBRE
            //==============================
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "Por Favor, Escribe tu Nombre.",
                    "Validacion===================",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            //=========================================
            //2.- OBTENER LAS ACTIVIDADES SELECCIONADAS
            //=========================================

            List<string> actividades = new List<string>();

            if (chkDeportes.Checked)
            {
                actividades.Add("deportes");
            }
            if (chkMusica.Checked)
            {
                actividades.Add("musica");
            }
            if (chkArte.Checked)
            {
                actividades.Add("Artes");
            }
            if (chkProgramacion.Checked)
            {
                actividades.Add("Programacion");
            }
            if (chkLectura.Checked)
            {
                actividades.Add("LEctura");
            }

            //================================
            //3.-COMPROBAR AL MENOS UNA ACTIVIDAD
            //===================================
            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Porfavor, Selecciona por lo menos una actividad.",
                    "Validacion============================",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            //===========================
            //4.-OBTENER LA MODALIDAD SELECCIONADA
            //===========================
            string modalidad = "";
            if (rbPresencial.Checked)
            {
                modalidad = "Presencial";
            }
            else if (rbEnLinea.Checked)
            {
                modalidad = "En Linea";
            }
            else if (rbHibrida.Checked)
            {
                modalidad = "Hibrida";
            }
            else
            {
                MessageBox.Show(
                    "Porfavor, Selecciona una modalidad.",
                    "Validacion===========================",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //===========================
            //5.-CREAR EL RESUMEN DE PREFERENCIAS
            //===========================
            string resumen =
                "RESUMEN DE PREFERENCIAS\r\n" +
                "============================\r\n" +
                "Nombre: " + txtNombre.Text + "\r\n" +
                "Actividades: " + string.Join(", ", actividades) + "\r\n" +
                "Modalidad: " + modalidad;
            txtResumen.Text = resumen;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el nombre
            txtNombre.Clear();
            // Limpiar las actividades
            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            chkArte.Checked = false;
            chkProgramacion.Checked = false;
            chkLectura.Checked = false;
            // Limpiar los RadioButtons de modalidad
            rbPresencial.Checked = false;
            rbEnLinea.Checked = false;
            rbHibrida.Checked = false;
            // Limpiar el resumen
            txtResumen.Clear();
            //regresamos el cursor al nombre
            txtNombre.Focus();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            // Limpiar el nombre
            txtNombre.Clear();
            // Limpiar las actividades
            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            chkArte.Checked = false;
            chkProgramacion.Checked = false;
            chkLectura.Checked = false;
            // Limpiar los RadioButtons de modalidad
            rbPresencial.Checked = false;
            rbEnLinea.Checked = false;
            rbHibrida.Checked = false;
            // Limpiar el resumen
            txtResumen.Clear();
            //regresamos el cursor al nombre
            txtNombre.Focus();
        }
    }
}
