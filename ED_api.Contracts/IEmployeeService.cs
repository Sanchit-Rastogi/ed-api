using System;
using System.Collections.Generic;
using ED_api.Models;
using ED_api.ViewModels;

namespace ED_api.Contracts
{
    public interface IEmployeeService
    {
        public void Add(EmployeeDTO emp);

        public IEnumerable<EmployeeDTO> GetAll();

        public EmployeeDTO GetById(int id);

        public void Delete(int id);

        public void Update(EmployeeDTO emp);
    }
}
