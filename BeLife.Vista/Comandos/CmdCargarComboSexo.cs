using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BeLife.Controlador.DAO;
using BeLife.Modelo.Dto;

namespace BeLife.Vista.Comandos
{
    public class CmdCargarComboSexo : CmdCargarComboBox, IComando
    {

        // Propiedades.
        public IList<DtoSexo> SexoList { get; set; }

        // Constructor.
        private CmdCargarComboSexo(ComboBox myComboBox)
            : base(myComboBox)
        { }


        // Metodo creador del objeto.
        public static CmdCargarComboSexo crear(ComboBox myComboBox)
        {
            return new CmdCargarComboSexo(myComboBox);
        }


        // Metodo que ejecuta el comando.
        public void Ejecutar()
        {
            this.myComboBox.BeginUpdate();
            this.ObtenerDatos();
            this.PrepararControl("DESCRIPCION", "IDSEXO");
        }


        // metodo que carga la lista de sexos.
        protected override void ObtenerDatos()
        {
            try
            {
                IDaoSexo myDao = DaoSexo.crear();
                this.SexoList = myDao.ObtenerListaSexo();
                this.InsertarValorInicial();
                this.myComboBox.DataSource = this.SexoList;
            }
            catch (Exception ex)
            {
                this.MostrarMensajeDeError(ex);
            }
        }


        private void InsertarValorInicial()
        {
            DtoSexo myDto = new DtoSexo();
            myDto.IdSexo = 0;
            myDto.Descripcion = "Seleccione estado civil";
            this.SexoList.Insert(0, myDto);
        }


    }
}
