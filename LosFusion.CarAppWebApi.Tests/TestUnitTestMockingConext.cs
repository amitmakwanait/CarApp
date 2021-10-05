using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LosFusion.CarAppWebApi.DataLayer;

namespace LosFusion.CarAppWebApi.Tests
{
    class TestUnitTestMockingConext : IUnitTestMockingContext
    {
        public TestUnitTestMockingConext()
        {
            this.Items = new TestItemDbSet();
        }
        public DbSet<tbl_CarModel> Items { get; set; }
        public int SaveChanges()
        {
            return 0;
        }
        public void MarkAsModified(tbl_CarModel item) { }
        public void Dispose() { }
    }

}
