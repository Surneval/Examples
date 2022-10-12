Console.WriteLine("Please type your name");
string username = Console.ReadLine();

if(username.ToLower() == "jack")
{
    Console.WriteLine("Wow! It's you, Jack!!!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
}