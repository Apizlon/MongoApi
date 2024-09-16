using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyBookApp.Core.Models;

/// <summary>
/// Класс сущности Книга
/// </summary>
public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.Int32)]
    public int Id { get; set; }
    
    [BsonElement("name")]
    public string Name { get; set; }
    
    [BsonElement("description")]
    public string Description { get; set; }
    
    [BsonElement("author")]
    public string Author { get; set; }
}