/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

int[] CreateArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(99,1000);
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length - 1; i++){
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length - 1]+" ]");
}

void EvenNumbersArray(int[] array){
    int S = 0;
    for(int i=0; i<array.Length; i++){
        if(array[i] % 2 == 0) S ++;
    }
    Console.WriteLine("Количество четных чисел в массиве: " + S);
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
EvenNumbersArray(array);
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(-1000,1000);
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length - 1; i++){
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length - 1]+" ]");
}

int SumOddsArray(int[] array){
    int S = 0;
    for(int i=1; i<array.Length; i = i + 2){
        S = S + array[i];
    }
    return S;
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
if(size < 2){
    Console.WriteLine("Нечетных элементов нет");
}
else{
    Console.WriteLine("Сумма нечетных элементов: " + SumOddsArray(array));
}
*/
/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.
*/
double[] CreateArray(int size){
    double[] array = new double[size];
    for (int i=0; i < size; i++){
        array[i] = Convert.ToDouble(new Random().Next(-1000,1000)) / 10;
    }
    return array;
}

void ShowArray(double[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length - 1; i++){
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length - 1]+" ]");
}

double MaxArray(double[] array){
    double Max = array [0];
    for(int i=1; i<array.Length; i ++){
        if(Max < array[i]) Max = array[i];
    }
    return Max;
}

double MinArray(double[] array){
    double Min = array [0];
    for(int i=1; i<array.Length; i ++){
        if(Min > array[i]) Min = array[i];
    }
    return Min;
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine("Разность между минимальным и максимальным элементами массива: " + (MaxArray(array) - MinArray(array)));