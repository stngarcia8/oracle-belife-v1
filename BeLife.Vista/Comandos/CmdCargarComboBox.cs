using System;
using System.Windows.Forms;

namespace BeLife.Vista.Comandos
{
    public abstract class CmdCargarComboBox
    {

        // Miembros.
        protected readonly ComboBox myComboBox;


        // Constructor.
        protected CmdCargarComboBox(ComboBox myComboBox)
        {
            this.myComboBox = myComboBox;
        }


        // metodo que prepara el control con los datos.
        protected void PrepararControl(string displayMember, string valueMember)
        {
            this.myComboBox.DisplayMember = displayMember;
            this.myComboBox.ValueMember = valueMember;
            this.myComboBox.EndUpdate();
        }


        // Metodo abstracto para obtener datos del combobox.
        protected abstract void ObtenerDatos();


        // Metodo que muestra el error ocurrido en tiempo de carga de los datos.
        protected void MostrarMensajeDeError(Exception ex)
        {
            MessageBox.Show(ex.Source.ToString() + " - " + ex.Message.ToString(), "Ha ocurrido un problema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




    }
}
