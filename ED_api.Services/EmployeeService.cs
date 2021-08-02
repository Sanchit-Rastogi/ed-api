using System.Collections.Generic;
using AutoMapper;
using ED_api.Contracts;
using ED_api.Models;
using ED_api.ViewModels;

namespace ED_api.Services
{

    public class EmployeeService : BaseService, IEmployeeService
    {

        private readonly IMapper mapper;

        public EmployeeService(PetaPoco.Database database, IMapper mapper):base(database){
            this.mapper = mapper;
        }

        public void Add(EmployeeDTO emp)
        {
            var employee = this.mapper.Map<Employee>(emp);
            base.database.Insert(employee);
        }

        public void Delete(int id)
        {
            base.database.Delete<Employee>(id);
        }

        public IEnumerable<EmployeeDTO> GetAll()
        {
           var employee = base.database.Fetch<Employee>();
            return this.mapper.Map<List<EmployeeDTO>>(employee);
        }

        public EmployeeDTO GetById(int id)
        {
            var employee = base.database.SingleOrDefault<Employee>(id);

            return this.mapper.Map<EmployeeDTO>(employee);
        }

        public void Update(EmployeeDTO emp)
        {
            var employee = this.mapper.Map<Employee>(emp);
            base.database.Update(employee);
        }
    }
}
