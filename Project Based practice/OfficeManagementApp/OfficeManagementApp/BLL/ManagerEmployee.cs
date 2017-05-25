using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OfficeManagementApp.DAL.Gateway;
using OfficeManagementApp.DAL.Model;

namespace OfficeManagementApp.BLL
{
   
    public class ManagerEmployee
    {
         EmployeeGateway aEmployeeGateway=new EmployeeGateway();
     
        public int Save(Employee aEmployee)
        {

            int a = aEmployeeGateway.Save(aEmployee);
            return a;



            //if (aEmployeeGateway.Save(aEmployee) > 0)
            //{
            //    return "Successfully Saved";                
            //}
            //else
            //{
            //    return " faild Saved";
            //}    
        }

        public List<Employee> ShowAllEmployee()
        {
            return aEmployeeGateway.ShowAllEmployee();
        }
        public Employee GetSearchEmployee(int id)
        {
         return aEmployeeGateway.SearchEmployee(id);
           
           

        }


        public string Update(Employee aEmployee)
        {
            int update= aEmployeeGateway.Update(aEmployee);
            if (update > 0)
            {
                return "Success Update";
                
            }
            else
            {
                return "Failds Update";
            }
        }
    }
}