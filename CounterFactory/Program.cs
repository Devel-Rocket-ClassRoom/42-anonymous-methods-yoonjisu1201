using System;
CounterFactory counterFactory = new CounterFactory();

Console.WriteLine("=== 단순 카운터 ===");
Console.Write($"{counterFactory.SimpleCounter()} ");
Console.Write($"{counterFactory.SimpleCounter()} ");
Console.Write($"{counterFactory.SimpleCounter()} ");
Console.Write($"{counterFactory.SimpleCounter()} ");
Console.Write($"{counterFactory.SimpleCounter()} ");

Console.WriteLine("\n=== 스텝 카운터 (step=3) ===");
Console.Write($"{counterFactory.StepCounter()} ");
Console.Write($"{counterFactory.StepCounter()} ");
Console.Write($"{counterFactory.StepCounter()} ");
Console.Write($"{counterFactory.StepCounter()} ");

Console.WriteLine("\n=== 범위 카운터 (1~3) ===");
Console.Write($"{counterFactory.BoundedCounter()} ");
Console.Write($"{counterFactory.BoundedCounter()} ");
Console.Write($"{counterFactory.BoundedCounter()} ");
Console.Write($"{counterFactory.BoundedCounter()} ");
Console.Write($"{counterFactory.BoundedCounter()} ");
Console.Write($"{counterFactory.BoundedCounter()} ");
Console.Write($"{counterFactory.BoundedCounter()} ");



// README.md를 읽고 아래에 코드를 작성하세요.
class CounterFactory
{
    public Func<int> SimpleCounter = CreateSimpleCounter();
    public Func<int> StepCounter = CreateStepCounter(3);
    public Func<int> BoundedCounter = CreateBoundedCounter(1, 3);

    static Func<int> CreateSimpleCounter()
    {
        int count = 0;
        return delegate () { return ++count; };
    }

    static Func<int> CreateStepCounter(int step)
    {
        int value = 0;
        return delegate () { return value += step; };
    }
    static Func<int> CreateBoundedCounter(int min, int max)
    {
        int value = min;
        return delegate ()
        {
            if (value == max + 1)
            {
                value = min;
            }
            return value++;
        };
    }
    static Func<int> CreateResettableCounter()
    {

    }
}
