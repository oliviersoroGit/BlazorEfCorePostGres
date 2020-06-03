# BLAZOR - Faire un CRUD en utilisant Entity Framework Core et une bd PostGreSQL
_(juste en dessous des badges sympatiques à placer)_

## Prérequis

- .Net Core 3.1 SDK 
- VS 2019 
- PostGre Sql


## Introduction à BLAZOR
Les développeurs web .Net ont très souvent recours à JavaScript afin de réaliser des interfaces utilisateurs riches, rapides et interactives. En effet les technologies JavaScript sont beaucoup utilisées pour gérer les appels asynchrones, faire des animations, rafraichir une partie de la page sans la recharger complètement et plein d’autres choses qui peuvent s’avérer très utile pour les utilisateurs. 

Et ben Blazor est un Framework permettant de créer des applications web interactives en utilisant C# au lieu de JavaScript. Il devient alors possible pour un développeur C# d’utiliser un seul langage pour écrire la partie Client et la partie Serveur d’une application web. 

Blazor vient avec deux modèles différents : Blazor Server et Blazor Web Assembly.

Nous utiliserons Blazor Server dans cet exemple.


## Connexion à la bd PostgreSQL
Pour gérer les échanges avec la base de données nous allons utiliser EF Core.  

Etape 1: Installer Entity Framework CLI tool afin de pouvoir utiliser les commandes EF Core dans la ligne de commande. 

Pour cela nous devons exécuter la commande suivante dans la console de gestionnaire de package:  
```bash
dotnet tool install --global dotnet-ef 
```
Une fois installé, il ne sera plus nécessaire d’exécuter cette commande à nouveau pour utiliser les commandes EF Core dans d’autres projets sur le même ordinateur.  

Etape 2: Installer la bibliothèque EFCore pour PostGreSQL : 
```bash
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -Version 3.1.4 
```

## Migration en base de données
Afin de migrer notre modèle de données dans la base de données nous devons installer le package EntityFrameworkCore.Design 
```bash
Install-Package Microsoft.EntityFrameworkCore.Design -Version 3.1.4 
```
Nous pouvons maintenant appliquer la première migration en exécutant ces deux commandes: 
```bash
dotnet ef migrations add InitialCreate --project DemoBlazorServerApp
dotnet ef database update --project DemoBlazorServerApp 
```

Nous sommes désormais capables d’effectuer toutes les opérations de CRUD avec la bd PostGreSQL. 

## Le modèle de données
```csharp
    public class Meal
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Le nom du plat est trop long.")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Le montant doit etre compris entre 1 et 200 $")]
        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }
    }
```

## Le contexte de données
```csharp
    public class DemoBlazorServerAppContext : DbContext 

    { 
        public virtual DbSet<Meal> Meals { get; set; } 
        public DemoBlazorServerAppContext(DbContextOptions<DemoBlazorServerAppContext> options) : base(options) { } 
        protected override void OnModelCreating(ModelBuilder builder) 

        { 
            base.OnModelCreating(builder); 
        } 
    } 
```

## Les pop-ups avec BlazoredModal
Etape 1: installer le package BlazoredModal 
```bash
Install-Package Blazored.Modal 
```
 
Etape 2: Inscr
La version ire le service BlazoredModal dans le startup.cs
finale de la méthode ConfigureServices de la classe startup.cs devrait être:
```csharp
       public void ConfigureServices(IServiceCollection services) 

        { 

            services.AddRazorPages(); 

            services.AddServerSideBlazor(); 

            services.AddSingleton<WeatherForecastService>(); 

            services.AddScoped<IMealService, MealService>(); 

            services.AddDbContext<DemoBlazorServerAppContext>( 

            option => option.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))); 

            services.AddBlazoredModal(); 

        } 
```

