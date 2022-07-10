using System;

namespace Task02_MinValue
{
    internal class Program
    {
        /// <summary>
        /// Задание 2. Найти наименьший элемент в последовательности
        /// Пользователь вводит длину последовательности.
        /// Затем пользователь последовательно вводит целые числа (как положительные, так и отрицательные). Числа разделяются клавишей Enter.
        /// Каждое введённое число помещается в соответствующий элемент массива.
        /// После окончания ввода данных отдельный цикл проходит по последовательности и находит минимальное число.Для этого он сравнивает каждое число в итерации с предыдущим найденным минимальным числом.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Программа нахождения наименьшего числа из последовательности");
            Console.Write("Введите размер последовательности: ");
            if (!int.TryParse(Console.ReadLine(), out int _length) || _length < 1)
            {
                Console.WriteLine("Вы ввели не допустимое значение!");
                return;
            }
            int[] _array = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                Console.Write($"Введите число №{i+1}: ");
                if(int.TryParse(Console.ReadLine(), out int _num)) { _array[i] = _num; }
                else
                {
                    Console.WriteLine("Вы ввели не допустимое значение!");
                    i--;
                }
            }
            int _minValue = _array[0];
            Console.Write("Массив введный пользователем: ");
            for(int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < _minValue)
                    _minValue = _array[i];
                if(i != _array.Length - 1)
                    Console.Write(_array[i] + ", ");
                else 
                    Console.Write(_array[i]);
            }
            Console.WriteLine($"\nНаименьшее число в массиве равно: {_minValue}");
            Console.ReadKey();
        }
    }
}
