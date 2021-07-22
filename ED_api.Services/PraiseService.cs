using System;
using System.Collections.Generic;
using ED_api.Contracts;
using ED_api.Models;

namespace ED_api.Services
{
    public class PraiseService : BaseService, IPraiseService
    {
        public PraiseService(PetaPoco.Database database):base(database){}

        public void Add(Praise praise)
        {
            base.database.Save("Praise", "Id", praise);
        }

        public void Delete(int id)
        {
            base.database.Delete("Praise", "Id", id);
        }

        public IEnumerable<Praise> GetAll()
        {
            return base.database.Query<Praise>("SELECT * FROM Praise");
        }

        public Praise GetById(int id)
        {
            return base.database.Single<Praise>("SELECT * FROM Praise", id);
        }

        public void Update(Praise praise)
        {
            base.database.Update("Praise", "Id", praise);
        }
    }
}
