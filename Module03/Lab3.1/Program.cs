/*
 * Mad Libs is a game that has been around since the 50s
 * It consists of a passage of text in which certain words are left intentionally blank
 * These blanks are then filled by randomly chosen words that correspond to the part of speech (verb, adjective, noun) being replaced
 * The results are often hilariously disjointed spins on the original context of the passage
 * 
 * These blank spaces are a perfect metaphor for one of the most common ways we use variables in programming
 * We keep a space open within our program for a value we cannot predict at compile time
 * In order to make sure the information we store in our variable is consistent, we assign a type to the variable
 * This is much like the part of speech rule you find in Mad Libs
 * 
 * For this lab, we will be using the Mad Libs format to practice creating variables, assigning values to them, and then referencing them at runtime
 * We will also learn a couple different methods for including variables within Strings
 * These will be: 
 *  *Concatentation - Appending or prepending strings or values to the string
 *  *Interpolation - Using tags to insert values directly into a string
 */

#region Concatenation
// Contatenation can be thought of as adding two strings together
// Strings in C# are immutable
// This means they cannot be changed after they are created
// What this looks like practically is that every operation to change a string results in a new string being created in memory
// This won't mean or affect much for you right now, but its important to understand that changing a string always creates a new one

// Here we are declaring all the variables we're going to be using
string adjective1;
string properNoun;
string adjective2;
string bodyPart1;
string color;
string bodyPart2;
string adjective3;

// Here we go through the cycle of prompting the user for input
Console.WriteLine("Please enter an adjective");
adjective1 = Console.ReadLine();
Console.WriteLine("Please enter a proper noun");
properNoun = Console.ReadLine();
Console.WriteLine("Please enter an adjective");
adjective2 = Console.ReadLine();
Console.WriteLine("Please enter a body part");
bodyPart1 = Console.ReadLine();
Console.WriteLine("Please enter a color");
color = Console.ReadLine();
Console.WriteLine("Please enter a body part");
bodyPart2 = Console.ReadLine();
Console.WriteLine("Please enter an adjective that rhymes with your color");
adjective3 = Console.ReadLine();

// Here we concatenate the string
string puzzleOne = "'You are " + adjective1 + ", Father " + properNoun + "' the " + adjective2 + " man said 'And your " + bodyPart1 + " has become very " + color + ". And yet you incessantly stand on your " + bodyPart2 + ", do you think at your age it is " + adjective3 + "?'";

// Here we print the finished string
Console.WriteLine("\n\n" + puzzleOne);
#endregion
#region Interpolation
// Interpolation is the practice of insterting new data into a string at a specific point or points
// To do this, we can feed placeholders {} into the string to let the string know we'll be throwing some data in
// Two ways to do this are to simply insert the variable name you wish to use:
//  string name = "Burke"
//  Console.WriteLine($"My name is {name}"); You must use the formatting character $ when inserting variables this way
// Or you can tell your string how many spots you want to fill and where, and pass them afterwards:
//  string name = "Burke"
//  Console.WriteLine("My name is {0}", name);
// The number we put inside of the {} is called an index
// We start at 0 and count up for each additional variable or parameter we are passing
// Unlike humans, computers always count from 0 unless you explicityly tell them otherwise

// We are going to reuse the same puzzle and input for this next part
// In your own lab, I want you to use two different puzzles with different user input
// The purpose of using the same here is to show you how much more simple and readable interpolation can be
// In most circumstances, interpolation will be preferred
Console.WriteLine($"\n\n'You are {adjective1}, Father {properNoun}' the {adjective2} man said 'And your {bodyPart1} has become very {color}. And yet you incessantly stand on your {bodyPart2}, do you think at your age it is {adjective3}?");
#endregion