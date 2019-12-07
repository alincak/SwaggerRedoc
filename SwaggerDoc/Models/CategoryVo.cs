namespace SwaggerDoc.Models
{
   public class CategoryVo
   {
      public CategoryVo()
      {
         DefaultTest = 15;
      }

      public int Id { get; set; }
      public string Name { get; set; }
      public int? ParentId { get; set; }
      public double DefaultTest { get; set; }
   }
}