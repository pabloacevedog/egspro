using FormNewUIdesign.Formularios;
using System;
using System.Windows.Forms;

namespace FormNewUIdesign
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            //Application.Run(new Formulario());
        }
    }
}
