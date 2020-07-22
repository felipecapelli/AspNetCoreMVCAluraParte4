using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CasaDoCodigo.RelatorioWebAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //1)Validar o token
            //2)Garantir que o token é valido

            //Autenticação básica: usuário e senha trafegam pela rede
            //Bearer: É diferente da autenticação básica, pois somente o token trafega pela rede
            //Vamos usar o Bearer
            services
                .AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(options => //ATENCAO --->>>Para usar tem que instalar o pacote IdentityServer4.AccessTokenValidation no Nuget
                {
                    options.ApiName = "CasaDoCodigo.Relatorio";
                    options.ApiSecret = "49C1A7E1-0C79-4A89-A3D6-A37998FB86B0";
                    options.Authority = Configuration["CasaDoCodigoIdentityServerUrl"];
                    options.RequireHttpsMetadata = false;
                });//ATENCAO--->>>Na aplicação que vai fazer a requisição pra cá (CasaDoCodigoMVC) tem que instalar o pacote: IdentityModel - no Nuget

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
