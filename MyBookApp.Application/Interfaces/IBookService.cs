﻿using MyBookApp.Application.Contracts;
using MyBookApp.Core.Models;

namespace MyBookApp.Application.Interfaces;

public interface IBookService
{
    Task<int> AddBookAsync(BookRequest bookRequest);
    Task DeleteBookAsync(int id);
    Task<BookResponse> GetBookAsync(int id);
    Task UpdateBookAsync(int id, BookRequest bookRequest);
    Task<bool> BookExistsAsync(int id);
    Task<IEnumerable<Book>> GetBooksAsync();
}