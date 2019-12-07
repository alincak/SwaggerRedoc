using System;

namespace SwaggerDoc.CustomAttributes.Swagger
{
   [AttributeUsage(AttributeTargets.Property)]
   public class SwaggerExcludeAttribute : Attribute { }
}