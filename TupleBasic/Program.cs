using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static System.Console;

// README.md를 읽고 코드를 작성하세요.



string Name;
int Age;
int Grade;

// 튜플 반환하는 CreateStudent 메서드 생성
(string name, int age, int grade) CreateStudent(string name, int age, int grade)
{
    Name = name;
    Age = age;
    Grade = grade;

    var result = (Name, Age, Grade);

    return result;
}

// 튜플 반환받은 값을 매개변수로 하고 학생 정보 출력하는 메서드 생성
void PrintStudent((string name, int age, int grade) student)
{
    WriteLine($"[{student.name}] - 나이: {student.age}세, 학년: [{student.grade}]학년");
}

// 반환값을 변수에 할당
var one = CreateStudent("철수", 16, 1);
var two = CreateStudent("영희", 17, 2);
var three = CreateStudent("민수", 18, 3);


// CreateStudent로 만든 세개의 튜플 변수 리스트 생성
List<(string name, int age, int grade)> students = new()
{
    (one),
    (two),
    (three)
};

WriteLine("=== 학생 정보 출력 ===");
foreach (var s in students)
{
    PrintStudent(s);
}

WriteLine();

WriteLine("=== 첫 번째 학생 무자비하기 분해 해버리기 ===");
(string name, int age, int grade) = one;
WriteLine($"이름: {one.name}\n나이: {one.age}\n학년: {one.grade}");