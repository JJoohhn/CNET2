Console.WriteLine("Hello, World!");


var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

var result = strings.Select(x => x.ToUpper());

var vypisCisla = numbers.Select(x => strings[x]);

bool result2 = numbers.All(x => x % 2 == 0);

var soucetPismen = strings.Select(x => x.Length).Sum();
Console.WriteLine($"vsechna slova v poli strings maji dohromady {soucetPismen} pismen");

Console.WriteLine($"jsou vsechna cisla suda: {result2}");

//PrintList(result.ToList());
PrintList(vypisCisla.ToList());

//3 vypiste cisla v poli numbers jako slova

//Václavův výpis
foreach (var item in numbers)
{
    Console.WriteLine("vaclav: " + strings[item]);
}

static void PrintList(List<string> listToPrint)
{

    foreach (var item in listToPrint)
    {
        Console.WriteLine(item);
    }
}

