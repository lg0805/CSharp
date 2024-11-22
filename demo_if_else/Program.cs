﻿using demo_if_else;

Console.WriteLine();
foreach (var s in args)
{
    Console.Write(s);
    Console.Write(' ');
}
Console.WriteLine();

await test2.T1();

string[] answers =
{
    "It is certain.",       "Reply hazy, try again.",     "Don't count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
};

var index = new Random().Next(answers.Length - 1);
Console.WriteLine(answers[index]);

Person Alice = new Person();
Alice.Name = "Alice";
Alice.Age = 25;
Alice.SayHello();