/*  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.WriteLine("Введите любые 5 слов через Enter:");
string[] stringArray = new string[5];
string[] stringAr = new string[5];
    for (int i = 0; i < stringArray.Length; i++){
        stringArray[i] = Console.ReadLine();
    }
Console.WriteLine("Исходный массив:");{
    for(int i = 0; i < stringArray.Length; i++)
        Console.Write(" "+ stringArray[i]);
    }
  

