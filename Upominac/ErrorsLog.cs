using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upominac
{
    internal class ErrorsLog
    {
        public static List<string> UserErrorsList { get; private set; } = new();



        public static void ZapisChybu(string comment,string soubor,HashSet<string> dataChyb, bool forUser)
        {
            string s = "";
            string a = "";
            foreach (string item in dataChyb)
            {
                a +=$"{item}\n";
            }
            s = $"{soubor}:\n{comment}\n{a}\n";
            if (forUser)
                UserErrorsList.Add(s);
        }

        public static string ProjdiChyby(bool userList)
        {
            string s = "";
            if (UserErrorsList.Count > 0)
            {
                foreach (string error in UserErrorsList)
                    s += error;
            }

            return s;
        }

    }
}
