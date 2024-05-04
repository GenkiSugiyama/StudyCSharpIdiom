// See https://aka.ms/new-console-template for more information
// 6-1
var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

// 6-1-1
Console.WriteLine(numbers.Max());

// 6-1-2


// 6-1-3
var stringNumbers = numbers.Select(numbers => numbers.ToString()).ToList();
stringNumbers.ForEach(Console.WriteLine);

// 6-1-4
var orderedNumbers = numbers.OrderBy(n => n).Take(3).ToList();
orderedNumbers.ForEach(Console.WriteLine);

// 6-1-5
var count = numbers.Distinct().Count(n => n > 10);
Console.WriteLine(count);