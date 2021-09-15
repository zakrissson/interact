using System;

//Genomgång
// string name = "6";
// Console.WriteLine(name + name);

//bool isAlive = true;

//Console.WriteLine("Vad heter du?");
//string name = Console.ReadLine();

//name = name.ToLower();

//if (name == "ronja")
//{
  //  Console.WriteLine("Welcome!");
//}
//else if (name == "albert")
//{
  //  Console.WriteLine("Almost as welcome but not quite.");
//}
//else
//{
  //  Console.WriteLine("NO");
//}

//Console.ReadLine();

string question;
string question2;
string question3;

Console.WriteLine("You come across a fucktard. Talk to him?");
Console.WriteLine("(Yes/No)");
question=Console.ReadLine();

if (question == "yes")
{
    Console.WriteLine("He ends your life.");
    Console.WriteLine("Must suck to be you.");
    Console.ReadLine();
}

if (question == "no")
{
    Console.WriteLine("You walk away, but hes following you.");
    Console.WriteLine("Confront him? (Yes/No)");
    question2=Console.ReadLine();

    if (question2 == "yes")
    {
      Console.WriteLine("He bashes your head.");
      Console.WriteLine("I don't even feel remorse for you, stupid fuck.");
      Console.ReadLine();
    }

    if (question2 == "no")
    {
      Console.WriteLine("He starts running. and catches up to you.");
      Console.WriteLine("Punch? Yes/No");
      question3=Console.ReadLine();
  
    if (question3 == "yes")
    {
      Console.WriteLine("You uppercut his chin.");
      Console.WriteLine("Make sure to run before the cops arrive, they won't believe you.");
      Console.ReadLine();
    }

  if (question3 == "no")
  {
    Console.WriteLine("He stabs your gut and you succumb to your injuries.");
    Console.WriteLine("Too bad.");
    Console.ReadLine();
  }
    }
}