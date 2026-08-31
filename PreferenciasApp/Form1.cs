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
                    "Validacion===========",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }



        }
    }
}
