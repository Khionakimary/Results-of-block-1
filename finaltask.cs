/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
*/
static string[] FormSortStrings(string[] array)  
{                                                 
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
        if (array[i].Length <= 3)   
            count++;   

    string[] NewArray = new string[count];  
    int j = 0; 
    for (int i = 0; i < array.Length; i++)   
        if (array[i].Length <= 3)  
        {                            
            NewArray[j] = array[i];     
            j++;                                      
        }    
    return NewArray;
}

void printArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        {
          Console.Write(array[i]);
          if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
    Console.WriteLine(" ]");
}

Console.WriteLine("Введите любые символы строками через пробел: ");
string[] array = Console.ReadLine()!.Split();
Console.WriteLine();
printArray(array);

Console.WriteLine();
string[] NewArray = FormSortStrings(array);
printArray(NewArray);
