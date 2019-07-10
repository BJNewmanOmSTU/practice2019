﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Services;
using Practice.WebApi.Services.ProductTemplatesServices;
using Practice.WebApi.Mapper;
using Practice.WebApi.Services.CodeServices;

namespace Practice.WebApi
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
			services.AddDbContext<DomainContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
			// AddJsonOptions нужен для вывода списка связанных данных
			services.AddMvc()
				.AddJsonOptions(
			options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
			services.AddTransient<StoreService>();
			services.AddTransient<ContractMapper>();
			services.AddTransient<ProductTemplateService>();
			services.AddTransient<CodeService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
			app.UseMvc();
		}
    }
}
