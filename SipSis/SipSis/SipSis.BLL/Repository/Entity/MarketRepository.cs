using SipSis.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipSis.BLL.Repository.Entity
{
    public class MarketRepository : Base.BaseRepository<Market>
    {
        public void Update(Market vm)
        {
            var bulunan = Find(vm.ID);
            bulunan.MarketName = vm.MarketName;
            bulunan.Commission = vm.Commission;
            bulunan.UserID = vm.UserID;
            Save();
        }
    }
}
