using System;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable;

public class Book
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Price { get; set; }

    public Book(string title, string genre, int price)
    {
        Title = title;
        Genre = genre;
        Price = price;
    }
    public override string ToString() => $"{Title} ({Genre} - ({Price}$))";
}
public class Library : IEnumerable<Book>
{
    private readonly List<Book>? books = new();

    public void Add(Book book)
    {
        books?.Add(book);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        foreach (var item in books)
        {
            yield return item;
        }
    }
    IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<Book> GetByGenre(string genre)
    {
        foreach (var item in books)
        {
            if(item.Genre == genre){
                yield return item;
            }
            else
            {
                Console.WriteLine("Not this genre");
                break;
            }
        }
    }
    public IEnumerable<Book> GetExpensive(int minPrice)
    {
        foreach (var item in books)
        {
            if(item.Price >= minPrice) yield return item;
        }
    }

}
