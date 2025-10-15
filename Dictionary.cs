











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
