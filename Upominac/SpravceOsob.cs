using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Upominac
{
    public class SpravceOsob
    {
        public Osoba? PoslPridOsoba { get; private set; }
        public BindingList<Osoba> Osoby { get; private set; }
        private string[,] jmena = new string[12, 31];
        private string cesta2 = "svatky.txt";
        XmlTransfer xmlTransfer = new XmlTransfer();
        private HashSet<string> errorsOsoba = new HashSet<string>();

        public SpravceOsob()
        {
            Osoby = new BindingList<Osoba>();
        }

        //metoda přidá/edituje osobu
        public void Pridej(string jmeno, DateTime datumNarozeni, string udaje)
        {
            if (jmeno.Length < 3)
                throw new ArgumentException("Jméno je příliš krátké");
            if (datumNarozeni.Date > DateTime.Today)
                throw new ArgumentException("Datum narození nesmí být v budoucnosti");
            Osoba osoba = new Osoba(jmeno, datumNarozeni.Date, udaje);
            Osoby.Add(osoba);
            PoslPridOsoba = osoba;
        }

        //metoda odebere osobu
        public void Odeber(Osoba osoba)
        {
            Osoby.Remove(osoba);
        }

        //metoda najde nejbližší osobu,která má narozeniny
        public Osoba NajdiNejblizsi()
        {   
            var serazeneOsoby = Osoby.OrderBy(o => o.ZbyvaDni(true)).ThenBy(o => o.Jmeno);
            return serazeneOsoby.First();
        }

        //metoda pro zjištění narozenin dnes(ze všech lidí v seznamu)
        public Osoba? NarozeninyDnes()
        {
            var narozeneOsoby = Osoby.Where(o => o.ZbyvaDni(false) == 0).OrderBy(o => o.Jmeno);
            if (narozeneOsoby.Count() != 0) return narozeneOsoby.First();
            return null;
        }

        //metoda pro zjištění narozenin jedné konkrétní osoby
        public bool NarozeninyDnes(Osoba osoba)
        {
            if (osoba.ZbyvaDni(false) == 0) return true;
            return false;
        }

        
        //uloží osobu do XML souboru
        public void Uloz()
        {
            try
            {
                xmlTransfer.ZapisDoXml(Osoby, "Osoby", "Osoba", false, AppOptions.SouborOsoby);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Chyba uložení osob do souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //načtení dat ze XML souboru
        public void Nacti()
        {
            List<XElement> nactenyList = new List<XElement>();
            try
            {
                nactenyList = xmlTransfer.CteniXml("Osoby", "Osoba", AppOptions.SouborOsoby);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Chyba čtení osob ze souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Parsování načtených dat v safe módu-příp.výpis vlastností s chybným formátem do logu
            string[] polePar = { "Jmeno", "Narozeniny", "DalsiUdaje" };//názvy vlastností(tř.Osoba) k validaci
            string[] poleZapis = new string[polePar.Length];
            foreach (var item in nactenyList)
            {
                for (int i = 0; i < polePar.Length; i++)
                {
                    var u = item.XPathSelectElement(polePar[i]);
                    if (u != null)
                        poleZapis[i] = u.Value.ToString();
                }

                DateTime narozeniny = DateTime.Today;
                if (!DateTime.TryParse(poleZapis[1], out narozeniny))
                    errorsOsoba.Add(polePar[1]);
                Osoby.Add(new Osoba(poleZapis[0], narozeniny, poleZapis[2]));
            }
            if (errorsOsoba.Count > 0)
            {
                string s = "Následující data načtená ze souboru jsou chybná (mají chybný formát):";
                ErrorsLog.ZapisChybu(s, AppOptions.SouborOsoby, errorsOsoba, true);
            }
        }


        //načtení jmen kalendáře z exter.souboru(txt)
        public void NactiJmena()
        {
            try
            {
                using (StreamReader sr = new StreamReader(cesta2))
                {
                    for (int i = 0; i < 12; i++)//měsíce
                    {
                        int j = 0;//dny
                        string? s;
                        while ((s = sr.ReadLine()) != null)
                        {   
                            if ((string.IsNullOrEmpty(s)) || (j >= jmena.GetLength(1)))
                                break;
                            jmena[i, j] = s;
                            j++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Chyba čtení jmen z externího souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //metoda vyhledá osobu v kalendáři podle zadaného datumu
        public string VypisSvatekOsoby(DateTime datum)
        {
            int den = datum.Day;
            int mesic = datum.Month;

            return jmena[mesic - 1, den - 1];
        }

        //metoda vyhledání svátku osoby
        public string NajdiSvatekOsoby(string jmeno)
        {
            for (int i = 0; i < jmena.GetLength(0); i++)//měsíce
            {
                for (int j = 0; j < jmena.GetLength(1); j++)//dny
                {
                    string s = jmena[i, j];
                    if ((s != null) && (s.Contains(jmeno)))
                        return string.Format($"{j+1}.{i+1}.");  
                }               
            }
            return "Není v kalendáři";
        }

        //exportuje data vybrané osoby do .txt souboru
        public void ExportujDataOsoby(Osoba osoba, string cesta)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(cesta))
                {
                    sw.WriteLine(osoba.Jmeno);
                    sw.WriteLine(osoba.Narozeniny.ToString());
                    sw.WriteLine(osoba.DalsiUdaje);
                    sw.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba zápisu osoby do souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
