string pangram = "The quick brown fox jumps over the lazy dog";
string[] reversed = pangram.Split(' ');
string[] newmessage = new string[reversed.Length];
for (int i = 0; i < reversed.Length; i++)
{
   char[] letters = reversed[i].ToCharArray();
   Array.Reverse(letters);
   newmessage[i] = new string(letters);
}
string result = string.Join(" ", newmessage);
Console.WriteLine(result);



string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] text = orderStream.Split(',');
Array.Sort(text);
foreach(var item in text)
{
    Console.WriteLine(item);
}

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}