using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosFusion.CarAppWebApi.DataLayer
{
    public class UnitTestMockingContext : DbContext, IUnitTestMockingContext
    {
        public UnitTestMockingContext() : base("name=TestEntities")
        {
        }
        public System.Data.Entity.DbSet<tbl_CarModel> Items { get; set; }
        public void MarkAsModified(tbl_CarModel item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
