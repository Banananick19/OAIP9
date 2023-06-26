// See https://aka.ms/new-console-template for more information

var s = Console.ReadLine()?.Split(" "); // получаем строку параметров
if (s == null) return; // Неверный ввод
var n = int.Parse(s[0]); // получаем параметер N
var m = int.Parse(s[1]); // получаем параметер M

var matrix = new List<List<int>>(); // инициализируем матрицу

for (var i = 0; i < n; i++) // обработка ввода
{
    var line = Console.ReadLine().Split(" ").Select(c => int.Parse(c)); // получаем строку матрицы
    matrix.Add(line.ToList()); // добавляем строку в матрицу
}

var maxSum = int.MinValue; // инициализация минимальных значении суммы и индекса
var maxSumIndex = -1;
foreach (var line in matrix.Select((l, i) => new {Index = i, Value = l})) // перебираем строки матрицы
{
    var sum = line.Value.Sum(); // суммируем значения строки
    if (sum < maxSum) continue; // проверяем является сумма максимальной к данной итерации, если нет - продолжаем перебор
    maxSum = sum;               // иначе записываем значение суммы
    maxSumIndex = line.Index;   // и индекс строки
}

Console.WriteLine(maxSumIndex+1); // выводим индекс строки +1 используется, т.к. нумерация в c# начинается с 0, а не с 1