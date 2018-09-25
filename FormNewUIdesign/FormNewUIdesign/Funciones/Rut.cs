﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormNewUIdesign.Funciones
{
    public class Rut
    {
        public static string FormatearRut(string rut)
        {
            rut = rut.ToUpper();
            char[] arrayRut = rut.ToCharArray();
            string nuevoRut = "";
            for (int x = arrayRut.Length - 1; x >= 0; x--)
            {
                if (x == arrayRut.Length - 1)
                {
                    nuevoRut = "-" + arrayRut[x].ToString().ToUpper() + nuevoRut;
                }
                else
                {
                    if (x == arrayRut.Length - 4 || x == arrayRut.Length - 7)
                    {
                        nuevoRut = "." + arrayRut[x] + nuevoRut;
                    }
                    else
                    {
                        nuevoRut = arrayRut[x] + nuevoRut;
                    }
                }
            }
            return nuevoRut;
        }


        public static bool ValidarRut(int numero, string digitoV)
        {
            int Numero = numero;
            string DigitoVerificador = digitoV.ToUpper();

            string cadenaNumero = numero.ToString();
            int calculador = 0;

            int[] factores = { 3, 2, 7, 6, 5, 4, 3, 2 };
            int indiceFactor = factores.Length - 1;

            for (int i = cadenaNumero.Length - 1; i >= 0; i--)
            {
                calculador = calculador + (factores[indiceFactor] * int.Parse(cadenaNumero.Substring(i, 1)));
                indiceFactor--;
            }

            string digitoVerificador;
            int resultado = 11 - (calculador % 11);

            if (resultado == 11)
            {
                digitoVerificador = "0";
            }
            else if (resultado == 10)
            {
                digitoVerificador = "K";
            }
            else
            {
                digitoVerificador = resultado.ToString();
            }

            return DigitoVerificador == digitoVerificador;
        }
    }
}
