﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoFuncionario_class_
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
             return SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem);
        }

        public override string ToString()
        {
            return $"{Nome}, ${(SalarioLiquido().ToString("F2"))}";
        }
    }
}
