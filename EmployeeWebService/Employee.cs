using System;
using System.Runtime.Serialization;

namespace EmployeeWebService
{
    //[Serializable] tüm üyelerin isim sırasına göre gönderir. Esnekleklik yok. Tüm üyeler gönderilir. 
    [DataContract] // Serializable aksine bir esneklik sağlar. DataMemeber ile hangi property'lerin gönderilecği işaretlenebilir. 
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateOfBirth;

        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        [DataMember]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
    }
}
