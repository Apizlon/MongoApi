using MongoDB.Driver;
using MyBookApp.Core.Models;
using MyBookApp.DataAccess.Interfaces;

namespace MyBookApp.DataAccess.Repositories;

public class MongoRepository : IBookRepository
{
    private readonly IMongoCollection<Book> _books;

    public MongoRepository(IMongoDatabase database)
    {
        _books = database.GetCollection<Book>("Books");
    }

    public async Task<int> AddBookAsync(Book book)
    {
        await _books.InsertOneAsync(book);
        return book.Id; // Можно использовать другой способ для генерации уникального Id
    }

    public async Task DeleteBookAsync(int id)
    {
        await _books.DeleteOneAsync(book => book.Id == id);
    }

    public async Task<Book> GetBookAsync(int id)
    {
        return await _books.Find(book => book.Id == id).FirstOrDefaultAsync();
    }

    public async Task UpdateBookAsync(int id, Book book)
    {
        await _books.ReplaceOneAsync(b => b.Id == id, book);
    }

    public async Task<bool> BookExistsAsync(int id)
    {
        var book = await _books.Find(b => b.Id == id).FirstOrDefaultAsync();
        return book != null;
    }
    
    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        var books = _books.Find(Builders<Book>.Filter.Empty).ToEnumerable();
        return books;
    }
}