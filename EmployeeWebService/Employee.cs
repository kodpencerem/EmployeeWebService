using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace EmployeeWebService
{
    //[Serializable] tüm üyelerin isim sırasına göre gönderir. Esnekleklik yok. Tüm üyeler gönderilir. 
    [DataContract(Namespace = "https://yazilimalani.com/2023/03/03/Employee")] // Serializable aksine bir esneklik sağlar. DataMemeber ile hangi property'lerin gönderilecği işaretlenebilir. 
    //[KnownType(typeof(FullTimeEmployee))] // global
    //[KnownType(typeof(PartTimeEmployee))]
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateOfBirth;

        [DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember(Order = 2)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember(Order = 3)]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        [DataMember(Order = 4)]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        [DataMember(Order = 5)]
        public EmployeeType Type { get; set; }

        [DataMember(Order = 6, IsRequired =true)]
        public string City { get; set; }

    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeRequestObject", WrapperNamespace = "https://yazilimalani.com/2023/03/03/Employee")]
    public class EmployeeRequest
    {
        [MessageHeader(Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public int EmployeeId { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "https://yazilimalani.com/2023/03/03/Employee")]
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {

        }

        public EmployeeInfo(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Gender = employee.Gender;
            City = employee.City;
            DateOfBirth = employee.DateOfBirth;
            Type = employee.Type;
            if (Type == EmployeeType.FullTimeEmployee)
            {
                this.AnnualSalary = ((FullTimeEmployee)employee).AnnualSalary;
            }
            else
            {
                this.HourlyPay = ((PartTimeEmployee)employee).HourlyPay;
                this.HoursWorked = ((PartTimeEmployee)employee).HoursWorked;

            }
            

        }


        [MessageBodyMember(Order = 1, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public int Id { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public string Name { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public string Gender { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public DateTime DateOfBirth { get; set; }
        [MessageBodyMember(Order = 5, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public EmployeeType Type { get; set; }
        [MessageBodyMember(Order = 6, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public int AnnualSalary { get; set; }
        [MessageBodyMember(Order = 7, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public int HourlyPay { get; set; }
        [MessageBodyMember(Order = 8, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public int HoursWorked { get; set; }

        [MessageBodyMember(Order = 9, Namespace = "https://yazilimalani.com/2023/03/03/Employee")]
        public string City { get; set; }
    }

    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
