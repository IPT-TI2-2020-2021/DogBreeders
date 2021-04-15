using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogBreeders.Models {

   /// <summary>
   /// represents the owners of dogs
   /// </summary>
   public class DogBreeder {

      public DogBreeder() {
         Dogs = new HashSet<DogBreederDogs>();
      }

      /// <summary>
      /// Primary Key (PK) of table DogBreeds
      /// </summary>
      [Key]
      public int Id { get; set; }

      /// <summary>
      /// name of dog breeder
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Address
      /// </summary>
      public string Address { get; set; }

      /// <summary>
      /// Postal code of dog breeder's address
      /// </summary>
      public string PostalCode { get; set; }

      /// <summary>
      /// Email
      /// </summary>
      public string Email { get; set; }

      /// <summary>
      /// cell phone
      /// </summary>
      public string CellPhone { get; set; }


      //**********************************************************
      // List of DogBreedersDogs
      //**********************************************************
      /// <summary>
      /// represents the list of Dogs that the dog breeder has
      /// </summary>
      public ICollection<DogBreederDogs> Dogs { get; set; }
      //**********************************************************


   }
}
