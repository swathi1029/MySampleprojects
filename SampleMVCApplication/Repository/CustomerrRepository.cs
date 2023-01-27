using SampleMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SampleMVCApplication.Repository
{
    public class CustomerrRepository
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            con = new SqlConnection(constr);

        }

        public List<CustomerModel> Search(string name)
        {
            connection();
            List<CustomerModel> EmpList = new List<CustomerModel>();
            if (name != null)
            {
                SqlCommand com = new SqlCommand("SearchbyName", con);
                com.Parameters.AddWithValue("@CustName", name);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                con.Close();
                //Bind EmpModel generic list using dataRow     
                foreach (DataRow dr in dt.Rows)
                {

                    EmpList.Add(

                        new CustomerModel
                        {

                            CustId = Convert.ToInt32(dr["CustId"]),
                            CustName = Convert.ToString(dr["CustName"]),
                            Age = Convert.ToInt32(dr["Age"]),
                            Mobile = Convert.ToInt32(dr["Mobile"]),
                            City = Convert.ToString(dr["City"]),
                            Country = Convert.ToString(dr["Country"]),
                            Gender = Convert.ToString(dr["Gender"]),

                            Address = Convert.ToString(dr["Adress"])

                        }
                        );
                }
                return EmpList;
            }

            
            else
            {
                return EmpList;
            }
        }
        public bool AddCustomer(CustomerModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewCustomerDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CustId", obj.CustId);
            com.Parameters.AddWithValue("@CustName", obj.CustName);
            com.Parameters.AddWithValue("@Age", obj.Age);
            com.Parameters.AddWithValue("@Mobile", obj.Mobile);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Country", obj.Country);
            com.Parameters.AddWithValue("@Gender", obj.Gender);
            com.Parameters.AddWithValue("@Address", obj.Address);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
        public List<CustomerModel> GetAllCustomers()
        {
            connection();
            List<CustomerModel> EmpList = new List<CustomerModel>();


            SqlCommand com = new SqlCommand("SELECTEMP", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind EmpModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {

                EmpList.Add(

                    new CustomerModel
                    {

                        CustId = Convert.ToInt32(dr["CustId"]),
                        CustName = Convert.ToString(dr["CustName"]),
                        Age = Convert.ToInt32(dr["Age"]),
                        Mobile = Convert.ToInt32(dr["Mobile"]),
                        City = Convert.ToString(dr["City"]),
                        Country = Convert.ToString(dr["Country"]),
                        Gender = Convert.ToString(dr["Gender"]),

                        Address = Convert.ToString(dr["Adress"])

                    }
                    );
            }

            return EmpList;
        }
        public bool UpdateCustomer(CustomerModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("UpdateCustDetails", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CustId", obj.CustId);
            com.Parameters.AddWithValue("@CustName", obj.CustName);
            com.Parameters.AddWithValue("@Age", obj.Age);
            com.Parameters.AddWithValue("@Mobile", obj.Mobile);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Country", obj.Country);
            com.Parameters.AddWithValue("@Gender", obj.Gender);
            com.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        //To delete Customer details    
        public bool DeleteCustomer(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("DeleteCustById", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CustId", Id);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}