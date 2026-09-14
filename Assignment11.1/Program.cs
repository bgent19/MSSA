using var db = new BookContext();

// Note: This sample requires the database to be created before running.
db.Database.EnsureCreated();
Console.WriteLine("Database created or already exists.\n");

// CREATE - Add new books to the database
Console.WriteLine("=== CREATE Operations ===");
var book1 = new Book
{
    Isbn = "978-0-134-68599-1",
    Title = "Effective C#",
    FirstAuthor = "Bill Wagner",
    Description = "A comprehensive guide to writing better C# code."
};

var book2 = new Book
{
    Isbn = "978-0-596-00797-3",
    Title = "Learning C#",
    FirstAuthor = "Jesse Liberty",
    Description = "An introductory guide to learning C#."
};

// Only insert books that don't already exist so the program can be run repeatedly.
foreach (var newBook in new[] { book1, book2 })
{
    if (db.Books.Any(b => b.Isbn == newBook.Isbn))
    {
        Console.WriteLine($"- Skipped (already exists): '{newBook.Title}' by {newBook.FirstAuthor}");
    }
    else
    {
        db.Books.Add(newBook);
        Console.WriteLine($"✓ Created: '{newBook.Title}' by {newBook.FirstAuthor}");
    }
}
db.SaveChanges();
Console.WriteLine();

// READ - Retrieve all books
Console.WriteLine("=== READ Operations ===");
var allBooks = db.Books.ToList();
Console.WriteLine($"All Books in Database ({allBooks.Count} total):");
foreach (var book in allBooks)
{
    Console.WriteLine($"  ISBN: {book.Isbn}, Title: {book.Title}, Author: {book.FirstAuthor}");
}
Console.WriteLine();

// READ - Find specific book by ISBN
var bookToFind = db.Books.FirstOrDefault(b => b.Isbn == "978-0-134-68599-1");
if (bookToFind != null)
{
    Console.WriteLine($"✓ Found Book by ISBN: '{bookToFind.Title}'");
    Console.WriteLine($"  Author: {bookToFind.FirstAuthor}");
    Console.WriteLine($"  Description: {bookToFind.Description}\n");
}

// UPDATE - Modify a book's description
Console.WriteLine("=== UPDATE Operations ===");
if (bookToFind != null)
{
    bookToFind.Description = "Updated: A modern approach to writing better C# code with latest features.";
    db.SaveChanges();
    Console.WriteLine($"✓ Updated: '{bookToFind.Title}'");
    Console.WriteLine($"  New Description: {bookToFind.Description}\n");
}

// DELETE - Remove a book
Console.WriteLine("=== DELETE Operations ===");
var bookToDelete = db.Books.FirstOrDefault(b => b.Isbn == "978-0-596-00797-3");
if (bookToDelete != null)
{
    Console.WriteLine($"✓ Deleting: '{bookToDelete.Title}'");
    db.Books.Remove(bookToDelete);
    db.SaveChanges();
    Console.WriteLine($"✓ Successfully deleted: '{bookToDelete.Title}'\n");
}

// FINAL READ - Show remaining books
Console.WriteLine("=== Final Database State ===");
var finalBooks = db.Books.ToList();
Console.WriteLine($"Total Books Remaining: {finalBooks.Count}");
foreach (var book in finalBooks)
{
    Console.WriteLine($"  ISBN: {book.Isbn}, Title: {book.Title}, Author: {book.FirstAuthor}");
}
Console.WriteLine("\n✓ All CRUD operations completed successfully!");
