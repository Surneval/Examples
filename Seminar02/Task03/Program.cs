//Напишите программу, которая будет принимать на вход два числа и выводить
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number1 = Prompt("Please type number1 ");
int number2 = Prompt("Please type number2 ");

int DivBy (int number1, int number2) // вычисляем остаток от деления
{
    return number2 % number1;
}

if(DivBy(number2, number1)==0)
{
    Console.WriteLine("ok");
}
else
{
    Console.WriteLine(DivBy(number2, number1));
}