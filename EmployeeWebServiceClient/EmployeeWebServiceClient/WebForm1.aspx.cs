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
            EmployeeServiceReference.IEmployeeService client = new EmployeeServiceReference.EmployeeServiceClient();
            EmployeeServiceReference.EmployeeRequest request = new EmployeeServiceReference.EmployeeRequest("AXG120ABC", Convert.ToInt32(txtID.Text));
            EmployeeServiceReference.EmployeeInfo employee = client.GetEmployee(request);


            if (employee.Type == EmployeeServiceReference.EmployeeType.FullTimeEmployee)
            {
                txtAnnualSalary.Text = employee.AnnualSalary.ToString();
                txtAnnualSalary.Visible = true;
                txtHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                txtHourlyPay.Text = employee.HourlyPay.ToString();
                txtHoursWorked.Text = employee.HoursWorked.ToString();
                txtAnnualSalary.Visible = false;
                txtHourlyPay.Visible = true;
                trHoursWorked.Visible = true;
            }
            ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();


            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtCity.Text = employee.City;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            lblMessage.Text = "Employee retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeServiceReference.IEmployeeService client = new EmployeeServiceReference.EmployeeServiceClient();
            EmployeeServiceReference.EmployeeInfo employee = new EmployeeServiceReference.EmployeeInfo();

            if (ddlEmployeeType.SelectedValue == "-1")
            {
                lblMessage.Text = "Please select Employee Type";
            }

            if (((EmployeeServiceReference.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)) == EmployeeServiceReference.EmployeeType.FullTimeEmployee)
            {

                employee.Type = EmployeeServiceReference.EmployeeType.FullTimeEmployee;
                employee.AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text);

            }
            else
            {
                employee.Type = EmployeeServiceReference.EmployeeType.PartTimeEmployee;
                employee.HourlyPay = Convert.ToInt32(txtHourlyPay.Text);
                employee.HoursWorked = Convert.ToInt32(txtHoursWorked.Text);
            }

            employee.Id = Convert.ToInt32(txtID.Text);
            employee.Name = txtName.Text;
            employee.Gender = txtGender.Text;
            employee.City = txtCity.Text;
            employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            client.SaveEmployee(employee);
            lblMessage.Text = "Employee saved";
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