string str1 = "cast";
string str2 = "name";
Console.WriteLine($"{str1},{str2},");
Console.WriteLine($"resul  sriram  sri ram");

decimal price = 50.12m;
decimal discount = 43.43m;
String result = string.Format("Price is {0:c} and discount is {1:c}",(price - discount), price);
Console.WriteLine($"Result is {result}");   

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");

string str1= "madmax";
Console.WriteLine(str1.PadRight(30,'*'));
Console.WriteLine(str1.PadLeft(30,'*'));

string message = ("I'm a C# developer(I will work on backend)");
int opening = message.IndexOf('(');
int closing = message.IndexOf(')');
opening += 6;   
int length = closing  -  opening ; 
Console.WriteLine(message.Substring(opening ,length));

string message = "What <div> the value <span>between the tags</span>?";
const string openTag = "<div>";  
const string closeTag = "</span>";
int openingPosition = message.IndexOf(openTag);
int closingPosition = message.IndexOf(closeTag);

openingPosition += openTag.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

string maddy = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = maddy.LastIndexOf('(');

openingPosition += 1;
int closingPosition = maddy.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(maddy.Substring(openingPosition, length));

string str1 = "(What if) there are (more than) one (set of parentheses)?";
while(true)
{
       int openingposition = str1.IndexOf ("(");
       if(openingposition == -1)
       {
           break;
       }
       openingposition += 1;
       int closingposition = str1.IndexOf(")");
       int length = closingposition - openingposition;
       Console.WriteLine(str1.Substring(openingposition, length));

       str1 = str1.Substring(closingposition + 1);
}

string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");