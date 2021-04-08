using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBreeders.Models {

   /// <summary>
   /// Breed of dogs
   /// </summary>
   public class Breeds {

      public Breeds() {
         // initialize the list of Dogs that has the Breed
         Dogs = new HashSet<Dogs>();
      }


      /// <summary>
      /// name of the breed
      /// </summary>
      public string Name { get; set; }

      //******************************************************************
      // a Breed can be assigned to many Dogs
      //******************************************************************
      /// <summary>
      /// list of Dogs that has this Breed
      /// </summary>
      public ICollection<Dogs> Dogs { get; set; }
      //******************************************************************

   }
}
