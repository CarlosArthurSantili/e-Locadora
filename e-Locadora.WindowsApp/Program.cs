using e_Locadora.WindowsApp.Features.VeiculoModule;
using e_Locadora.WindowsApp.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TelaVeiculoForm());
            //Application.Run(new TelaPrincipalForm());

            //Application.Run(new TelaLogin());
            
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.ShowDialog();
        }
    }
}
