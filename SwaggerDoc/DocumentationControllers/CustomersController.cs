using SwaggerDoc.Models;
using SwaggerDoc.Models.Swagger;
using Swashbuckle.Swagger.Annotations;
using System.Web.Http;

namespace SwaggerDoc.DocumentationControllers
{
   public class CustomersController : ApiController
   {
      /// <summary>
      /// Listing
      /// </summary>
      /// <remarks>
      /// list of objects
      /// </remarks>
      /// <param name="page"></param>
      /// <param name="pageSize"></param>
      /// <param name="fid">N: The ID of a filter defined for this user
      ///<br/>0 – test1
      ///<br/>1 – test2
      ///<br/>2 – test3
      /// </param>
      [HttpGet]
      [Route("v1/Customers/Index")]
      public CustomerIndexVo Index(int? fid, int page = 1, int pageSize = 25)
      {
         return new CustomerIndexVo();
      }

      [HttpGet]
      [SwaggerResponse(System.Net.HttpStatusCode.NotFound, "Customer not found or no access", typeof(ErrorMessageVo))]
      public CustomerGetResponseVo Get(int id)
      {
         return new CustomerGetResponseVo();
      }

      [HttpPost]
      public BaseIdSuccessVo Edit(CustomerEditVo model)
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
