using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebapaGitHub
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void DarConsejo()
        {
            Random r = new Random();
            int magia = r.Next(1, 1000);
            if (magia != 777)
            {
                int random = r.Next(1, 10);
                switch (random)
                {
                    case 1:
                        MessageBox.Show("Sin errores no hay éxito. Siga adelante.");
                        break;
                    case 2:
                        MessageBox.Show("No persiga al amor, él viene solo.");
                        break;
                    case 3:
                        MessageBox.Show("No deje para mañana lo que puede hacer hoy.");
                        break;
                    case 4:
                        MessageBox.Show("El que ríe último, es un lento hpta");
                        break;
                    case 5:
                        MessageBox.Show("La vida es como una arepa, sabe a lo que le eches.");
                        break;
                    case 6:
                        MessageBox.Show("El que madruga, Dios lo ayuda.");
                        break;
                    case 7:
                        MessageBox.Show("No deje para hoy lo que pueda hacer mañana.");
                        break;
                    case 8:
                        MessageBox.Show("El que mucho abarca, poco aprieta. Enfóquese en una sola cosa; así se forman los mejores.");
                        break;
                    case 9:
                        MessageBox.Show("No busque caerle bien a todo el mundo, es imposible. Sea usted mismo y las personas correctas lo valorarán.");
                        break;
                    case 10:
                        MessageBox.Show("La paciencia es una virtud. Aprenda a esperar y las cosas llegarán en su debido momento.");
                        break;
                    default:
                        MessageBox.Show("Vaya haga un chance. Éste mensaje TIENE 0% de probabilidad de salir.");
                        break;
                }
                return;
            }
            MessageBox.Show("Vaya hágase un chance. Éste mensaje tiene la probabilidad de 1 entre 1000 de salir.");
            return;

        }
    }
}
