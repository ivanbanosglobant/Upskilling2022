using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ExampleWebApiNetCore6.DataBase
{
    public class DatabaseConfiguration : IConfigureOptions<Database>
    {
        private readonly IConfiguration _configuration;

        public DatabaseConfiguration(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public void Configure(Database options)
        {
            _ = options ?? throw new ArgumentNullException(nameof(options));
            _configuration.Bind("Database", options);
           
        }
    }
}
