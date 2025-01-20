/*string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");
openingPosition += 6;
Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);
int lenght = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, lenght));
*/
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

