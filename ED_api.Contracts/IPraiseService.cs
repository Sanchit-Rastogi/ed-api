using System;
using System.Collections.Generic;
using ED_api.Models;
using ED_api.ViewModels;

namespace ED_api.Contracts
{
    public interface IPraiseService
    {
        public void Add(PraiseDTO praise);

        public IEnumerable<PraiseDTO> GetAll();

        public PraiseDTO GetById(int id);

        public void Delete(int id);

        public void Update(PraiseDTO praise);
    }
}
