using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Net.Http;

namespace BlazorApp1.Client.Pages
{
   public partial class Counter
   {
      private int currentCount = 0;
      private void IncrementCount()
      {
         currentCount++;
      }
   }
}