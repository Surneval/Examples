// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Please type the number from 1 to 7 "); // выводим подсказку на экран
int number = int.Parse(Console.ReadLine());

string[] days = new string[7] {"Monday", "tuestday", "wednesday", "thursday", "friday", "saturday", "sunday"};
if (number > 0 && number < 8);
Console.WriteLine(days[number-1]);