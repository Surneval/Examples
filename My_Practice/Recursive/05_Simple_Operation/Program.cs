// Determine simple operation ( + - * )
using System.Linq;

string Prompt(string userMsg)
{
    Console.WriteLine(userMsg);
    return Console.ReadLine();
}

bool IsIdentifier(char c) //Check the identifier
{
    if ((c >= 'a') && (c <= 'z'))
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool IsOperation(char c)
{
    if ((c == '+') || (c == '-') || (c == '*'))
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool IsExpression(string word, int pos, bool isOpBefore)
{
    word.ToLower();

    char symb = word[pos];
    if (pos < word.Length - 1)
    {
        if (pos == 0)
        {
            if (IsIdentifier(symb))
                return IsExpression(word, pos + 1, false);
            else return false;
        }
        else
        {
            if (IsIdentifier(symb))
                return IsExpression(word, pos + 1, false);
            else if (IsOperation(symb) && !isOpBefore) return IsExpression(word, pos + 1, true);
            else return false;
        }

    }
    else return IsIdentifier(symb);

}

void Runner()
{
    string express = Prompt("Enter Expression");
    int pos = 0;
    if (IsExpression(express, pos, false))
    {
        Console.WriteLine($" Expression {express} is ok");
    }
    else Console.WriteLine($" Expression {express} is not ok");
}
Runner();