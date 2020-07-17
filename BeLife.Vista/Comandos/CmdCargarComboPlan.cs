using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BeLife.Controlador.DAO;
using BeLife.Modelo.Dto;

namespace BeLife.Vista.Comandos
{
    public class CmdCargarComboPlan : CmdCargarComboBox, IComando
    {

        // Propiedades.
        public IList<DtoPlan> PlanList { get; set; }

        // Constructor.
        private CmdCargarComboPlan(ComboBox myComboBox)
            : base(myComboBox)
        {
            this.PlanList = new List<DtoPlan>();
        }


        // Metodo creador del objeto.
        public static CmdCargarComboPlan Crear(ComboBox myComboBox)
        {
            return new CmdCargarComboPlan(myComboBox);
        }


        // Metodo que ejecuta el comando.
        public void Ejecutar()
        {
            this.myComboBox.BeginUpdate();
            this.ObtenerDatos();
            this.PrepararControl("Nombre", "IDPlan");
        }


        // Metodo que carga la lista de planes.
        protected override void ObtenerDatos()
        {
            try
            {
                IDaoPlan myDao = DaoPlan.Crear();
                this.PlanList = myDao.ObtenerListaDePlanes();
                this.myComboBox.DataSource = this.PlanList;
                this.InsertarValorInicial();
            }
            catch (Exception ex)
            {
                this.MostrarMensajeDeError(ex);
            }
        }


        private void InsertarValorInicial()
        {
            DtoPlan myDto = new DtoPlan();
            myDto.IdPlan = "0";
            myDto.Nombre = "Seleccione un plan.";
            myDto.PolizaActual = string.Empty;
            myDto.PrimaBase = 0;
            this.PlanList.Insert(0, myDto);
        }

    }
}
