//MADE BY DECL1NE


//list of all symbols

List<string> Crypted = new List<string>() { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "`", " ", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "[", "]", "Q", "W", "E",
 "R", "T", "Y", "U", "I", "O", "P", "{", "}", "a", "s", "d", "f", "g", "h", "j", "k", "l", ";", "'", "A", "S", "D", "F", "G", "H", "J", "K", "L", ":", "z", "x", "c", "v", "b", "n", "m", ",", ".", "/", "Z", "X", "C", "V", "B", "N", "M", "<", ">", "?", "|",};
List<string> Normal = new List<string>(){ " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "`", " ", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "[", "]", "Q", "W", "E",
 "R", "T", "Y", "U", "I", "O", "P", "{", "}", "a", "s", "d", "f", "g", "h", "j", "k", "l", ";", "'", "A", "S", "D", "F", "G", "H", "J", "K", "L", ":", "z", "x", "c", "v", "b", "n", "m", ",", ".", "/", "Z", "X", "C", "V", "B", "N", "M", "<", ">", "?", "|",};

//Count of symbols

int CryptedCount = Crypted.Count;
Console.WriteLine("Total characters in the list: " + CryptedCount);

//coding each symbol

Random rnd = new Random();
for (int i = 0; i < Crypted.Count; i++)
{
    Crypted[i] = Convert.ToString(Normal[rnd.Next(0, Crypted.Count)] + Normal[rnd.Next(0, Crypted.Count)] + Normal[rnd.Next(0, Crypted.Count)] + Normal[rnd.Next(0, Crypted.Count)] + Normal[rnd.Next(0, Crypted.Count)] + Normal[rnd.Next(0, Crypted.Count)]
        + Normal[rnd.Next(0, Crypted.Count)] + Normal[rnd.Next(0, Crypted.Count)]);
    Console.WriteLine("List value " +"'"+ Normal[i] +"'"+ " has been successfully encoded into " + Crypted[i]);
}

Console.WriteLine("Enter text: ");
string text = Console.ReadLine();

//Cryption of text

List<string> CryptedTextSymbols = new List<string>();           //List of crypted symbols in text
char[] ArrayText = text.ToCharArray();                          //Text to char
//List<string> s124a = new List<string>();
string CryptedText = "";                                        //Variable in which the crypted text will be placed
for (int i = 0; i < Convert.ToInt32(ArrayText.Length); i++)
{
    //Normal symbols to crypted symbols
    CryptedTextSymbols.Add(Crypted[Normal.IndexOf(ArrayText[i].ToString())]);
    Console.WriteLine(CryptedTextSymbols[i]);
    //Adding crypted symbols to final text
    CryptedText = CryptedText + CryptedTextSymbols[i] + " ";
}
Console.WriteLine(CryptedText);



// NEED TO MAKE: DECRYPTOR, COMMANDS, INTERFACE, REMOVE DEBUG, ADD RUSSIAN SYMBOLS





