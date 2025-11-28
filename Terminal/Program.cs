using Library;

var calculator = new Calculator();

var a = calculator.Addition(1, 2);
var b = calculator.Subtraction(3, 1);
var c = calculator.Multiplication(2, 3);
var d = calculator.Division(10, 2);
var e = calculator.DivisionRest(5, 2);
var f = calculator.DivisionRest(7, 2);
var g = calculator.DivisionRest(9, 8);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
