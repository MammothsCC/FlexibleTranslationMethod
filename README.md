# FlexibleTranslationMethod
Translates a value into a key if the value from the key contains this value in the dictionary.

Please use strings only.
If you have several values that are to be translated into one key, separate them with a comma.

Example

Dictionary<string, string> trans = new Dictionary<string, string>();

trans.Add("Hallo", "Hello,Salute,Tschau");

string x = FlexibleTranslationMethod(trans, "Salute"); --> x = Hello

If anyone reads this and has any suggestions for improvement, I would be very grateful. I am at the beginning of my career and I am looking forward to developing myself further.

Thanks for the interest in my method and have a nice day :)
