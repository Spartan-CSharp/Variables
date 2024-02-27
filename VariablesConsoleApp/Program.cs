string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
bool isAlive = false;
string phoneNumber = string.Empty;

firstName = "Pierre";
lastName = "Plourde";
age = 48;
isAlive = true;
phoneNumber = "905-439-7645";

Console.WriteLine($"{firstName} {lastName} is {age} years old.");
Console.WriteLine($"Is {firstName} alive: {isAlive}");
Console.WriteLine($"{firstName}'s phone number is {phoneNumber}");
