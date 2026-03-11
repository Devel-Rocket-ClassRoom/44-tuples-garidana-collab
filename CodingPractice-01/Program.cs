using System;
using static System.Console;


// README.md를 읽고 코드를 작성하세요.




// 1
var Bob = ("bob", 23);
WriteLine(Bob.Item1);
WriteLine(Bob.Item2);

WriteLine();

// 2-1
var tN = (12, 36, 56);
WriteLine($"{tN.Item1}, {tN.Item2}, {tN.Item3}");

WriteLine();

// 2-2
var tuple = ("Hello", 100, true, 3.15);
WriteLine($"{tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}");

WriteLine();

// 3-1
(string, int) person = ("Alice", 25);
WriteLine($"{person.Item1}, {person.Item2}");

WriteLine();

// 3-2
(ushort Width, ushort Height) 해상도 = (1920, 1080);
WriteLine($"해상도: {해상도.Width} x {해상도.Height}");

WriteLine();

// 4
var org = ("Bob", 23);
var rep = org;
rep.Item1 = "JOe";

WriteLine($"원본: {org}");
WriteLine($"복사본: {rep}");

WriteLine();

// 5
var s = (name: "Bob", age: 23);
WriteLine($"{s.name}\n{s.age}\n{s.Item1}\n{s.Item2}");

WriteLine();

// 6
(string name, bool IsStudent, int OrderPrice) s1 = ("철수", true, 1000);
WriteLine($"{s1.name}(학생: {s1.IsStudent}) - 주문: {s1.OrderPrice}");

WriteLine();

// 7
(string name, int age, char gender) t = ("Bob", 23, 'M');
WriteLine($"이름: {t.name}\n나이: {t.age}\n성별: {t.gender}");

WriteLine();

// 8 
var now = DateTime.Now;
var date = (now.Day, now.Month, now.Year);
WriteLine($"일: {date.Day}\n월: {date.Month}\n년: {date.Year}");

WriteLine();

