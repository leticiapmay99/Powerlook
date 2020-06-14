using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PowerLook_Aluguel
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login FormLogin = new Login();
            FormLogin.ShowDialog();
            if(FormLogin.logado == true)
            {
                Application.Run(new Form_principal());
              
            }
        }
    }
}
