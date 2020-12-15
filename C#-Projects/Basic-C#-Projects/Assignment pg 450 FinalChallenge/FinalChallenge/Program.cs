//1.Research the C# DateTime.Now property (i.e., Google the term, read articles, watch videos, etc.).
//HELPFUL LINK:
//https://docs.microsoft.com/en-us/dotnet/api/system.datetime.now?view=netcore-3.1
//2.Research event handler.
//HELPFUL LINKS:
//https://www.computerhope.com/jargon/e/event.htm
//https://docs.microsoft.com/en-us/dotnet/standard/events/
//3.Research handler method as it relates to Razor Pages. Also, research these methods: OnPost() and OnGet().
//HELPFUL LINKS:
//https://www.learnrazorpages.com/razor-pages/handler-methods
//https://www.mikesdotnetting.com/article/308/razor-pages-understanding-handler-methods
//4.Research void(as it relates to C#).
//HELPFUL LINKS:
//https://www.w3schools.com/cs/cs_methods.asp
//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/void
//5.Create a new ASP.NET Core web application project
//HELPFUL LINK:
//https://tutorials.visualstudio.com/aspnet-azure/create
//6.Design a simple ASP.NET Core web app that displays the actual server time in the browser.
//HELPFUL LINK:
//https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core-ef-step-02?view=vs-2019
//7.Customize the CSHTML < h2 > element with text of your choosing.
//HELPFUL LINK:
//https://www.w3schools.com/asp/razor_syntax.asp
//8.Publish your ASP.NET Core web application to Azure.
//IMPORTANT NOTE: Make sure to select a free account.You do not need/ want to pay for any Azure services. To avoid charges, be sure to choose a free account.
//HELPFUL LINK:
//https://tutorials.visualstudio.com/aspnet-azure/publis

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FinalChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
