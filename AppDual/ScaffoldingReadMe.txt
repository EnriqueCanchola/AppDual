<<<<<<< HEAD
﻿ASP.NET Core MVC dependencies have been added to the project.
(These dependencies include packages required to enable scaffolding)

=======
﻿
ASP.NET MVC core dependencies have been added to the project.
>>>>>>> parent of 2083533... Revert "Cambios"
However you may still need to do make changes to your project.

1. Suggested changes to Startup class:
    1.1 Add a constructor:
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
<<<<<<< HEAD

=======
>>>>>>> parent of 2083533... Revert "Cambios"
    1.2 Add MVC services:
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
       }

<<<<<<< HEAD
    1.3 Configure web app to use MVC routing:
=======
    1.3 Configure web app to use use Configuration and use MVC routing:
>>>>>>> parent of 2083533... Revert "Cambios"

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
