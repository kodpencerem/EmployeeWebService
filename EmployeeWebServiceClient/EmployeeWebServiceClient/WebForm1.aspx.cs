using EmployeeWebServiceClient.EmployeeServiceReference;
using System;

namespace EmployeeWebServiceClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            Employee employee = client.GetEmployee(Convert.ToInt32(txtID.Text));

            if (employee.Type == EmployeeType.FullTimeEmployee)
            {
                txtAnnualSalary.Text = ((FullTimeEmployee)employee).AnnualSalary.ToString();
                txtAnnualSalary.Visible = true;
                txtHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                txtHourlyPay.Text = ((PartTimeEmployee)employee).HourlyPay.ToString();
                txtHoursWorked.Text = ((PartTimeEmployee)employee).HoursWorked.ToString();
                txtAnnualSalary.Visible = false;
                txtHourlyPay.Visible = true;
                trHoursWorked.Visible = true;
            }
            ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();


            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            lblMessage.Text = "Employee retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            Employee employee = null;

            if (((EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)) == EmployeeType.FullTimeEmployee)
            {
                employee = new FullTimeEmployee
                {
                    Id = Convert.ToInt32(txtID.Text),
                    Name = txtName.Text,
                    Gender = txtGender.Text,
                    DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                    Type = EmployeeType.FullTimeEmployee,
                    AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text),
                };
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee Saved";
            }
            else if (((EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)) == EmployeeType.PartTimeEmployee)
            {
                employee = new PartTimeEmployee
                {
                    Id = Convert.ToInt32(txtID.Text),
                    Name = txtName.Text,
                    Gender = txtGender.Text,
                    DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                    Type = EmployeeType.PartTimeEmployee,
                    HourlyPay = Convert.ToInt32(txtHourlyPay.Text),
                    HoursWorked = Convert.ToInt32(txtHoursWorked.Text)
                };
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }
            else
            {
                lblMessage.Text = "Please select Employee Type";
            }
        }

        protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEmployeeType.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else if (ddlEmployeeType.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = true;
                trHoursWorked.Visible = true;
            }
        }
    }
}