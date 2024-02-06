using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.ComponentModel;

namespace Upominac
{
    internal class XmlTransfer
    {


        //metoda čtení elementů metodou LINQ to XML => vrátí List<Xelement>
        public List<XElement> CteniXml(string rootElement, string element, string soubor)
        {
            XDocument dokument = XDocument.Load(soubor);
            var myList = dokument.Descendants(element).ToList();
            return myList;
        }


        //metoda typu SAX - zápis všech vlastností a volitelně atributů(fields) z kolekce (tř."Osoba")
        public void ZapisDoXml(BindingList<Osoba> kolekce, string? rootElement, string? element, bool getFields, string soubor)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
         
            using (XmlWriter xw = XmlWriter.Create(soubor, settings))
            {
                string rootElementName = rootElement ?? GetType().Name;
                xw.WriteStartDocument(); 
                xw.WriteStartElement(rootElementName); 
                
                foreach (Osoba u in kolekce)
                {   
                    var getPropertyValue = u.GetType().GetProperties().Select(p => p.GetValue(u));
                    var getPropertyName = u.GetType().GetProperties().Select(p => p.Name);
                    
                    var getFieldsValue = getFields ? u.GetType().GetFields().Select(p => p.GetValue(u)) : null;
                    var getFieldsName = getFields ? u.GetType().GetFields().Select(p => p.Name) : null;
                    
                    object?[] propFieldsValues = (getFieldsValue == null) ? getPropertyValue.ToArray() : getPropertyValue.ToArray().Union(getFieldsValue).ToArray();
                    string[] propFieldsNames = (getFieldsName == null) ? getPropertyName.ToArray() : getPropertyName.ToArray().Union(getFieldsName).ToArray();
                    string elementName = element ?? u.GetType().Name;
                    
                    if ((propFieldsNames.Length > 0) && (propFieldsValues.Length > 0))
                    {
                        xw.WriteStartElement(elementName);
                        for (int i = 0; i < propFieldsNames.Length; i++)
                            xw.WriteElementString(propFieldsNames[i], propFieldsValues[i]?.ToString());
                        xw.WriteEndElement();
                    }
                }   
                xw.WriteEndElement(); 
                xw.WriteEndDocument(); 
                xw.Flush();
            }
        }



    }
}
