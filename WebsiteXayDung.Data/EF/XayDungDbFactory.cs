using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteXayDung.Data.EF
{
    public class XayDungDbFactory : IDesignTimeDbContextFactory<XayDungDb>
    {
        public XayDungDb CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsetting.json")
                 .Build();
            var connectionstring = configuration.GetConnectionString("db");
            var optionBuider = new DbContextOptionsBuilder<XayDungDb>();
            optionBuider.UseSqlServer(connectionstring);
            return new XayDungDb(optionBuider.Options);
        }
    }
}
