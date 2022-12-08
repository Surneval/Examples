// Разработать рекурсивную функцию, которая реализует синтаксический анализатор
//для понятия идентификатор
using System.Linq;
string Prompt(string userMsg)
{
    Console.WriteLine(userMsg);
    return Console.ReadLine();
}

bool IsIdentifire(string word, int pos)
{
    word.ToLower();
    char[] sAr = word.ToArray();
    while (pos < sAr.Length)
    {
        char symb = sAr[pos];
        if (pos == 0)
        {
            if ((symb >= 'a') && (symb <= 'z'))
            {
                return IsIdentifire(word, pos + 1);
            }
            else return false;
        }
        else
        {
            if ((symb >= 'a' && symb <= 'z') || (symb >= '0' && symb <= '9'))
            {
                return IsIdentifire(word, pos + 1);
            }
            else return false;

        }
    }
    return true;
}

void Runner()
{
    string word = Prompt("Enter Identifier");
    int pos = 0; // позиция символа в идентификаторе
    if (IsIdentifire(word, pos)) Console.WriteLine($"Identifier {word} is correct");
    else Console.WriteLine($"Identifier {word} is not correct");

}
Runner();