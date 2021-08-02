using System;
using System.Collections.Generic;
using AutoMapper;
using ED_api.Contracts;
using ED_api.Models;
using ED_api.ViewModels;

namespace ED_api.Services
{
    public class PraiseService : BaseService, IPraiseService
    {
        private readonly IMapper mapper;

        public PraiseService(PetaPoco.Database database, IMapper mapper) :base(database){
            this.mapper = mapper;
        }

        public void Add(PraiseDTO praise)
        {
            var p = this.mapper.Map<Praise>(praise);
            base.database.Insert(p);
        }

        public void Delete(int id)
        {
            base.database.Delete<Praise>(id);
        }

        public IEnumerable<PraiseDTO> GetAll()
        {
            var p = base.database.Fetch<Praise>();
            return this.mapper.Map<List<PraiseDTO>>(p);
        }

        public PraiseDTO GetById(int id)
        {
            var p = base.database.SingleOrDefault<Praise>(id);

            return this.mapper.Map<PraiseDTO>(p);
        }

        public void Update(PraiseDTO praise)
        {
            var p = this.mapper.Map<Praise>(praise);
            base.database.Update(p);
        }
    }
}
