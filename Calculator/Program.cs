using Calculator;

Console.WriteLine(new Sum(5.2, 1.5).ToResult());
Console.WriteLine(new Division(30, new Sum(2, 3)).ToResult());
Console.WriteLine(new Faculty(4).ToResult());
Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).ToResult());
Console.WriteLine();

Console.WriteLine(new Sum(5.2, 1.5).Print());
Console.WriteLine(new Division(30, new Sum(2, 3)).Print());
Console.WriteLine(new Faculty(4).Print());
Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).Print());
Console.WriteLine();

Console.WriteLine(new Sum(5.2, 1.5).PrintSentence());
Console.WriteLine(new Division(30, new Sum(2, 3)).PrintSentence());
Console.WriteLine(new Faculty(4).PrintSentence());
Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).PrintSentence());

Console.ReadKey();
