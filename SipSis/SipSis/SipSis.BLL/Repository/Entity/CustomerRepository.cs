using SipSis.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipSis.BLL.Repository.Entity
{
    public class CustomerRepository : Base.BaseRepository<Customer>
    {
        public Customer PhoneSearch(string Phone)
        {
            var bulunan = (from c in GetAll()
                           where c.CustomerPhone == Phone
                           select new Customer
                           {
                               CustomerAddress = c.CustomerAddress,
                               CustomerName = c.CustomerName,
                               CustomerPhone = c.CustomerPhone,
                               ID = c.ID,
                               MarketID = c.MarketID,
                               UserID = c.UserID,
                           }).SingleOrDefault();

            if (bulunan!=null)
            {
                return bulunan;
            }
            else
            {
                return new Customer();
            }
        }
    }
}
