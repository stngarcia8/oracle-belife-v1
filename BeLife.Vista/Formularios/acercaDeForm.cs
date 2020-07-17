using System;
using System.Text;
using System.Windows.Forms;

namespace BeLife.Vista.Formularios
{
    public partial class acercaDeForm : Form
    {
        public acercaDeForm()
        {
            InitializeComponent();
        }


        private void acercaDeForm_Load(object sender, EventArgs e)
        {
            this.aplicacionRichTextBox.Text = this.generarTexto();
            this.aplicacionRichTextBox.Focus();
        }


        // Manejo del boton aceptar.
        private void aplicacionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Generar texto del textbox.
        private string generarTexto()
        {
            StringBuilder myTexto = new StringBuilder();
            myTexto.Append("Aplicación: BeLife.\n");
            myTexto.Append("Versión: v0.0.1\n\n");
            myTexto.Append("Programado para: \n");
            myTexto.Append("Ramo: Desarrollo de software escritorio y gestión.\n");
            myTexto.Append("Profesora: Andrea Silva Loncón.\n\n");
            myTexto.Append("Equipo de trabajo:\n");
            myTexto.Append("- Hector Celis Villarroel.\n");
            myTexto.Append("- Elias García Carvajal.\n");
            myTexto.Append("- Daniel García Loyola.\n\n");
            return myTexto.ToString();
        }


    }
}
