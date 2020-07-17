using System.Windows.Forms;

namespace BeLife.Vista.Comandos
{
    public class CmdAbrirFormulario : IComando
    {

        // Miembros privados.
        private readonly Form myForm;


        // Constructor.
        private CmdAbrirFormulario(Form myForm)
        {
            if (myForm == null)
            {
                this.myForm = null;
                return;
            }
            this.myForm = myForm;
        }


        // Metodo constructor del objeto.
        public static CmdAbrirFormulario Crear(Form myForm)
        {
            return new CmdAbrirFormulario(myForm);
        }


        // Metodo que ejecuta el comando.
        public void Ejecutar()
        {
            if (this.myForm != null) this.myForm.ShowDialog();
        }



    }
}
