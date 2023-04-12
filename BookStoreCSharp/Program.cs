// See https://aka.ms/new-console-template for more information
Console.WriteLine("Book Store");

// Book date from Amazon.it

string title = "Simboli Esoterici - Una guida ad oltre 500 segni, simboli e icone";
string author = "Eric Chaline";
string isbn = "8834440129";
int numberPages = 256;
int weightBook = 890;
float width = 17.9f;
float height = 23.6f;
float volume = 2.5f;
int numberReviews = 31;
float reviwels = 4.5f;
string kindle = "No";
string flex = "No";

// Console write date

Console.WriteLine("-----------------------------BOOK STORE--------------------------------------");
Console.WriteLine("Title: " + title);
Console.WriteLine("Author: " + author);
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Pages: " + numberPages);
Console.WriteLine("Dimensions: " + width + " x " + height + " x " + volume + "cm. " + weightBook + " g.");
Console.WriteLine("Reviews:");
Console.WriteLine("Stars: " + reviwels);
Console.WriteLine("Total reviews: " + numberReviews);
Console.WriteLine("Kindle: " + kindle);
Console.WriteLine("Flexible cover: " + flex);
Console.WriteLine("------------------------------------------------------------------------------");