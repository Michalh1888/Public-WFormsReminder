using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Upominac
{
    public class AppOptions
    {
        public static bool StartTray { get; private set; }
        public static bool SaveSysAppData { get; private set; }
        //cesta XML souboru pro ukládání dat osob
        private const string vychSouborOsoby = "osoby.xml";//výchozí cesta(ve složce aplikace)
        public static string SouborOsoby { get; private set; } = vychSouborOsoby;//výchozí cesta(ve složce aplikace)
        public List<AppParameters> Parametry { get; private set; }
        private string cesta = "parametry.csv";
        

        public AppOptions()
        {
            Parametry = new List<AppParameters>();
            NactiParam();
            NastavParam();
        }
        
        public void NastavParam()
        {         
            var najdiParam = ProiterujParam("StartTray");
            if (najdiParam != null) StartTray = najdiParam.StavParam;
            var najdiParam2 = ProiterujParam("SaveSysAppData");
            if (najdiParam2 != null) SaveSysAppData = najdiParam2.StavParam;
            NastavCestuSouboruOsob();


        }

        public void PridejParam(string nazevParam, bool stavParam)
        {
            if (Parametry.Count > 0)
            {
                var param = ProiterujParam(nazevParam);
                if (param != null)
                    Parametry.Remove(param);
            }
            Parametry.Add(new AppParameters(nazevParam, stavParam));
        }

        public void UlozParam()
        {
            try
            {
                //uložení parametru do CSV
                using (StreamWriter sw = new StreamWriter(cesta))
                {
                    foreach (AppParameters item in Parametry)
                    {
                        string[] par = { item.NazevParam, item.StavParam.ToString() };
                        string zapis = string.Join(";", par);
                        sw.WriteLine(zapis);
                    }
                    sw.Flush();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Chyba zápisu parametrů do souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NactiParam()
        {
            try
            {
                using (StreamReader sr = new StreamReader(cesta))
                {   
                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine() ?? "";
                        string[] par = s.Split(';');
                        string nazevPar = par[0];
                        bool stavPar = bool.Parse(par[1]);
                        Parametry.Add(new AppParameters(nazevPar, stavPar));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba čtení parametrů ze souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public AppParameters? ProiterujParam(string nazevParam)
        {
            foreach (AppParameters appParam in Parametry)
            {
                if (appParam.NazevParam == nazevParam)
                    return appParam;
            }
            return null;
        }
        //metoda nastaví cestu ukládání osob do syst.adresáře "AppData" nebo do složky aplikace
        public void NastavCestuSouboruOsob()
        {
            if (SaveSysAppData)
            {
                try
                {
                    string cesta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Upominac");
                    if (!Directory.Exists(cesta)) 
                        Directory.CreateDirectory(cesta);
                    SouborOsoby = cesta + "\\" + "osoby.xml";
                }
                catch
                {
                    MessageBox.Show("Nepodařilo se vytvořit složku {0}, zkontrolujte prosím svá oprávnění.", cesta);
                }
            }
            else
                SouborOsoby = vychSouborOsoby;

        }

    }
}
