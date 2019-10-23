using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOptionDemo
{
    public static class FunctionalityExtensionMethods
    {
        public static IApplicationBuilder UseCustomFunctionality(this IApplicationBuilder builder)
        {
           return builder.UseMiddleware<CustomMiddleware>();
        }


    }
}
