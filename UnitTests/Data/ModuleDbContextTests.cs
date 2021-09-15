using Eraware.Modules.ApiLogger.Data;
using Eraware.Modules.ApiLogger.Data.Entities;
using System;
using Xunit;

namespace UnitTests.Data
{
    public class ModuleDbContextTests
    {
        [Fact]
        public void DefaultConstructorThrows()
        {
            var context = new ModuleDbContext();
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                context.Items.Add(new Item());
            });

            Assert.Equal("No connection string named 'SiteSqlServer' could be found in the application config file.", ex.Message);
        }
    }
}
