using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectManagement.Data;
using ProjectManagement.Interface;
using ProjectManagement.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement
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
            services.AddControllers().AddNewtonsoftJson();
          
            services.AddRazorPages().AddNewtonsoftJson();
           

            services.AddMvc().AddNewtonsoftJson();
            services.AddControllersWithViews().AddNewtonsoftJson();
            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<dbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionString")));
            services.AddTransient<IDesignation, DesignationServicelayer>();
            services.AddTransient<IRankType, RankTypeServiceLayer>();
            services.AddTransient<IForceRank, ForceRankServiceLayer>();
            services.AddTransient<IVendorInformation, VendorInformationServiceLayer>();
            services.AddTransient<IBureau, BureauServiceLayer>();
            services.AddTransient<IProject, ProjectServiceLayer>();
            services.AddTransient<IInitialNoteSheet, InitialNoteSheetServiceLayer>();
            services.AddTransient<IInvitationForTender, InvitationForTenderServiceLayer>();
            services.AddTransient<ITenderOpening, TenderOpeningServiceLayer>();
            services.AddTransient<IUserRole, UserRoleServiceLayer>();
            services.AddTransient<IUserInformation, UserInformationServiceLayer>();
            services.AddTransient<IFinalApproval, FinalApprovalServiceLayer>();
            services.AddTransient<INoa, NoaServiceLayer>();
            
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
               app.UseStatusCodePagesWithReExecute("/Error/{0}");
              app.UseExceptionHandler("/Error/{0}");
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
