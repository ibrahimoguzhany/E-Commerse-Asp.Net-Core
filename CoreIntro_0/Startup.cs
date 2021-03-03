using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreIntro_0.Models.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoreIntro_0
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Hangi servisin kullanılacagı burada öncelikle yazılmak durumundadır...(Ancak dikkat edin burada servisin sadece kullanılacagı yazılır yani burada kullanılmaz)..Burada sadece servisleri eklersiniz...

            //Burada standart bir Sql baglantısını belirlemek istiyorsanız (sınıf icerisinde optionBuilder'dan belirlemektense bu tercih edilir) burada belirlemelisiniz...


            //Pool kullanmak bir singletonPattern görevi görür...

            services.AddDbContextPool<MyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies()); //böylece baglantı ayarımızı burada belirlemiş olduk...

            //Yukarıdaki ifadede dikkat ederseniz UseLazyLoadingProxies ifadesi kullanılmıstır...Bu durum,.Net Core'daki Lazy Loading'in sürekli tetiklenebilmesi adına Environment'inizi garanti altına almanızı saglar...





            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
