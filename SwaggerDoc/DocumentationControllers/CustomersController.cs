using SwaggerDoc.Models;
using System.Web.Http;

namespace SwaggerDoc.DocumentationControllers
{
   public class CustomersController : ApiController
   {
      [HttpGet]
      public CustomerIndexVo Index(int? fid, int page = 1, int pageSize = 25)
      {
         return new CustomerIndexVo();
      }

      [HttpGet]
      public CustomerShowVo Get(int id)
      {
         return new CustomerShowVo();
      }

      [HttpPost]
      public BaseIdSuccessVo Edit(CustomerEditVo model)
      {
         return new BaseIdSuccessVo();
      }
   }

}
