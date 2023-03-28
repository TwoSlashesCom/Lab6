using System.Text;
using System.Text.RegularExpressions;

//task 1

//task a

Console.WriteLine("Task 1 a");

string target = "happy new year";
Regex x = new Regex(@"abcd(2023)1{7}0\1");
string pattern = @"2023";
Console.WriteLine("Input string: ");
string str = Console.ReadLine();

if (x.IsMatch(str) == true)
{
    Regex reg = new Regex(pattern);
    string result = reg.Replace(str, target);
    Console.WriteLine(result);
}



//task b

Console.WriteLine("Task 1 b");

Console.WriteLine("Input string");
string input = Console.ReadLine();
List<int> numbers = new List<int>();
int currentNumber = 0;

for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i];
    if (Char.IsDigit(currentChar))
    {
        currentNumber = int.Parse(currentChar.ToString()) + currentNumber * 10;
    }
    else if (currentNumber != 0)
    {
        numbers.Add(currentNumber);
        currentNumber = 0;
    }

    if (currentNumber != 0)
    {
        numbers.Add(currentNumber);
    }

    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }

    int sum = numbers.Sum();
    Console.WriteLine($"Sum: {sum}");

    int maxNumber = numbers.Max();
    int maxIndex = numbers.IndexOf(maxNumber);
    Console.WriteLine($"Max: {maxNumber}, position number: {maxIndex}");
}



//task c
Console.WriteLine("Task 1 c");

Console.WriteLine("Inpiut string: ");

string input1 = Console.ReadLine();
List<string> decimals = new List<string>();

MatchCollection matches = Regex.Matches(input1, @"[-+]?\d+[.,]\d+?");

foreach (Match match in matches)
{
    decimals.Add(match.Value);
}

foreach (string number in decimals)
{
    Console.WriteLine(number);
}

string output = Regex.Replace(input1, @"[-+]?\d+[.,]\d+?", "number");

Console.WriteLine(output);


//task d
Console.WriteLine("Task 1 d");

Console.Write("Input file adress: ");
string path = Console.ReadLine();

MatchCollection matches1 = Regex.Matches(path, @"\\([\w\d\s]+)");

Console.WriteLine("Catalog list: ");
foreach (Match match1 in matches1)
{
    Console.WriteLine(match1.Groups[1].Value);
}




//task 2

//task a

Console.WriteLine("Task 2 a");

for (int j = 0; j < 5; j++)
{
    string s = Console.ReadLine();
    Regex regexcat = new Regex(@"(cat){2}");
    MatchCollection matchescat = regexcat.Matches(s);
    foreach (Match match in matchescat)
    {
        Console.WriteLine(match);
    }
}

//task b

Console.WriteLine("Task 2 b");

// task c

Console.WriteLine("Task 2 c");

for (int j = 0; j < 5; j++)
{
    string str2 = Console.ReadLine();
    Regex newregex = new Regex(@"(ик\b)");
    string resultstring = newregex.Replace(str2, string.Empty);
    Console.WriteLine(resultstring);
}

//task d

Console.WriteLine("Task 2 d");

for (int j = 0; j < 5; j++)
{
    string str3 = Console.ReadLine();
    Regex patternABCD = new Regex(@"#[ABCDEF0-9]{6}");
    MatchCollection newmatches = patternABCD.Matches(str3);
    foreach (Match match in newmatches)
    {
        Console.WriteLine(match);
    }
}


