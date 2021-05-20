using System;
using System.Collections.Generic;
using System.Text;

namespace DapperORM_Database
{
    interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(); //Stubbed out method
    }
}
