using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProjectWCFLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SoaDBEntities db = new SoaDBEntities();

        public tblCustomer AddCustomer(int customerid, string customername, string address, int employeeid)
        {
            tblCustomer c1 = new tblCustomer();
            c1.CustomerId = customerid;
            c1.CustorName = customername;
            c1.Address = address;
            c1.EmployeeId = employeeid;
            db.tblCustomers.Add(c1);
            db.SaveChanges();
            return c1;
        }

        public tblEmployee AddEmployee(int empno, string ename, int mgr)
        {
            tblEmployee e1 = new tblEmployee();
            e1.empno = empno;
            e1.ename = ename;
            e1.mgr = mgr;
            db.tblEmployees.Add(e1);
            db.SaveChanges();
            return e1;
        }

        public tblCustomer DeleteCustomer(int customerid)
        {
            tblCustomer c1 = db.tblCustomers.Single(x => x.CustomerId == customerid);
            db.tblCustomers.Remove(c1);
            db.SaveChanges();
            return c1;
        }

        public tblEmployee DeleteEmployee(int empno)
        {
            tblEmployee e1 = db.tblEmployees.Single(x => x.empno == empno);
            db.tblEmployees.Remove(e1);
            db.SaveChanges();
            return e1;
        }

        public tblCustomer EditCustomer(int customerid, string customername, string address, int employeeid)
        {
            tblCustomer c1 = db.tblCustomers.Single(x => x.CustomerId == customerid);
            c1.CustorName = customername;
            c1.Address = address;
            c1.EmployeeId = employeeid;
            db.SaveChanges();
            return c1;
        }

        public tblEmployee EditEmployee(int empno, string ename, int mgr)
        {
            tblEmployee e1 = db.tblEmployees.Single(x => x.empno == empno);
            e1.ename = ename;
            e1.mgr = mgr;
            db.SaveChanges();
            return e1;
        } 

        public List<tblCustomer> GetCustomer()
        {
            return db.tblCustomers.ToList();
        }

        public List<tblEmployee> GetEmployee()
        {
            return db.tblEmployees.ToList();
        }

        public List<tblSale> GetSales()
        {
            return db.tblSales.ToList();
        }
        
        /*
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        */
    }
}
