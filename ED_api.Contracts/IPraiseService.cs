using System;
using System.Collections.Generic;
using ED_api.Models;

namespace ED_api.Contracts
{
    public interface IPraiseService
    {
        public void Add(Praise praise);

        public IEnumerable<Praise> GetAll();

        public Praise GetById(int id);

        public void Delete(int id);

        public void Update(Praise praise);
    }
}
