﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
        public void DeleteDepartment(string name);

        public void InsertDepartment(string name);
        
    }
}
