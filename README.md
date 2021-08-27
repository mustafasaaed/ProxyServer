# ProxyServer

This is a very simple Proxy Middleware for .Net core applications:

# Usage 

Add these using to the top of `Startup` class: 


`using ProxyLib.Models;` 
`using ProxyLib.Extensions;`


First of all you need to define the list of paths and urls that you want to proxy
You just need to create a list of `ProxyConfirguration` Class and define the path that you need to match and the new url 
and then call `AddProxy` Extension Method with the config object.
In StartUp ConfigreServices method:

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var config = new List<ProxyConfiguration>();
            config.Add(new ProxyConfiguration
            {
                NewUrl = "https://www.google.com",
                PathToMatch = "/google"
            });

            config.Add(new ProxyConfiguration
            {
                NewUrl = "https://www.facebook.com",
                PathToMatch = "facebook"
            });

            services.AddProxy(config);
        } 



Then in Configure method all you need to do is to call `UseProxy` Extension method: 



        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseProxy();


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


