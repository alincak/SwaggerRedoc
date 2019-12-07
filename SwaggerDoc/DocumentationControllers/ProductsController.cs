using SwaggerDoc.Models;
using SwaggerDoc.Models.Swagger;
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
      public ProductGetResponseVo Get(int id)
      {
         return new ProductGetResponseVo();
      }

      [HttpPost]
      public BaseIdSuccessVo Edit(ProductEditVo model)
      {
         return new BaseIdSuccessVo();
      }

      [HttpDelete]
      public BaseIdSuccessVo Delete(int id)
      {
         return new BaseIdSuccessVo();
      }
   }

}
