using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsAdmin : IIsAdmin
    {
        public IEnumerable<IsAdmin> GetAll => throw new NotImplementedException();

        public void Add(IsAdmin _Gt)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(IsAdmin _Gt)
        {
            throw new NotImplementedException();
        }

        public IsAdmin GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
