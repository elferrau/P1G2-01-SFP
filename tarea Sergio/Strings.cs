//strings
string greeting = "Hello";

string greeting2 = "Nice to meet you!";

string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"

//Concatenation
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);

string firstName = "John ";
string lastName = "Doe";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name);

int x = 10;
int y = 20;
int z = x + y;  // z will be 30 (an integer/number)

string x = "10";
string y = "20";
string z = x + y;  // z will be 1020 (a string)

//Interpolation
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

//Access
string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"

string myString = "Hello";
Console.WriteLine(myString[1]);  // Outputs "e"

string myString = "Hello";
Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

// Full name
string name = "John Doe";

// Location of the letter D
int charPos = name.IndexOf("D");

// Get last name
string lastName = name.Substring(charPos);

// Print the result
Console.WriteLine(lastName);

//Special Characters
string txt = "We are the so-called "Vikings" from the north.";

string txt = "We are the so-called \"Vikings\" from the north.";

string txt = "It\'s alright.";

string txt = "The character \\ is called backslash.";

