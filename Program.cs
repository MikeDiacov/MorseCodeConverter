// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



Console.WriteLine(MorseCode.MorseToString(".... . -.--   .--- ..- -.. .", MorseCode.MorseCodeDecoder()));
Console.WriteLine(MorseCode.StringToMorse("my name is", MorseCode.MorseCodeDecoder()));
Console.WriteLine(MorseCode.StringToMorse("hey jude", MorseCode.MorseCodeDecoder()));

public class MorseCode
{
    public static string MorseToString(string str, Dictionary<char, string> decoder)
    {

        str += " ";
        string symbolContainer = string.Empty;
        string decodetStr = string.Empty;
        int space = 0;

        foreach (char symbol in str)
        {
            if (symbol != ' ')
            {
                symbolContainer += symbol;
            }
            else
            {
                space++;

                foreach (var decodetSymbol in decoder)
                {
                    if (symbolContainer == decodetSymbol.Value)
                    {
                        decodetStr += decodetSymbol.Key;
                        if (space == 3) { decodetStr += " "; }
                        symbolContainer = string.Empty;
                        break;
                        space = 0;
                    }
                }
            }
        }
        return decodetStr;
    }


    public static string StringToMorse(string fraze, Dictionary<char, string> decoder)
    {
        string SymbolConteiner = string.Empty;


        foreach (var letter in fraze)
        {
            if (letter == ' ')
                SymbolConteiner +="   ";
            else
            { 
                foreach (var decodetSymbol in decoder)
                {
                    if (letter == decodetSymbol.Key)
                    {
                        SymbolConteiner += decodetSymbol.Value;
                        SymbolConteiner += ' ';
                        break;
                    }    
                }
            }
        }
        return SymbolConteiner;
    }

    public static Dictionary<char, string> MorseCodeDecoder()
    {
        char dot = '.';
        char dash = '-';

        Dictionary<char, string> decoder = new Dictionary<char, string>()
        {
                {'a', string.Concat(dot, dash)},
                {'b', string.Concat(dash, dot, dot, dot)},
                {'c', string.Concat(dash, dot, dash, dot)},
                {'d', string.Concat(dash, dot, dot)},
                {'e', dot.ToString()},
                {'f', string.Concat(dot, dot, dash, dot)},
                {'g', string.Concat(dash, dash, dot)},
                {'h', string.Concat(dot, dot, dot, dot)},
                {'i', string.Concat(dot, dot)},
                {'j', string.Concat(dot, dash, dash, dash)},
                {'k', string.Concat(dash, dot, dash)},
                {'l', string.Concat(dot, dash, dot, dot)},
                {'m', string.Concat(dash, dash)},
                {'n', string.Concat(dash, dot)},
                {'o', string.Concat(dash, dash, dash)},
                {'p', string.Concat(dot, dash, dash, dot)},
                {'q', string.Concat(dash, dash, dot, dash)},
                {'r', string.Concat(dot, dash, dot)},
                {'s', string.Concat(dot, dot, dot)},
                {'t', string.Concat(dash)},
                {'u', string.Concat(dot, dot, dash)},
                {'v', string.Concat(dot, dot, dot, dash)},
                {'w', string.Concat(dot, dash, dash)},
                {'x', string.Concat(dash, dot, dot, dash)},
                {'y', string.Concat(dash, dot, dash, dash)},
                {'z', string.Concat(dash, dash, dot, dot)},
                {'0', string.Concat(dash, dash, dash, dash, dash)},
                {'1', string.Concat(dot, dash, dash, dash, dash)},
                {'2', string.Concat(dot, dot, dash, dash, dash)},
                {'3', string.Concat(dot, dot, dot, dash, dash)},
                {'4', string.Concat(dot, dot, dot, dot, dash)},
                {'5', string.Concat(dot, dot, dot, dot, dot)},
                {'6', string.Concat(dash, dot, dot, dot, dot)},
                {'7', string.Concat(dash, dash, dot, dot, dot)},
                {'8', string.Concat(dash, dash, dash, dot, dot)},
                {'9', string.Concat(dash, dash, dash, dash, dot)}
        };
        return decoder;
    }
}