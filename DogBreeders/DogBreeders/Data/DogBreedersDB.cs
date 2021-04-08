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



      // connect our classes with the DataBase
      public DbSet<Dogs> Dogs { get; set; }
      public DbSet<DogBreeder> DogBreeders { get; set; }
      public DbSet<DogBreederDogs> DogBreedersDogs { get; set; }
      public DbSet<Photos> Photos { get; set; }
      public DbSet<Breeds> Breeds { get; set; }

   }
}
