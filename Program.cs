using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

//--------- Q1

List<String> colourList = new List<String>(){"red", "green", "blue"};

// colourList.add("pink");
// colourList.add("purple");
// colourList.add("orange");

ReadOnlyCollection<String> readOnlyColors = colourList.AsReadOnly();

//Program.cs(11,12): error CS1061: 'List<string>' does not contain a definition for 'add' and 
//no accessible extension method 'add' accepting a first argument of type 'List<string>' could be found (are you missing a using dire
//ctive or an assembly reference?)
//colourList.Add("Pink");

foreach (String colour in readOnlyColors)
{
    Console.WriteLine(colour);
}

// -----------Q2

List<int> ListOfNumbers = new List<int>(100);

for (int number = 0; number < 10; number++)
{
    ListOfNumbers.Add(number);
}

Console.WriteLine("Capacity: " + ListOfNumbers.Capacity);
Console.WriteLine("Count: " + ListOfNumbers.Count);

// -----------Q3

List<int> numbersList = new List<int>();

Random random = new Random();
for (int i = 0; i < 10; i++)
{
    int randomNumber = random.Next(100); // Generate a random number between 0 and 99
    numbersList.Add(randomNumber); // Add the random number to the list
}

int maxValue = numbersList.Max(); // Find the maximum value in the list

Console.WriteLine("Maximum value: " + maxValue);

// ----------- Q4

int[] firstArray = {1, 2, 3};
int[] secondArray = {4, 5, 6};

int[] mergedArray = firstArray.Concat(secondArray).ToArray();

foreach(int number in mergedArray)
{
    Console.Write(number);
}

// ----------- Q5

class Book  
{
    public string Title { get; set; }
    public string Author { get; set; }
}

class Program  
{
    static void Main(string[] args)
    {
        List<Book> booksList = new List<Book>();

        // Create Book objects and add them to the list  
        Book book1 = new Book { Title = "Things fall apart", Author = "Chinua Achebe" };
        Book book2 = new Book { Title = "Half of a Yellow Sun", Author = "Chimamanda Adichie" };
        Book book3 = new Book { Title = "1984", Author = "George Orwell" };

        booksList.Add(book1);
        booksList.Add(book2);
        booksList.Add(book3);

        // Print all books in the list  
        Console.WriteLine("Books List:");
        foreach (Book book in booksList)
        {
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
        }
    }
}

// ----------- Q6

int[] NumArray = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5};

Array.Sort(NumArray);
Array.Reverse(NumArray);

Console.WriteLine("The Elements in this Array are:");
foreach (int num in NumArray)
{
    Console.WriteLine(num);
}

// ----------- Q7

int[] intValues = {10, 20, 30, 40, 50};

Console.WriteLine(intValues.Length);
intValues[2] = 35;
foreach (int intValue in intValues)
{
    Console.WriteLine(intValue);
}

// ----------- Q8

List<String> frutas = new List<String>(){"apple", "banana", "cherry"};
frutas.Add("date");
frutas.Remove("banana");

bool ifFrutasContains = frutas.Contains("cherry");

Console.WriteLine(ifFrutasContains);
foreach(string fruta in frutas)
{
    Console.WriteLine(fruta);
}