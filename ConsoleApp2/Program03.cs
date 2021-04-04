using System;

class Program03
{
    // delegate型を宣言
    public delegate void Callback();

    static void main(string[] args)
    {
        //Callback deligade_obj = SayHowAreYou;
        Callback deligade_obj = SayWhatsUp;
        SaySomethingAfterHello(deligade_obj);

        Console.WriteLine("****deligateに2つメソッドを代入****");
        Callback deligade_obj2 = SayHowAreYou;
        deligade_obj2 += SayWhatsUp;
        SaySomethingAfterHello(deligade_obj2);

        Console.ReadLine();
    }

    static void SayHowAreYou() 
    {
        Console.WriteLine("How are you?");
    }

    static void SayWhatsUp() 
    {
        Console.WriteLine("What's up?");
    }
    static void SaySomethingAfterHello(Callback callback) 
    {
        Console.WriteLine("Hello!!");
        callback();
    }
}


