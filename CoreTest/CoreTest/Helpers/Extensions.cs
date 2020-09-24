using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response , string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers","Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
        public static int CalculateAge(this DateTime TheDateTime)
        {
            var Age = DateTime.Today.Year - TheDateTime.Year;
            if (TheDateTime.AddYears(Age) > DateTime.Today)
            {
                Age--;
            }
            return Age;
        }
    }
}
