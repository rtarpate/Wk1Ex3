

Console.WriteLine("What is the principal amount of the laon in united states dollars?");

int principal = int.Parse(Console.ReadLine());

Console.WriteLine("What is the interest rate of the lona (input as decmial 00.5 for 5%)?");

double interestrate = double.Parse(Console.ReadLine());


Console.WriteLine("What is the period/lenght of the loan in years");

int period = int.Parse(Console.ReadLine());

Console.WriteLine(" Total interest of the Loan: " + principal*interestrate*period + " USD. ");