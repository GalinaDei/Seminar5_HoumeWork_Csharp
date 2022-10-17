/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] CreateArray (int num)
{
    int[] array = new int [num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rnd.Next(1,999);
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
       else {Console.Write($"{array[i]}] -> ");}
    }
}
void ElementSummCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2!=0)
        {count= count + array[i];}
        else{}
        
    }    
    Console.WriteLine($"{count}");
}

int[]resultArray= CreateArray (3);
PrintArray(resultArray);
ElementSummCount(resultArray);
