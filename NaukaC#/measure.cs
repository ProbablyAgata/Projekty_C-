﻿/*
int first = 2;
string second = "4";
int result = first + second;

Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"Int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"Decimal: {myDecimal}");


decimal myDecimal = 3.14m;
int myInt = (int)myDecimal;
Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Int: {myInt}");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

int value = (int)1.5m;
Console.WriteLine(value);
int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2);

string name = "Bob";
Console.WriteLine(int.Parse(name));

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/