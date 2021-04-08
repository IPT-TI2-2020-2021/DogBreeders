using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBreeders.Models {

   /// <summary>
   /// Photos of the dogs
   /// </summary>
   public class Photos {

      /// <summary>
      /// name of file that has the photo of dog 
      /// </summary>
      public string  NameOfPhoto { get; set; }

      /// <summary>
      /// date of photo
      /// </summary>
      public DateTime Date { get; set; }

      /// <summary>
      /// place where the photo was taken
      /// </summary>
      public string Local { get; set; }




   }
}
