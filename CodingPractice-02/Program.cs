using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

// README.md를 읽고 코드를 작성하세요.

// 1

var a = Tally();
(int,int) Tally()
{
    var sum = (12, 3);


    return sum ;
}

Console.WriteLine($"합계: {a.Item1}, 개수: {a.Item2}");

WriteLine();

// 2
(int sum, int count) Calculate(int a, int b)
{
    int sum = a;
    int count = b;
    return (sum, count);
}

var r = Calculate(45, 6);

WriteLine($"합계: {r.sum}, 개수: {r.count}");

WriteLine();

// 3
(int first, int second) GetPair(int a, int b) => (a, b);


var e = GetPair(100, 200);
WriteLine($"{e.first}, {e.second}");

WriteLine();

// 4
int[] numbers = { 5, 2, 8, 1, 9, 3 };
(int min, int max) FindMinMax(int[] a)
{
    int min = a[0];
    int max = a[0];
    foreach (int d in a)
    {
        if (d < min)
        {
            min = d;
        }
        if (d > max)
        {
            max = d;
        }
    }return (min, max);
}
var final = FindMinMax(numbers);
WriteLine($"최솟값: {final.min}, 최댓값: {final.max}");

WriteLine();


// 5

// 투플의 기본값을 dafault 로 불러낼 수 있음
(int, int) ZeroZero(int a, int b) => default;
WriteLine(ZeroZero(10,10));

WriteLine();

// 6
var bob = ("Bob", 23);
(string name, int age) = bob;
WriteLine($"이름: {name}\n나이: {age}");

WriteLine();

// 7
