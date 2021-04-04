using System;

class Program02
{
    // delegate型を宣言
    public delegate int Delegate(string s);

    static void main(string[] args)
    {
        // Delegate型の変数に関数を代入
        Delegate deligade_obj = CountStr;

        // Delegate型の変数を実行すると、CountStrが実行される
        Console.WriteLine(deligade_obj("Hello"));

        Console.ReadLine();
    }

    static int CountStr(string s)
    {
        return s.Length;
    }
}


