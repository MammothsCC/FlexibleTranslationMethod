using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franky
{
    class FlexibleTranslationMethod
    {
        
        static void Main(string[] args)
        {
            #region Bevor die Positionen beginnen erstellen der Translation. Damit wir sie nicht für jede Position angelegt.

            Dictionary<string, string> trans = new Dictionary<string, string>();
            trans.Add("Hallo", "Hello,Salute,Tschau");
            trans.Add("MM", "Millimeter,Kleinermeta");
            trans.Add("M", "Meter,Großermeter");
            
            #endregion

            //An dem Punkt verwenden wo die Translation beginngen soll und statt Liter den eingelesen Wert verwenden welcher Übersetzt werden soll.
            string x = FlexibleTranslationMethod(trans, "Meter");


            string FlexibleTranslationMethod(Dictionary<string, string> translation, string value)
            {                
                value = $"|{value}|";
                bool translationFound = false;
                foreach(string key in translation.Keys)
                {
                    string values = translation[key];
                    values = $"|{values.Replace(',','|')}|";

                    if (values.Contains(value))
                    {
                        value = key;
                        translationFound = true;
                        break;
                    }

                }
                if (!translationFound)
                {
                    //internalexception
                }
                return value;
            }

        }
    }
}
