using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;

namespace Upominac
{
    //třída pro spouštění aplikace po startu
    public class RegistryManager
    {
        
        private static RegistryKey? rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true); 


        //Nastaví/odstraní klíč spouštění po startu v registrech
        public static void SetOnStartup(bool run)
        {
            if (run == true)
                rkApp?.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
            else 
                rkApp?.DeleteValue(Application.ProductName, false);
        }

        // Zjistí, zda je program nastaven po spuštění. Pokud ano a změnila se cesta, tak ji aktualizuje.
        public static bool IsOnStartup()
        {
            var valueKey = rkApp?.GetValue(Application.ProductName);
            if (valueKey is null) return false;
            else if (!System.IO.File.Exists(valueKey.ToString()))
                rkApp?.SetValue(Application.ProductName, Application.ExecutablePath.ToString());

            return true;
        }


    }
}
