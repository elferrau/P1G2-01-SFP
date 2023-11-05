//if
if (condition) 
{
  // block of code to be executed if the condition is True
}

if (20 > 18) 
{
  Console.WriteLine("20 is greater than 18");
}

int x = 20;
int y = 18;
if (x > y) 
{
  Console.WriteLine("x is greater than y");
}

//else
if (condition)
{
  // block of code to be executed if the condition is True
} 
else 
{
  // block of code to be executed if the condition is False
}

int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."

//else if
if (condition1)
{
  // block of code to be executed if condition1 is True
} 
else if (condition2) 
{
  // block of code to be executed if the condition1 is false and condition2 is True
} 
else
{
  // block of code to be executed if the condition1 is false and condition2 is False
}

int time = 22;
if (time < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."

// Short Hand If...Else
variable = (condition) ? expressionTrue :  expressionFalse;

int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);

