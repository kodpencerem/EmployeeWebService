﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeWebServiceClient.EmployeeServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeType", Namespace="http://schemas.datacontract.org/2004/07/EmployeeWebService")]
    public enum EmployeeType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FullTimeEmployee = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartTimeEmployee = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo GetEmployee(EmployeeWebServiceClient.EmployeeServiceReference.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo> GetEmployeeAsync(EmployeeWebServiceClient.EmployeeServiceReference.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation SaveEmployee is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        EmployeeWebServiceClient.EmployeeServiceReference.SaveEmployeeResponse SaveEmployee(EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeWebServiceClient.EmployeeServiceReference.SaveEmployeeResponse> SaveEmployeeAsync(EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeNameById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeNameByIdResponse")]
        string GetEmployeeNameById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeNameById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeNameByIdResponse")]
        System.Threading.Tasks.Task<string> GetEmployeeNameByIdAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeRequestObject", WrapperNamespace="https://yazilimalani.com/2023/03/03/Employee", IsWrapped=true)]
    public partial class EmployeeRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee")]
        public string LicenseKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=0)]
        public int EmployeeId;
        
        public EmployeeRequest() {
        }
        
        public EmployeeRequest(string LicenseKey, int EmployeeId) {
            this.LicenseKey = LicenseKey;
            this.EmployeeId = EmployeeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeInfoObject", WrapperNamespace="https://yazilimalani.com/2023/03/03/Employee", IsWrapped=true)]
    public partial class EmployeeInfo {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=0)]
        public int Id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=1)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=2)]
        public string Gender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=3)]
        public System.DateTime DateOfBirth;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=4)]
        public EmployeeWebServiceClient.EmployeeServiceReference.EmployeeType Type;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=5)]
        public int AnnualSalary;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=6)]
        public int HourlyPay;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=7)]
        public int HoursWorked;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://yazilimalani.com/2023/03/03/Employee", Order=8)]
        public string City;
        
        public EmployeeInfo() {
        }
        
        public EmployeeInfo(int Id, string Name, string Gender, System.DateTime DateOfBirth, EmployeeWebServiceClient.EmployeeServiceReference.EmployeeType Type, int AnnualSalary, int HourlyPay, int HoursWorked, string City) {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Type = Type;
            this.AnnualSalary = AnnualSalary;
            this.HourlyPay = HourlyPay;
            this.HoursWorked = HoursWorked;
            this.City = City;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveEmployeeResponse {
        
        public SaveEmployeeResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService>, EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService.GetEmployee(EmployeeWebServiceClient.EmployeeServiceReference.EmployeeRequest request) {
            return base.Channel.GetEmployee(request);
        }
        
        public int GetEmployee(string LicenseKey, int EmployeeId, out string Name, out string Gender, out System.DateTime DateOfBirth, out EmployeeWebServiceClient.EmployeeServiceReference.EmployeeType Type, out int AnnualSalary, out int HourlyPay, out int HoursWorked, out string City) {
            EmployeeWebServiceClient.EmployeeServiceReference.EmployeeRequest inValue = new EmployeeWebServiceClient.EmployeeServiceReference.EmployeeRequest();
            inValue.LicenseKey = LicenseKey;
            inValue.EmployeeId = EmployeeId;
            EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo retVal = ((EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService)(this)).GetEmployee(inValue);
            Name = retVal.Name;
            Gender = retVal.Gender;
            DateOfBirth = retVal.DateOfBirth;
            Type = retVal.Type;
            AnnualSalary = retVal.AnnualSalary;
            HourlyPay = retVal.HourlyPay;
            HoursWorked = retVal.HoursWorked;
            City = retVal.City;
            return retVal.Id;
        }
        
        public System.Threading.Tasks.Task<EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo> GetEmployeeAsync(EmployeeWebServiceClient.EmployeeServiceReference.EmployeeRequest request) {
            return base.Channel.GetEmployeeAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmployeeWebServiceClient.EmployeeServiceReference.SaveEmployeeResponse EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService.SaveEmployee(EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo request) {
            return base.Channel.SaveEmployee(request);
        }
        
        public void SaveEmployee(int Id, string Name, string Gender, System.DateTime DateOfBirth, EmployeeWebServiceClient.EmployeeServiceReference.EmployeeType Type, int AnnualSalary, int HourlyPay, int HoursWorked, string City) {
            EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo inValue = new EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo();
            inValue.Id = Id;
            inValue.Name = Name;
            inValue.Gender = Gender;
            inValue.DateOfBirth = DateOfBirth;
            inValue.Type = Type;
            inValue.AnnualSalary = AnnualSalary;
            inValue.HourlyPay = HourlyPay;
            inValue.HoursWorked = HoursWorked;
            inValue.City = City;
            EmployeeWebServiceClient.EmployeeServiceReference.SaveEmployeeResponse retVal = ((EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService)(this)).SaveEmployee(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EmployeeWebServiceClient.EmployeeServiceReference.SaveEmployeeResponse> EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService.SaveEmployeeAsync(EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo request) {
            return base.Channel.SaveEmployeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<EmployeeWebServiceClient.EmployeeServiceReference.SaveEmployeeResponse> SaveEmployeeAsync(int Id, string Name, string Gender, System.DateTime DateOfBirth, EmployeeWebServiceClient.EmployeeServiceReference.EmployeeType Type, int AnnualSalary, int HourlyPay, int HoursWorked, string City) {
            EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo inValue = new EmployeeWebServiceClient.EmployeeServiceReference.EmployeeInfo();
            inValue.Id = Id;
            inValue.Name = Name;
            inValue.Gender = Gender;
            inValue.DateOfBirth = DateOfBirth;
            inValue.Type = Type;
            inValue.AnnualSalary = AnnualSalary;
            inValue.HourlyPay = HourlyPay;
            inValue.HoursWorked = HoursWorked;
            inValue.City = City;
            return ((EmployeeWebServiceClient.EmployeeServiceReference.IEmployeeService)(this)).SaveEmployeeAsync(inValue);
        }
        
        public string GetEmployeeNameById(int id) {
            return base.Channel.GetEmployeeNameById(id);
        }
        
        public System.Threading.Tasks.Task<string> GetEmployeeNameByIdAsync(int id) {
            return base.Channel.GetEmployeeNameByIdAsync(id);
        }
    }
}
