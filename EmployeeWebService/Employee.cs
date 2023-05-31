using System;
using System.Runtime.Serialization;

namespace EmployeeWebService
{
    //[Serializable] tüm üyelerin isim sırasına göre gönderir. Esnekleklik yok. Tüm üyeler gönderilir. 
    [DataContract(Namespace = "https://yazilimalani.com/2023/03/03/Employee")] // Serializable aksine bir esneklik sağlar. DataMemeber ile hangi property'lerin gönderilecği işaretlenebilir. 
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
    }
}
