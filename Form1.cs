using System;
using System.Windows.Forms;

namespace RegistroContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            // Aquí va el código para agregar el contacto
            string nombre = TextBoxNombre.Text;
            string telefono = TextBoxTelefono.Text;
            string email = TextBoxEmail.Text;

            if (!string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(telefono) &&
                !string.IsNullOrWhiteSpace(email))
            {
                ListBoxContactos.Items.Add($"Nombre: {nombre}, Teléfono: {telefono}, Email: {email}");
                LabelEstado.Text = "Contacto agregado";
            }
            else
            {
                LabelEstado.Text = "Por favor, complete todos los campos";
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            // Aquí va el código para limpiar los campos
            TextBoxNombre.Clear();
            TextBoxTelefono.Clear();
            TextBoxEmail.Clear();
            LabelEstado.Text = "Campos limpiados";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
