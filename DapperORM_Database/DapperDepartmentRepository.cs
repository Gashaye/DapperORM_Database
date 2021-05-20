using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperORM_Database
{
    class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;
        //Constructor
        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }
        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
                                new { departmentName = newDepartmentName });
        }
        public void UpdateDepartment(string updatedDepartmentName, int id)

        {
            _connection.Execute("update Departments set Name = 'ThinkPad laptop' where @DepartmentID = 8;", new { departmentName = updatedDepartmentName, DepartmentID = id});

        }



    }
}
