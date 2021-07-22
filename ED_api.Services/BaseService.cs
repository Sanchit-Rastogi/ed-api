using System;
namespace ED_api.Services
{
    public class BaseService
    {
        public PetaPoco.Database database { get; set; }

        public BaseService(PetaPoco.Database db)
        {
            database = db;
        }
    }
}
