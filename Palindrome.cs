using System;
using System.Collections.Generic;

class Palindrome
{
  static void Main()
  {
    Console.WriteLine("Enter a word");
    string wordInput = Console.ReadLine().ToLower();
    char [] charArray = wordInput.ToCharArray();

    Array.Reverse(charArray);

    string reversedInput = string.Join("", charArray);
    Console.WriteLine(reversedInput);

    if (reversedInput == wordInput)
    {
      Console.WriteLine("This is a palindrome!");
    }
    else
    {
      Console.WriteLine("This is not a palindrome!!!");
    }
  }
}
