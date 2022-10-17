/*Задача 38: Задайте массив вещественных чисел. Найдите разницу
 между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] CreateArray (int num)
{
    double[] array = new double [num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rnd.NextDouble(-99.1,99.9);
    }
    return (array);
}
void PrintArray (double[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i!=array.Length-1)
        {Console.Write($"{array[i]}, ");}
       else {Console.Write($"{array[i]}] -> ");}
    }
}
void ElementSummCount (double[] array)
{
    double min = 0;
    double max =0;
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
