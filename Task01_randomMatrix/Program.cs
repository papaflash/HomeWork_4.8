using System;

namespace Task01_randomMatrix
{
    internal class Program
    {
        /// <summary>
        /// Задание1. Случайная матрица.
        /// Сначала пользователю предлагается ввести количество строк в будущей матрице.
        /// Затем — ввести количество столбцов в будущей матрице.
        /// После того, как данные будут получены, нужно создать в памяти матрицу заданного размера.
        /// Используя Random, заполнить матрицу случайными целыми числами.
        /// Вывести полученную матрицу на экран. 
        /// Вывести суммы всех элементов этой матрицы на экран отдельной строкой.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Создай случайную матрицу!\nПо умолчанию матрица заполняется случайными числами в диапазоне от 0 до 1000");
            Console.Write("Если хотите изменить диапазон введите новое значение либо нажмите Enter: ");
            if(!int.TryParse(Console.ReadLine(), out int _maxValue))
            {
                Console.WriteLine("Максимальное значение установлено по умолчанию");
                _maxValue = 1000;
            }
            Console.Write("Введите кол-во строк: ");
            if(!int.TryParse(Console.ReadLine(), out int _countRows) || _countRows < 1)
            {
                Console.WriteLine("Вы ввели не допустимое значение строк!");
                return;
            }
            Console.Write("Введите кол-во столбцов: ");
            if (!int.TryParse(Console.ReadLine(), out int _countColumns) || _countColumns < 1)
            {
                Console.WriteLine("Вы ввели не допустимое значение строк!");
                return;
            }
            const ushort RATIO_FORMATTING_PRINT = 10;
            int _countChars = _countColumns * RATIO_FORMATTING_PRINT;
            long _sum = 0;
            Random _randomGen = new Random();
            int[,] _matrix = new int[_countRows, _countColumns];
            Console.WriteLine($"\nМатрица размером: {_countRows} x {_countColumns}");
            Console.WriteLine(new String('=', _countChars));
            for (int i = 0; i < _countRows; i++)
            {
                for(int j = 0; j < _countColumns; j++)
                {
                    _matrix[i, j] = _randomGen.Next(_maxValue);
                    _sum += _matrix[i, j];
                    Console.Write($"{_matrix[i, j],10}");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', _countChars));
            Console.WriteLine($"Сумма всех чисел в матрице: {_sum}");
            Console.ReadKey();
        }
    }
}
