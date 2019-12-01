using SwaggerDoc.Models;
using System.Web.Http;

namespace SwaggerDoc.DocumentationControllers
{
   public class ProductsController : ApiController
   {
      public ProductShowVo Get(int id)
      {
         return new ProductShowVo();
      }
   }

}
