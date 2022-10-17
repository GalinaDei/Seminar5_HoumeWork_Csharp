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
        array[i]=rnd.Next(1,99)+rnd.NextDouble();
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
(double, double) FindMaxMin(double[] array)
    {
        double max = array[0];
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i]>max) max=array[i];
            if(array[i]<min) min = array[i]; 
        }
        return (max,min);
    }

double[]resultArray= CreateArray (5);
PrintArray(resultArray);
(double max, double min) = FindMaxMin(resultArray);
double difference = max - min;
Console.WriteLine(difference);


