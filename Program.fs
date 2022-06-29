namespace bookrecomendation

#nowarn "20"

open System
open System.Collections.Generic
open System.IO
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.HttpsPolicy
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging

module Program =
    let exitCode = 0

    [<EntryPoint>]
    var builder = WebApplication.CreateBuilder(args);

     builder.Services.AddControllersWithViews();
     var app = builder.Build();

     app.UseStaticFiles();
     app.UseRouting();
     app.MapControllerRoute(
     name: "default",
     pattern: "{Controller=Home}/{action=Index}/{id?}");

        app.Run()

        exitCode
