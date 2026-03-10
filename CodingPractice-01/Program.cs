using System;

// README.md를 읽고 아래에 코드를 작성하세요.
//1.
/*
Calculator calc = Square;
Console.WriteLine(calc(5));

int Square (int x)
{
    return x * x;
};

delegate int Calculator(int x);


//2.
Transformer square = delegate (int x) { return x * x; };
Transformer cube = delegate (int x) { return x * x * x; };

Console.WriteLine($"3의 제곱: {square(3)}");
Console.WriteLine($"3의 세제곱: {cube(3)}");

delegate int Transformer(int x);


//3.
Printer print = delegate (string message) { Console.WriteLine($"[메시지] {message}"); };
print("안녕하세요!");
print("익명 메서드를 사용 중입니다.");
delegate void Printer(string s);


//4.
Func<int, int> doubler = delegate (int x) { return x * 2; };
Action<string> logger = delegate (string msg) { Console.WriteLine($"[LOG] {msg}"); };
Console.WriteLine(doubler(10));
logger("작업 시작");


//5.
SimpleDelegate handler = delegate { Console.WriteLine("매개변수를 사용하지 않습니다."); };
handler(100, "테스트");
delegate void SimpleDelegate(int n, string s);
*/

//6.
EventHandler onClick = delegate { Console.WriteLine("클릭 이벤트 발생!"); };
onClick(null, EventArgs.Empty);
delegate void EventHandler(object obj, EventArgs e);
