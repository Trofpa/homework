﻿/*Условие задачи:

Показать интервалы времени, когда было больше всего людей в магазине.  

    _Пример работы программы:_  
Журнал посещения (сделать генератором чисел 0-23):  
11-13;
10-14;
9-10;
11-22;
18-18;
0-23;
4-5;
4-5;
4-5

Ответ : 4-5, 11-13

1. Метод - проверяем каждый час, ведем счетчик людей,
на выходе получаем массив с кол-вом людей [0, 23] - индекс == час.

2. Метод - определяем максимальные значения в массиве. Если внутри 
есть несколько max подряд - как то отформатировать это в ответе.

Подсказка: используй методы .Split() и .Substring() чтобы работать с форматами!

Автор: Трофимов П.А.
*/



string[] Visit_Magazine = {"11-13", "10-14", "9-10", "11-22", "18-18", "0-23", "4-5", "4-5", "4-5"};



int[] PeopleHour(string[] visits)
{
    for (int i = 0; i < visits.Length; i++)
    {

    }
}


string val = "11-13";
Console.WriteLine(val[2]);

