using System.Text;
using System;
using Microsoft.Extensions.DependencyInjection;
using System;
using NetAtlas.Data.Sqlite;
using NetAtlas.Core;
using NetAtlas.Core.Models;

class Program
{
    static async Task Main(string[] args)
    {
        // Configuration du conteneur de services
        var services = new ServiceCollection();
        services.AddSingleton<AtlasDatabase>();
        services.AddSingleton<IUnitOfWork, UnitOfWork>();




        // Construction du fournisseur de services
        var serviceProvider = services.BuildServiceProvider();

        // Utilisation du fournisseur pour obtenir des instances
        var atlasDatabase = serviceProvider.GetService<AtlasDatabase>();
        var _unit = serviceProvider.GetService<IUnitOfWork>();
     
        await atlasDatabase.Init();

        var collection = new Collection()
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Test",
            Singleton = false

        };

        await _unit.Collections.SaveAsync(collection);


        // Votre logique d'application ici
    }
}

