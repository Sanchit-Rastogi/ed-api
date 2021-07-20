using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using ED_api.Contracts;
using ED_api.Models;

namespace ED_api.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly string connectionString;

        public EmployeeService()
        {
            connectionString = "Data Source=.;Initial Catalog=ED_Flutter_DB;user=sa;password=Sanchit123@sql#;Trusted_Connection=false";
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public void Add(Employee emp)
        {
            using IDbConnection dbConnection = Connection;
            string sQuery = "INSERT INTO FlutterEmployees(FirstName, LastName, PhoneNumber, Email, Gender ) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Gender)";
            dbConnection.Open();
            dbConnection.Execute(sQuery, emp);
        }

        public void Delete(int id)
        {
            using IDbConnection dbConnection = Connection;
            string sQuery = "DELETE FROM FlutterEmployees WHERE Id=@Id";
            dbConnection.Open();
            dbConnection.Execute(sQuery, new { Id = id });
        }

        public IEnumerable<Employee> GetAll()
        {
            using IDbConnection dbConnection = Connection;
            string sQuery = "SELECT * FROM FlutterEmployees";
            dbConnection.Open();
            return dbConnection.Query<Employee>(sQuery);
        }

        public Employee GetById(int id)
        {
            using IDbConnection dbConnection = Connection;
            string sQuery = "SELECT * FROM FlutterEmployees WHERE Id=@Id";
            dbConnection.Open();
            return dbConnection.Query<Employee>(sQuery, new { Id = id }).FirstOrDefault();
        }

        public void Update(Employee emp)
        {
            using IDbConnection dbConnection = Connection;
            string sQuery = "UPDATE FlutterEmployees SET FirstName=@FirstName, LastName=@LastName, PhoneNumber=@PhoneNumber, Email=@Email, Gender=@Gender WHERE Id=@Id";
            dbConnection.Open();
            dbConnection.Query(sQuery, emp);
        }
    }
}
