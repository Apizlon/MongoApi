using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace MyBookApp.DataAccess.Mongo;

public static class MongoExtension
{
    /*public static IServiceCollection MigrateDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));
        services.AddSingleton<IMongoClient>(sp =>
            new MongoClient(configuration.GetValue<string>("MongoDbSettings:ConnectionString")));
        services.AddScoped<IMongoDatabase>(sp =>
            sp.GetRequiredService<IMongoClient>().GetDatabase(configuration.GetValue<string>("MongoDbSettings:DatabaseName")));
        return services;
    }*/
}