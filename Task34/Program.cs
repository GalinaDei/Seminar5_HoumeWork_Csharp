/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateArray (int num)
{
    int[] array = new int [num];
    Random rnd = new Random(num);
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rnd.Next(100,999);
    }
    return (array);
}
void PrintArray (int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i!=array.Length-1)
        {Console.Write($"{array[i]}, ");}
       else {Console.Write($"{array[i]}] ->");}
    }
}
void EvenNumResearch (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        {count++;}
        else{}
        
    }    
    Console.WriteLine($"{count}");
}

int[]resultArray= CreateArray (5);
PrintArray(resultArray);
EvenNumResearch(resultArray);