using Less12_Exceptions;

Console.WriteLine("Enter login");
var log = Console.ReadLine();

Console.WriteLine("Enter password");
var pass = Console.ReadLine();

Console.WriteLine("Confirm Password");
var conf = Console.ReadLine();

bool sign = SignUp.Sign(log, pass, conf);
if (sign == true)
{
    Console.WriteLine("The user has been authorized");
}
