// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello");

string nameBook;
string authorBook;
int yearOfPublicationBook;
string ISBN;

Console.Write("Напишите название книги: ");
nameBook = Console.ReadLine();
Console.Write("Напишите автора книги: ");
authorBook = Console.ReadLine();
Console.Write("Напишите год издания книги: ");
yearOfPublicationBook = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите ISBN книги: ");
ISBN = Console.ReadLine();
if (ISBN.Length > 13)
{
    Console.WriteLine("Ошибка: ISBN не может быть больше 13 цифр.");
} else if (!ISBN.All(char.IsDigit))
{
    Console.WriteLine("Ошибка: ISBN должен содержать только цифры.");
}

Console.WriteLine($"Название книги: {nameBook}.\nАвтор книги: {authorBook}.\nГод выпуска книги: {yearOfPublicationBook}.\nISBN книги: {ISBN}.");

/// aaswaeds
/// sccsd