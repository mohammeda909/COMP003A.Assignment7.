// Author:  mohammed ali
// Course: comp003al01
// Purpose: count chracter in string
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Array - CharacterCounter Section
        Console.WriteLine("Array - CharacterCounter Section");
        Console.Write("Enter a single letter: ");
        char characterInput = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        Console.Write("Enter a word: ");
        string word = Console.ReadLine().ToLower();
        int count = CharacterCounter(characterInput, word);
        Console.WriteLine($"The character '{characterInput}' appears in the word '{word}' {count} times.");
        Console.WriteLine();

        // Array - IsPalindrome Section
        Console.WriteLine("Array - IsPalindrome Section");
        Console.Write("Enter a word: ");
        string inputWord = Console.ReadLine().ToLower();
        bool isPalindrome = IsPalindrome(inputWord);
        Console.WriteLine($"The word '{inputWord}' is {(isPalindrome ? "a palindrome" : "not a palindrome")}.");
        Console.WriteLine();

        // List - Add Section
        List<string> names = new List<string>();
        char userInput;
        do
        {
            Console.Write("Enter a name to add: ");
            string name = Console.ReadLine();
            names.Add(name);
            Console.Write("Press any key to add more or (e) to exit: ");
            userInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (userInput != 'e');

        // List - Traversal Section
        Console.WriteLine("List - Traversal Section");
        TraverseList(names);
        Console.WriteLine();

        // List - Reverse Traversal Section
        Console.WriteLine("List - Reverse Traversal Section");
        TraverseListReverse(names);
    }

    static int CharacterCounter(char characterInput, string word)
    {
        int count = 0;
        foreach (char c in word)
        {
            if (c == characterInput)
            {
                count++;
            }
        }
        return count;
    }

    static bool IsPalindrome(string word)
    {
        string reversedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
    }

    static void TraverseList(List<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void TraverseListReverse(List<string> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }
    }
}
