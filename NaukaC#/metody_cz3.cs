/*string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N5} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price = 67.55m;
decimal salePrice = 59,99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
Console.WriteLine(yourDiscount);

int invoiceNumber = 1201;
decimal productShares = 25.46m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"   Subtotal: {subtotal:C}");
Console.WriteLine($"       Tax: {taxPercentage:P2}");
Console.WriteLine($"   Total Billed: {total:C}");

string input = "Pad this text";
Console.WriteLine(input.PadLeft(20));
Console.WriteLine(input.PadRight(20));
Console.WriteLine(input.PadLeft(20, '-'));
Console.WriteLine(input.PadRight(20, '-'));
*/
string paymentID = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";
var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine(formattedLine);
