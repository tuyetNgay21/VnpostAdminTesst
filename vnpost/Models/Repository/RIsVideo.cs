using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsVideo : IIsVideo
    {
        public IEnumerable<IsVideo> GetAll => throw new NotImplementedException();

        public void Add(IsVideo _Gt)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(IsVideo _Gt)
        {
            throw new NotImplementedException();
        }

        public IsVideo GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
