using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBreeders.Models {

   /// <summary>
   /// represents the Dogs that some dog breeder has
   /// </summary>
   public class Dogs {

      /// <summary>
      /// constructor
      /// </summary>
      public Dogs() {
         // access to DB, and read all Photos that the Dog has
         Photos = new HashSet<Photos>();
      }



      /// <summary>
      /// Name of dog
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Sex of dog
      /// </summary>
      public string Sex { get; set; }

      /// <summary>
      /// Birth date of dog
      /// </summary>
      public DateTime DateOfBirth { get; set; }

      //******************************************************************
      /// <summary>
      ///  Dog has a list of Photos
      /// </summary>
      public ICollection<Photos> Photos { get; set; }
      //******************************************************************

   }
}
