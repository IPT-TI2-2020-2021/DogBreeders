using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBreeders.Models {

   /// <summary>
   /// represents the owners of dogs
   /// </summary>
   public class DogBreeder {

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

   }
}
