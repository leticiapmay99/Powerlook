using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PowerLook_Aluguel
{
    static class Program
    {
        public static bool permissaoUsuario = false;
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
                if(FormLogin.teste == 1)
                {
                    permissaoUsuario = true;
                }
                Application.Run(new Form_principal());
                
            }

            //Application.Run(new Form_principal());
        }
    }
}
