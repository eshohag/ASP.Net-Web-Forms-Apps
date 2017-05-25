using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagnosticCenterBillManagementSystemApp
{
    public class Manager
    {
        Gateway gateway=new Gateway();

        public List<Types> GetAllTypeNames()
        {
            return gateway.GetAllTypeNames();
        }

        public string SaveTypeSetup(Types aType)
        {

            bool hasRows = gateway.DoesTypeExist(aType.TypeName);
            if (hasRows == false)
            {
                int rowAffected = gateway.SaveTypeSetup(aType);
                if (rowAffected > 0)
                {
                    return "Saved Successfully";
                }
                else
                {
                    return "SaveTypeSetup Failed";
                }
            }
            else
            {
                return "Type Already Exist";
            }
        }

        public List<Types> LoadTypeNameDropdownList()
        {
            return gateway.LoadTypeNameDropDownList();
        }

        public List<TestView> GetAllTestNames()
        {
            return gateway.GetAllTestNames();
        }

        public string SaveTestSetup(Tests aTests)
        {
            bool hasRows = gateway.DoesTestExist(aTests.TestName);
            if (hasRows == false)
            {
                int rowAffected = gateway.SaveTestSetup(aTests);
                if (rowAffected > 0)
                {
                    return "Test setup saved Successfully";
                }
                else
                {
                    return "Test Setup saved Failed";
                }
            }
            else
            {
                return "Test Already Exist";
            }
        }

        public List<Tests> LoadTestDropdownList()
        {
            return gateway.LoadTestDropdownList();
        }

        public string FetchData(string selectedTest)
        {
            return gateway.FetchData(selectedTest);
        }

        public string SavePatient(Patients aPatient, Bills aBill)
        {
            int rowAffected = gateway.SavePatient(aPatient,aBill);
            if (rowAffected > 0)
            {
                return "ADD Successfully";
            }
            else
            {
                return "ADD Failed";
            }
        }


        public PaymentView GetPatientInfo(string billNoOrMobileNo)
        {
            return gateway.GetPatientInfo(billNoOrMobileNo);
        }


        public string DeletePatientByBillNo(string billNo)
        {
            int rowAffected = gateway.DeletePatientByBillNo(billNo);
            if (rowAffected >=2)
            {
                return "Paid Successfully";
            }
            else
            {
                return "Paid Failed";
            }
        }

        public string DeletePatientByMobileNo(string mobileNo)
        {
            int rowAffected = gateway.DeletePatientByMobileNo(mobileNo);
            if (rowAffected >= 2)
            {
                return "Paid Successfully";
            }
            else
            {
                return "Paid Failed";
            }
        }

        public List<UnpaidPatientsView> PatientExist(string fromDate, string toDate)
        {
            return gateway.PatientExist(fromDate, toDate);
        }

        public string SaveTest(string selectedDropdownListItem, string dueDate)
        {
            int rowAffected = gateway.SaveTest(selectedDropdownListItem, dueDate);
            if (rowAffected > 0)
            {
                return "Test Save Successfully";
            }
            else
            {
                return "Test save Failed";
            }
        }

        internal List<TestList> TestExistByDate(string fromDate, string toDate)
        {
            return gateway.TestExistByDate(fromDate, toDate);
        }

        public List<TestList> TypeExistByDate(string fromDate, string toDate)
        {
            return gateway.TypeExistByDate(fromDate, toDate);
        }
    }
}