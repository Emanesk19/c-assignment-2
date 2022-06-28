// See https://aka.ms/new-console-template for more information
int []num = new int[6];
for(int i = 0; i < num.Length - 1; i++)
{
    Console.WriteLine("Enter number : "+ (i+1));
    num[i] = Convert.ToInt32(Console.ReadLine());
}
int min = num[0];
int max = num[0];
int diff = 0;
for(int i = 0; i < num.Length - 1; i++)
{
    if (num[i] < min)
    {
        min = num[i];
    }
    else
    {
        max = num[i];
    }
    diff = max - min;
}
Console.WriteLine("Minimum = " + min);
Console.WriteLine("Maximum = " + max);
Console.WriteLine("The Maximum  difference between two elements of the array is   = " + diff);




