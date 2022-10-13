int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 20;
int friend = 2;
int time = 0;
while(distance > 10)
{
    if(friend == 2)
    {
        time = time + (distance / (secondFriendSpeed+dogSpeed));
        friend = 1;
    }

    if(friend == 1)
    {
        time = time + (distance / (firstFriendSpeed + dogSpeed));
        friend = 2;
    }

distance = distance - ((firstFriendSpeed + secondFriendSpeed) * time);
count = count + 1;
}
Console.Write(count);
Console.Write(" times");