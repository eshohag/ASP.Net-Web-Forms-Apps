using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DiagnosticCenterBillManagementSystemApp
{
    public class Gateway
    {
        private string connectionString =
               WebConfigurationManager.ConnectionStrings["DiagnosticCenterBillManagementDBConString"].ConnectionString;
        public List<Types> GetAllTypeNames()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = " SELECT * FROM Types";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Types> aType = new List<Types>();
            while (reader.Read())
            {
                Types aTypes = new Types();
                aTypes.TypeName = reader["TypeName"].ToString();
                aTypes.Id = Convert.ToInt32(reader["Id"].ToString());

                aType.Add(aTypes);
            }
            reader.Close();
            connection.Close();
            return aType;
        }

        public bool DoesTypeExist(string typeName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Types WHERE TypeName='" + typeName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool checkRows = reader.HasRows;
            reader.Close();
            connection.Close();
            return checkRows;
        }

        public int SaveTypeSetup(Types aType)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Types (TypeName) VALUES ('" + aType.TypeName + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Types> LoadTypeNameDropDownList()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "  SELECT * FROM Types";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Types> ATypes = new List<Types>();
            while (reader.Read())
            {
                Types aTypes = new Types();
                aTypes.TypeName = reader["TypeName"].ToString();
                aTypes.Id = (int)reader["Id"];

                ATypes.Add(aTypes);
            }
            reader.Close();
            connection.Close();
            return ATypes;
        }

        public List<TestView> GetAllTestNames()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = " SELECT * FROM TestView";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<TestView> testView = new List<TestView>();
            while (reader.Read())
            {
                TestView aTestView = new TestView();
                aTestView.TypeName = reader["TypeName"].ToString();
                aTestView.TestName = reader["TestName"].ToString();
                aTestView.Fee = Convert.ToInt32(reader["Fee"].ToString());


                testView.Add(aTestView);
            }
            reader.Close();
            connection.Close();
            return testView;
        }

        public bool DoesTestExist(string testName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Tests WHERE TestName='" + testName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool checkRows = reader.HasRows;
            reader.Close();
            connection.Close();
            return checkRows;
        }

        public int SaveTestSetup(Tests aTests)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Tests (TypeId,TestName,Fee) " +
                           "VALUES ('" + aTests.TypeId + "','" + aTests.TestName + "','" + aTests.Fee + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Tests> LoadTestDropdownList()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Tests";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Tests> testList = new List<Tests>();
            while (reader.Read())
            {
                Tests aTest = new Tests();
                aTest.TestName = reader["TestName"].ToString();
                aTest.Id = (int) reader["Id"];
                testList.Add(aTest);
            }
            reader.Close();
            connection.Close();
            return testList;
        }

        public string FetchData(string selectedTest)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Fee FROM Tests WHERE TestName='" + selectedTest + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            string selectedFee = null;
            while (reader.Read())
            {
                selectedFee = reader["Fee"].ToString();
            }
            reader.Close();
            connection.Close();
            return selectedFee;
        }

        public int SavePatient(Patients aPatient, Bills aBill)
        {
            int rowAffected=0, rowAffected2=0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Bills (BillNo,DueDate,TotalAmount,TestId) " +
                           "VALUES ('" + aBill.BillNo + "','" + aBill.DueDate + "','" + aBill.TotalAmount + "','" + 0 + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            rowAffected = command.ExecuteNonQuery();

            string query1 = "SELECT * FROM Bills WHERE BillNo='" + aBill.BillNo + "'";
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlDataReader reader = command1.ExecuteReader();
            int billId = 0;
            while (reader.Read())
            {
                billId = (int)reader["Id"];
            }
            reader.Close();

            string query2 = "INSERT INTO Patients (Name,Mobile,BirthDate,BillId) " +
                           "VALUES ('" + aPatient.Name + "','" + aPatient.Mobile + "','" + aPatient.BirthDate + "','" + billId + "');";
            SqlCommand command2 = new SqlCommand(query2, connection);
            rowAffected2 = command2.ExecuteNonQuery();
            connection.Close();

            return rowAffected2;
        }

        public PaymentView GetPatientInfo(string billNoOrMobileNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM PaymentView WHERE BillNo='"+billNoOrMobileNo+"' OR Mobile='"+billNoOrMobileNo+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            PaymentView paymentView=new PaymentView();
            while (reader.Read())
            {
                paymentView.TotalAmount = (int) reader["TotalAmount"];
                paymentView.DueDate = reader["DueDate"].ToString();
            }
            reader.Close();
            connection.Close();
            return paymentView;
        }


        public int DeletePatientByBillNo(string billNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Bills WHERE BillNo='"+billNo+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            string id = null;
            while (reader.Read())
            {
                id = reader["Id"].ToString();
            }
            reader.Close();

            string query3 = "DELETE FROM Patients WHERE BillId='" + id + "'";
            SqlCommand command3 = new SqlCommand(query3, connection);
            int rowAffected3 = command3.ExecuteNonQuery();

            string query2 = "DELETE FROM Bills WHERE Id='" + id + "'";
            SqlCommand command2 = new SqlCommand(query2, connection);
            int rowAffected2 = command2.ExecuteNonQuery();

            int rowAffected = rowAffected2 + rowAffected3;
            connection.Close();
            return rowAffected;
        }

        public int DeletePatientByMobileNo(string mobileNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Patients WHERE Mobile='" + mobileNo + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            string id = null;
            while (reader.Read())
            {
                id = reader["BillId"].ToString();
            }
            reader.Close();

            string query3 = "DELETE FROM Patients WHERE BillId='" + id + "'";
            SqlCommand command3 = new SqlCommand(query3, connection);
            int rowAffected3 = command3.ExecuteNonQuery();

            string query2 = "DELETE FROM Bills WHERE Id='" + id + "'";
            SqlCommand command2 = new SqlCommand(query2, connection);
            int rowAffected2 = command2.ExecuteNonQuery();

            int rowAffected = rowAffected2 + rowAffected3;
            connection.Close();
            return rowAffected;
        }

        public List<UnpaidPatientsView> PatientExist(string fromDate, string toDate)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM UnpaidPatientsView WHERE DueDate " +
                           "between convert(datetime,'" + fromDate + "',103) and convert(datetime,'" + toDate + "',103)";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<UnpaidPatientsView> unpaidPatientsViewList = new List<UnpaidPatientsView>();
            while (reader.Read())
            {
                UnpaidPatientsView unpaidPatientsView = new UnpaidPatientsView();
                unpaidPatientsView.Name = reader["Name"].ToString();
                unpaidPatientsView.Mobile = reader["Mobile"].ToString();
                unpaidPatientsView.BillNo = reader["BillNo"].ToString();
                unpaidPatientsView.TotalAmount = Convert.ToInt32(reader["TotalAmount"].ToString());

                unpaidPatientsViewList.Add(unpaidPatientsView);
            }
            reader.Close();
            connection.Close();
            return unpaidPatientsViewList;
        }

        public int SaveTest(string selectedDropdownListItem, string dueDate)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM TestView WHERE TestName='" + selectedDropdownListItem + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            TestList typeNameTestList = new TestList();
            while (reader.Read())
            {
                typeNameTestList.TypeName = reader["TypeName"].ToString();
            }
            reader.Close();

            string query2 = "INSERT INTO TestList (DueDate,TestName,TypeName) " +
                           "VALUES ('" + dueDate + "','" + selectedDropdownListItem + "','" + typeNameTestList.TypeName + "')";
            SqlCommand command2 = new SqlCommand(query2, connection);
            int rowAffected = command2.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        internal List<TestList> TestExistByDate(string fromDate, string toDate)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM TestList WHERE DueDate " +
                           "between convert(datetime,'" + fromDate + "',103) and convert(datetime,'" + toDate + "',103)";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TestList testList = new TestList();
                testList.TestName = reader["TestName"].ToString();
                testList.TypeName = reader["TypeName"].ToString();

                string query1 = "INSERT INTO TestNameTypeNameTemp (TestName,TypeName) " +
                                "VALUES ('" + testList.TestName + "','" + testList.TypeName + "')";
                SqlCommand command1 = new SqlCommand(query1, connection);
                int rowAffected1 = command1.ExecuteNonQuery();              
            }
            reader.Close();

            string query3 = "SELECT * FROM TestWiseReportView";
            SqlCommand command3 = new SqlCommand(query3, connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            List<TestList> testListByDate = new List<TestList>();

            while (reader3.Read())
            {
                TestList testList = new TestList();
                testList.TestName = reader3["TestName"].ToString();
                testList.TotalNoOfTest = (int)reader3["TotalNoOfTest"];


                string query4 = "SELECT * FROM Tests WHERE TestName='" + testList.TestName + "'";
                SqlCommand command4 = new SqlCommand(query4, connection);
                SqlDataReader reader4 = command4.ExecuteReader();
                int amount = 0;
                while (reader4.Read())
                {
                    amount = (int)reader4["Fee"];

                }
                reader4.Close();
                testList.TotalAmount = testList.TotalNoOfTest * amount;

                testListByDate.Add(testList);
            }
            reader3.Close();

            string query5 = "DELETE FROM TestNameTypeNameTemp";
            SqlCommand command5 = new SqlCommand(query5, connection);
            int rowAffected5 = command5.ExecuteNonQuery();  

            connection.Close();
            return testListByDate;
        }

        public List<TestList> TypeExistByDate(string fromDate, string toDate)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM TestList WHERE DueDate " +
                           "between convert(datetime,'" + fromDate + "',103) and convert(datetime,'" + toDate + "',103)";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TestList testList = new TestList();
                testList.TestName = reader["TestName"].ToString();
                testList.TypeName = reader["TypeName"].ToString();

                string query1 = "INSERT INTO TestNameTypeNameTemp (TestName,TypeName) " +
                                "VALUES ('" + testList.TestName + "','" + testList.TypeName + "')";
                SqlCommand command1 = new SqlCommand(query1, connection);
                int rowAffected1 = command1.ExecuteNonQuery();              
            }
            reader.Close();

            string query3 = "SELECT * FROM TypeWiseReportView";
            SqlCommand command3 = new SqlCommand(query3, connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            List<TestList> typeListByDate = new List<TestList>();
            while (reader3.Read())
            {
                TestList testList = new TestList();
                testList.TypeName = reader3["TypeName"].ToString();
                //testList.TestName = reader3["TestName"].ToString();
                testList.TotalNoOfTest = (int)reader3["TotalNoOfTest"];


                string query4 = "SELECT * FROM TestView " +
                                "WHERE TypeName='" + testList.TypeName + "'";
                SqlCommand command4 = new SqlCommand(query4, connection);
                SqlDataReader reader4 = command4.ExecuteReader();
                int amount = 0;
                while (reader4.Read())
                {
                    amount = (int)reader4["Fee"];
                    amount += amount;
                }
                reader4.Close();
                testList.TotalAmount = testList.TotalNoOfTest * amount;

                typeListByDate.Add(testList);
            }
            reader3.Close();

            string query5 = "DELETE FROM TestNameTypeNameTemp";
            SqlCommand command5 = new SqlCommand(query5, connection);
            int rowAffected5 = command5.ExecuteNonQuery();  

            connection.Close();
            return typeListByDate;
        }
    }
}