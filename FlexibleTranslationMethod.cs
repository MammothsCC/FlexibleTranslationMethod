using System.Collections.Generic;

namespace Franky
{
    class FlexibleTranslationMethod
    {

        string TranslationMethod(Dictionary<string, string> translation, string value)
        {
            value = $"|{value}|";
            bool translationFound = false;
            foreach (string key in translation.Keys)
            {
                string values = translation[key];
                values = $"|{values.Replace(',', '|')}|";

                if (values.Contains(value))
                {
                    value = key;
                    translationFound = true;
                    break;
                }

            }
            if (!translationFound)
            {
                //exception
            }
            return value;


        }
    }
}
