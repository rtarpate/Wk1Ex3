
// gets the principal amount of the lona
Console.WriteLine("What is the principal amount of the laon in united states dollars?");

// declares the principal varibale
int principal = int.Parse(Console.ReadLine());

// gets the interest rate of the loan
Console.WriteLine("What is the interest rate of the lona (input as decmial 00.5 for 5%)?");

// decalres the interest rate varibale
double interestrate = double.Parse(Console.ReadLine());

// gets the period/lenght of the loan
Console.WriteLine("What is the period/lenght of the loan in years");

// decalres the period/lenght varibale
int period = int.Parse(Console.ReadLine());

//caluates the interest rate of the loan 
Console.WriteLine(" Total interest of the Loan: " + principal*interestrate*period + " USD. ");