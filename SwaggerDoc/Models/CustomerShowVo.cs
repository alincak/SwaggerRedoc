namespace SwaggerDoc.Models
{
   public class CustomerShowVo
   {
      public CustomerShowVo()
      {
         Balance = 15;
      }

      public int Id { get; set; }
      public string Name { get; set; }
      public int? StageId { get; set; }
      public CustomerBaseType CustomerType { get; set; }
      public double Balance { get; set; }

      public enum CustomerBaseType
      { 
         Individual = 0,
         Company = 1
      }
   }
}