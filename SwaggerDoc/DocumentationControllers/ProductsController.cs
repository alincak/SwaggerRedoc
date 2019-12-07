using SwaggerDoc.Models;
using System.Web.Http;

namespace SwaggerDoc.DocumentationControllers
{
   public class ProductsController : ApiController
   {
      [HttpGet]
      public ProductIndexVo Index(int? fid, int page = 1, int pageSize = 25)
      {
         return new ProductIndexVo();
      }

      [HttpGet]
      public ProductShowVo Get(int id)
      {
         return new ProductShowVo();
      }

      [HttpPost]
      public BaseIdSuccessVo Edit(ProductEditVo model)
      {
         return new BaseIdSuccessVo();
      }
   }

}
