using Newtonsoft.Json;

namespace Assignment.Models
{
    public class DBHandle
    {
        public string viewcustomer()
        {
            EFDBHandle context = new EFDBHandle();
            var listP = from e in context.Customers
                        select new
                        {
                            CustomerId = e.CustomerId,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            Country = e.Country,
                            CreatedDate = e.CreatedDate
                        };
            List<Customer> listS = new List<Customer>();
            foreach (var listE in listP)
            {
                Customer e = new Customer();
                e.CustomerId = listE.CustomerId;
                e.FirstName = listE.FirstName;
                e.LastName = listE.LastName;
                e.Country = listE.Country;
                e.CreatedDate = listE.CreatedDate;
                listS.Add(e);
            }

            return JsonConvert.SerializeObject(listS);
        }
        public void addcustomer(Customer c)
        {
            c.CreatedDate = DateTime.Now;
            EFDBHandle context = new EFDBHandle();
            context.Customers.Add(c);
            context.SaveChanges();
            return;
        }
        public void updatecustomer(Customer c)
        {
            c.CreatedDate = DateTime.Now;
            EFDBHandle context = new EFDBHandle();
            Customer cus = context.Customers.Find(c.CustomerId);
            cus.FirstName = c.FirstName;
            cus.LastName = c.LastName;
            cus.Country = c.Country;
            cus.CreatedDate = c.CreatedDate;
            context.SaveChanges();
            return;
        }
        public void deletecus(int id)
        {
            EFDBHandle context = new EFDBHandle();
            context.Customers.Remove(context.Customers.FirstOrDefault(e => e.CustomerId == id));
            context.SaveChanges();
            return;
        }
        public Customer getcusonID(int CustomerId)
        {
            EFDBHandle context = new EFDBHandle();
            var cus = context.Customers.Find(CustomerId);
            return cus;
        }
    }

}
