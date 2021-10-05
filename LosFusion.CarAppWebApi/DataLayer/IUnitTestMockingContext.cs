using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosFusion.CarAppWebApi.DataLayer
{
    public interface IUnitTestMockingContext : IDisposable
    {
        DbSet<tbl_CarModel> Items { get; }
        int SaveChanges();
        void MarkAsModified(tbl_CarModel item);
    }
}
