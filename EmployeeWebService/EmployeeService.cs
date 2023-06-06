using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {

        private Employee _lastSavedEmployee;
        public EmployeeInfo GetEmployee(EmployeeRequest request)
        {
            Console.WriteLine("License Key =" + request.LicenseKey);

            Employee employee = null;
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("upGetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = request.EmployeeId;
                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((EmployeeType)reader["EmployeeType"] == EmployeeType.FullTimeEmployee)
                    {
                        employee = new FullTimeEmployee
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Type = EmployeeType.FullTimeEmployee,
                            AnnualSalary = Convert.ToInt32(reader["AnnualSalary"]),
                            City = reader["City"].ToString()
                        };
                    }
                    else
                    {
                        employee = new PartTimeEmployee
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Type = EmployeeType.PartTimeEmployee,
                            HourlyPay = Convert.ToInt32(reader["HourlyPay"]),
                            HoursWorked = Convert.ToInt32(reader["HoursWorked"]),
                            City = reader["City"].ToString()
                        };
                    }
                }

            }

            if (_lastSavedEmployee != null && employee.Id == _lastSavedEmployee.Id)
            {

            }

            return new EmployeeInfo(employee);
        }

        public string GetEmployeeNameById(int id)
        {
            throw new NotImplementedException();
        }
        protected Employee employee1 = null;
        public void SaveEmployee(EmployeeInfo Employee)
        {
            _lastSavedEmployee = employee1;

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("upSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = Employee.Id
                };
                cmd.Parameters.Add(parameterId);

                SqlParameter parameterName = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = Employee.Name
                };
                cmd.Parameters.Add(parameterName);

                SqlParameter parameterGender = new SqlParameter
                {
                    ParameterName = "@Gender",
                    Value = Employee.Gender
                };
                cmd.Parameters.Add(parameterGender);

                SqlParameter parameterDateOfBirth = new SqlParameter
                {
                    ParameterName = "@DateOfBirth",
                    Value = Employee.DateOfBirth
                };
                cmd.Parameters.Add(parameterDateOfBirth);

                SqlParameter parameterEmployeeType = new SqlParameter
                {
                    ParameterName = "@EmployeeType",
                    Value = Employee.Type
                };
                cmd.Parameters.Add(parameterEmployeeType);
                if (Employee.Type == EmployeeType.FullTimeEmployee)
                {
                    SqlParameter parameterAnnualSalary = new SqlParameter
                    {
                        ParameterName = "@AnnualSalary",
                        Value = Employee.AnnualSalary
                    };
                    cmd.Parameters.Add(parameterAnnualSalary);
                }
                else
                {
                    SqlParameter parameterHourlyPay = new SqlParameter
                    {
                        ParameterName = "@HourlyPay",
                        Value = Employee.HourlyPay,
                    };
                    cmd.Parameters.Add(parameterHourlyPay);

                    SqlParameter parameterHoursWorked = new SqlParameter
                    {
                        ParameterName = "@HoursWorked",
                        Value = Employee.HoursWorked
                    };
                    cmd.Parameters.Add(parameterHoursWorked);
                }

                SqlParameter parameterCity = new SqlParameter
                {
                    ParameterName = "@City",
                    Value = Employee.City
                };
                cmd.Parameters.Add(parameterCity);

                con.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}
