// Working with index of array
int[] array = { 11, 22, 36, 42, 5, 67, 7, 18, 36, 18 };
int n = array.Length;
int find = 18;

int index = 0;
while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index+1
    index++;

}
