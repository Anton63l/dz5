//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] GenerateArray(int length) {
//     var array = new int[length];

//     var random = new Random();

//     for (var i = 0; i < array.Length; i++) {
//         array[i] = random.Next(0, 1000);
//     }

//     return array;
// }

// void PrintArray(int[] array) {
//     int counter = 0;
//     for (var i = 0; i < array.Length - 1; i++) {
//         Console.Write(array[i] + ", ");
//         if(array[i] % 2 == 0){
//             counter++;
//         }
//     }
//     Console.WriteLine(array[array.Length - 1]);
//     System.Console.WriteLine($"Количество четных чисел в массиве: {counter}");
// }


// var array = GenerateArray(10);
// PrintArray(array);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

// int[] GenerateArray(int length) {
//     var array = new int[length];

//     var random = new Random();

//     for (var i = 0; i < array.Length; i++) {
//         array[i] = random.Next(-100, 101);
//     }

//     return array;
// }

// void PrintArray(int[] array) {
//     int sum = 0;

//     // Выводим на печать массив
//     for (var i = 0; i < array.Length-1; i++) {
//         Console.Write(array[i] + ", ");
        
//     }
    
//     Console.WriteLine(array[array.Length - 1]);

// // Выводим на печать сумму четных элементов
//     for (var i = 1; i < array.Length; i+=2) {
//             sum += array[i];
//     }

//     System.Console.WriteLine($"Сумма нечетных элементов массива равна: {sum}");
// }

// var array = GenerateArray(10);
// PrintArray(array);

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray(int length) {
    double[] array = new double [length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.Next(-100, 100) + rand.NextDouble();;
    }

       return array;
}

void PrintArray(double[] array) {
    for (var i = 0; i < array.Length - 1; i++) {
        Console.Write(array[i] + ", ");
       
    }
    Console.WriteLine(array[array.Length - 1]);
}

void MinMax(double[] array){
    // Задаем входные параметры мин и макс вне диапозона генерации массива
    double min = 1000;
    double max = -1000;
    
    for (int i = 0; i < array.Length; i++){
        if (array[i] < min) min=array[i];        
        if (array[i] > max) max=array[i];
                    
    } 

    System.Console.WriteLine($"Разница между max {max} и min {min} составляет {max-min}");
    
}

var array = GenerateArray(10);
PrintArray(array);
MinMax(array);