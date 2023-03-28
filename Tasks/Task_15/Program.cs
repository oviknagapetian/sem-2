using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Создаем словарь, где ключи - это номера дней недели, а значения - это логические переменные, указывающие, является ли день выходным
        Dictionary<int, bool> weekendDays = new Dictionary<int, bool> {
            {6, true}, // Суббота
            {7, true}, // Воскресенье
            {1, false}, // Понедельник
            {2, false}, // Вторник
            {3, false}, // Среда
            {4, false}, // Четверг
            {5, false}  // Пятница
        };

        Console.Write("Введите номер дня недели: ");
        int dayNumber = int.Parse(Console.ReadLine());

        if (weekendDays.ContainsKey(dayNumber)) {
            // Если в словаре есть ключ с указанным номером дня недели, проверяем его значение
            if (weekendDays[dayNumber]) {
                Console.WriteLine("Это выходной день");
            } else {
                Console.WriteLine("Это рабочий день");
            }
        } else {
            Console.WriteLine("Неверный номер дня недели");
        }
    }
}
