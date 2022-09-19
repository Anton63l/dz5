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