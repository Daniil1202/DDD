// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// void FillArray(int[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next (100,1000);
    
//     }
// }

// void PrintArray(int[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
// }

// Console.WriteLine();


// Console.WriteLine("Введите размерость массива");
// int a =Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];
// FillArray(array);
// PrintArray(array);
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0)
//     count++;
// }
//     Console.WriteLine ($"количество четных чисел в массиве = {count}");





// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int size = 4;
int[] array = new int[size];
FillArray(array);
PrintArray(array);
int sumNumbersIndex = 0;


for (int i = 0; i < array.Length; i+=2) // i=i+2
{
    sumNumbersIndex = sumNumbersIndex+array[i];

}
Console.WriteLine(sumNumbersIndex);

void FillArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (-100 ,101);
    
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}




// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



// int size = 10;
// int[] numbers = new int[size];
// FillArray(numbers);
// PrintArray(numbers);

// int max = numbers [0];
// int min = numbers [0];



// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i]>max )
//     {
//         max = numbers[i];
//     }
//         else if( numbers[i]<min)
//         {
//           min = numbers[i];
//         }
// }
// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Максимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");


// void FillArray (int[] array)
// {
//      for (int i = 0; i < array.Length; i++)
//      {
//         array[i] = new Random().Next(1,321);
//      }

// }

// void PrintArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine( array[i] +" ");
//     }
// }



