﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_la_nomina
{
    public class Nomina
    {
        private int diasLaborados;
        public int DiasLaborados { get; set; }

        //metodo para calcular la nomina
        public decimal CalcularNomina (int diasLab, decimal valorDia)
        {
            decimal totalSalario = diasLab * valorDia;
            return totalSalario;
        }
    }
}
