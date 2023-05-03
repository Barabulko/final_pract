// See https://aka.ms/new-console-template for more information

/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string[] array = {"Hello", "2", "world", ":-)"};
int new_size=0;

for(int i=0; i<array.Length; i++){
    if (array[i].Length<4){
        new_size++;
    }
}

string[] new_array = new string[new_size];
int j=0;

for(int i=0; i<array.Length; i++){
    if (array[i].Length<4){
        new_array[j]=array[i];
        j++;
    }
}

for(int i=0; i<new_array.Length; i++){
    Console.WriteLine(new_array[i]);
}