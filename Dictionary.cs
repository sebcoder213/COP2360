// Populate the dictionary and display dictionary contents - Reese German
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static Dictionary<int, string> customDictionary = new Dictionary<int, string>();

    static void Main()
    {
        customDictionary.Add(1, "Apple");
        customDictionary.Add(2, "Banana");
        customDictionary.Add(3, "Cherry");
        customDictionary.Add(4, "Date");

        Console.WriteLine("Current Dictionary Contents (using foreach enumeration):");
        foreach (KeyValuePair<int, string> entry in customDictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

  // Remove an entry from the dictionary -Corrinne Whitt
    static void RemoveCustomKey()
    {
        Console.WriteLine("Enter custom entry to remove.");
        string keyToRemove = Console.ReadLine();

        if (customDictionary.Remove(keyToRemove))
        {
            Console.WriteLine($"Key '{keyToRemove}' removed successfully.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToRemove}' not found in the dictionary.");
        }
    }
    // Add a new entry to the dictionary -Corrinne Whitt
    static void AddNewCustomKey()
    {
        Console.WriteLine("Enter new custom key:");
        string newKey = Console.ReadLine();

        if (customDictionary.ContainsKey(newKey))
        {
            Console.WriteLine("Key already exists. Try a different key.");
            return;
        }

        Console.Write("Enter description for the input: ");
        string newValue = Console.ReadLine();

        customDictionary[newKey] = newValue;
        Console.WriteLine($"Added key '{newKey}' with value '{newValue}'.");
    }

// e. Add a Value to an Existing Key: Append a new value to an existing key. Done by Samuel Lobl
//Appending " pie" to the end of "Apple"
customDictionary[1] += " pie";

foreach (string keyInt in customDictionary.Values)
{
    Console.WriteLine(keyInt);
}

//f.Sort the Keys: Sort the keys in the dictionary. Done by Samuel Lobl
Console.WriteLine("\nSorted Keys:");
foreach (int key in customDictionary.Keys.OrderBy(k => k))
{
    Console.WriteLine($"{key}: {string.Join(", ", customDictionary[key])}");
}
