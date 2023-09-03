using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SistemaVenta.BLL.Implementacion;
//using SistemaVenta.BLL.Interfaces;



namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services,IConfiguration Configuration) {

            services.AddDbContext<DbventaContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));
            });


        }
    }
}
