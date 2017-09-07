using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.dal;
using ClassLibrary1;
using System.Data.Entity;
using System.Data;



namespace BussinessLogic.bll
{
    public class CustomerInfoLogic
    {
        private Datacontext2 dbcontext2 = new Datacontext2();
        public List<custregTable> GetAllInformation()
        {
            var result = (
                      from database in dbcontext2.custregTables
                      select database
                  );
            return result.ToList();
            
        }
        public bool AddCustomer(custregTable entity)
        {
            if (entity != null)
            {
                dbcontext2.custregTables.Add(entity);
                dbcontext2.SaveChanges();
                return true;
            }
            else 
            {
                return false;
            }
 
        }

        public List<custregTable> GetInfo(string firstname)
        {
            var result = (
                from r in dbcontext2.custregTables
                where r.username== firstname
                select r
                         );
            return result.ToList();
        }
        //public bool Check1(string custusername)
        //{
            ////custregTable context = new custregTable();
            //var query = from p in dbcontext2.custregTables
            //            where p.username == custusername 
            //            select p;

            //if (query.Any())
            //{
            //    var Customer = query.FirstOrDefault();
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            public custregTable ShowUserInfo(string username)
            {
        
            //var result =
            //    from s in dbcontext2.custregTables select s;

            //var result2 = result.Where(d => d.username.Equals(username));
            //return result2.SingleOrDefault();
                var result = (
                        from customerInfo in dbcontext2.custregTables
                        where customerInfo.username.Equals(username)
                        select customerInfo
                    ).FirstOrDefault();
                return result;
        }

        
    }
}
