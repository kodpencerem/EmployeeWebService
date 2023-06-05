using System.ServiceModel;

namespace EmployeeWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceKnownType(typeof(FullTimeEmployee))] // take control
    [ServiceKnownType(typeof(PartTimeEmployee))] // take control
    [ServiceContract]
    public interface IEmployeeService
    {
        
        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        void SaveEmployee(Employee Employee);
    }
}
