﻿using ConsoleClase15.Constant;
using ConsoleClase15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClase15.Entidades
{
    internal class Gerente : EmpleadoBase, ISueldoBonificable , IDescuentoImpuesto
    {
        public override int SueldoBase => 8000;

        public decimal CalcularBonificacion()
        {
            return SueldoBase + Constantes.bonGerente;
        }

        public override decimal CalcularSueldo()
        {
           return CalcularBonificacion() - DescontarSueldo();
        }

        public decimal DescontarSueldo()
        {
            return CalcularBonificacion() * Constantes.desGerente;
        }
    }
}
