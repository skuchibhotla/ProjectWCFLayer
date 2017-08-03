using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProjectWCFLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<tblEmployee> GetEmployee();

        [OperationContract]
        List<tblCustomer> GetCustomer();

        [OperationContract]
        List<tblSale> GetSales();

        [OperationContract]
        tblEmployee AddEmployee(int empno, string ename, int mgr);

        [OperationContract]
        tblEmployee DeleteEmployee(int empno);

        [OperationContract]
        tblEmployee EditEmployee(int empno, string ename, int mgr);

        [OperationContract]
        tblCustomer AddCustomer(int customerid, string custorname, string address, int employeeid);

        [OperationContract]
        tblCustomer DeleteCustomer(int customerid);

        [OperationContract]
        tblCustomer EditCustomer(int customerid, string custorname, string address, int employeeid);
        
        /*
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        */
    }
    
}
