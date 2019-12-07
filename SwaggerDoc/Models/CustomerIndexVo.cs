using SwaggerDoc.CustomAttributes.Swagger;
using System.Collections.Generic;

namespace SwaggerDoc.Models
{
   public class CustomerIndexVo
   {
      /// <summary>
      /// Customer id
      /// </summary>
      public int Id { get; set; }
      /// <summary>
      /// Customer name
      /// </summary>
      public string Name { get; set; }
      [SwaggerExclude]
      public string APICode { get; set; }
      /// <summary>
      /// List
      /// </summary>
      public IList<CustomerShowVo> List { get; set; }
   }
}