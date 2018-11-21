using System;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using PartidaDDD.Presentation.Forms;

namespace PartidaDDD.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = ConfigureServices.Configure(new ServiceCollection());
            var prov = services.BuildServiceProvider();
            var form = prov.GetRequiredService<FormLogin>();
            Application.Run(form);
        }
    }
}
