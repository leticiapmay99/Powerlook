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
            Form_login FormLogin = new Form_login();
            FormLogin.ShowDialog();
            if(FormLogin.logado == true)
            {
                Application.Run(new Form_principal());
              
            }
        }
    }
}
