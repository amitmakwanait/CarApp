using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LosFusion.CarAppWebApi.DataLayer;

namespace LosFusion.CarAppWebApi.Tests
{
    class TestItemDbSet : TestDb<tbl_CarModel>
    {
        public override tbl_CarModel Find(params object[] keyValues)
        {
            return this.SingleOrDefault(item => item.Id == (int)keyValues.Single());
        }
    }
}
