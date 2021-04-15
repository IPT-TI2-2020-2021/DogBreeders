using DogBreeders.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBreeders.Data {
   /// <summary>
   /// Data Base of our project
   /// </summary>
   public class DogBreedersDB : DbContext {

      /*
       * 1 - what is the engine of database: MySQL, SQL Server, Oracle, ???? -> startup.cs file
       * 2 - where is the database file stored?                              -> appsettings.json file
      */ 

      /// <summary>
      /// constructer that formats the DB connection
      /// </summary>
      /// <param name="options">parameters needed to format the database connection</param>
      public DogBreedersDB(DbContextOptions<DogBreedersDB> options):base(options) { }


      // connect our classes with the DataBase
      // these attributes represents the tables in the database
      public DbSet<Dogs> Dogs { get; set; }
      public DbSet<DogBreeder> DogBreeders { get; set; }
      public DbSet<DogBreederDogs> DogBreedersDogs { get; set; }
      public DbSet<Photos> Photos { get; set; }
      public DbSet<Breeds> Breeds { get; set; }

   }
}
