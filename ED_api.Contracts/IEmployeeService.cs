using System;
using System.Collections.Generic;
using ED_api.Models;

namespace ED_api.Contracts
{
    public interface IEmployeeService
    {
        public void Add(Employee emp);

        public IEnumerable<Employee> GetAll();

        public Employee GetById(int id);

        public void Delete(int id);

        public void Update(Employee emp);
    }
}
