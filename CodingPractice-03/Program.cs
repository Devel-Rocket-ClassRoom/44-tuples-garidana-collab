using System;
using System.Collections.Generic;
using static System.Console;

// README.md를 읽고 코드를 작성하세요.


// 1 
var one = (12, 12);
var two = (12, 12);
var three = (12, 1);

WriteLine($"{one.Equals(two)}");
WriteLine($"{two.Equals(three)}");

WriteLine();

// 2
bool Eqauls() => one == two;
bool Equals() => one != two;

WriteLine(Eqauls());
WriteLine(Equals());

WriteLine();

// 3
(string name, int age) person1 = ("Alice", 25);
// 요소 타입이 같은 튜플은 값 할당 호환이 가능함.
// 이름은 호환성에 영향 X
(string a, int b) person2 = person1;

WriteLine($"{person2.a} {person2.b}");

WriteLine();

// 4 
(string name, int age, char sex) sex = ("Bob", 23, 'M');
(string age, int name, char jax) jax = sex;
// 튜플 요소 이름이 달라도 타입이 맞을 시 호환 가능
WriteLine($"{jax.age}\n{jax.name}\n{jax.jax}");

WriteLine();

// 5
List<(string name, int age)> list = new()
{
    ("Alice", 25),
    ("Bob", 30),
    ("Charlie", 35)
};

foreach (var item in list)
{
    WriteLine($"{item.name}: {item.age}세");
}

WriteLine();

// 6
Dictionary<(int x, int y), string> dic = new()
{
    { (0,0), "원점" },
    {(1,0), "오른쪽" },
    {(0,1), "왼쪽" }
};

WriteLine(dic[(0, 0)]);
WriteLine(dic[(1, 0)]);

// 7
var tuple1 = new Tuple<string, int>("Bob", 23);
WriteLine($"{tuple1.Item1}, {tuple1.Item2}");

var tuple2 = Tuple.Create("Alice", 25);
WriteLine($"{tuple2.Item1}, {tuple2.Item2}");

WriteLine();

