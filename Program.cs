// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// функция ввода элементов массива
string[] VvodDannih(int size)
{    
    string[] array = new string[size];   // новый массив с размером size
    
    for (int i = 0; i <= size-1; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива (вводить можно любые символы и любое количество): ");   //тут вводим сами элементы массива и запоминаем их 
        array[i] = Console.ReadLine();
    }
    return array; // возвращаем из функции массив
}

// функция вывода в консоль
void ShowArray(string[] array)
{
    int x = 3;  //По условию задачи стоит ограничение 3 символами,
    // Хотя для экономии памяти можно было прям в условии указать "магическим числом",
    // но их нас учили не делать...  поэтому займу кусок памяти :)
    Console.Write("Элементы массива содержащие 3 и менее символов: [  ");
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=x) 
        {
            Console.Write(array[i]+"  ");
        }
    }
    Console.Write(" ]");
}


Console.WriteLine("Сколько элементов будет в массиве?");   // задаем значение размера массива которое потом будем использовать при создании массива.
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(VvodDannih(size));

// Все работает!!!