using System;

class Program01
{
    // delegate型を宣言
    public delegate void Delegate();

    static void main(string[] args)
    {
        // Delegate型の変数に関数を代入
        Delegate deligade_obj = Func;

        // Delegate型の変数に関数が代入されているので、Func関数が実行される
        deligade_obj();

        Console.ReadLine();
    }

    static void Func()
    { 
        Console.WriteLine("Hello World");
    }
}


