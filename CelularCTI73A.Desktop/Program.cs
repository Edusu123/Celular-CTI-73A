using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelularCTI73A.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CelularCTI73A.Model.Suporte.ConexaoBanco.conectar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
            //CelularCTI73A.Model.Suporte.ConexaoBanco.desconectar();
        }
    }
}
