﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Presupuesto
    {

        public int idPresupuesto { get; set; }
        public string nombrePresupuesto { get; set; }
        public DateTime fechaReg { get; set; }
        public Usuario usuarioReg { get; set; }
        public DateTime UltModifFec { get; set; }
        public Usuario UltModifUser { get; set; }
        public DateTime fechaValIni { get; set; }
        public DateTime fechaValFin { get; set; }
        public Double monto { get; set; }
        public Aprobacion.estados estadoActual { get; set; }
        public string estadoActualString { get {
                string rpta = "";
                switch (estadoActual) {
                    case Aprobacion.estados.Aprobado:
                    case Aprobacion.estados.Activo:
                        rpta = "est-aprobado";
                        break;
                    case Aprobacion.estados.Edicion:
                        rpta = "est-edicion";
                        break;
                    case Aprobacion.estados.Inactivo:
                        rpta = "est-inactivo";
                        break;
                }
                return rpta;
            } }
        public List<Aprobacion> aprobaciones { get; set; }
        public List<PresupuestoTipo> TiposPresupuestos { get; set; }
        public List<PresupuestoArea> presupuestosArea { get; set; }

    }

    public class PresupuestoArea:Presupuesto
    {
        public Area area { get; set; }

    }
}
