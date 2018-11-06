using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace FormNewUIdesign.Funciones
{
    public class Mixin
    {

        public class VG
        {
            public static bool activeTabListUsers = true;
            public static bool activeTabAddUser = false;
            public static bool activeTabEditUser = false;
            public static string etapaCrearGrupo = "Crear Grupo Postulantes";
            public static string etapaRegPostulantes = "Registrar Postulantes";
            public static string etapaAgregarDocs = "Agregar Documentación";
            public static string etapaGenerarFormatos = "Generar Formatos";
        }

        
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

        public static bool ValidarCorreo(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
