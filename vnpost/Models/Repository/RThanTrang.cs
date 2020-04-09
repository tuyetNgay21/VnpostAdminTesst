using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RThanTrang : IThanTrang
    {
        public IEnumerable<ThanTrang> GetAll => throw new NotImplementedException();

        public void Add(ThanTrang _Gt)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ThanTrang _Gt)
        {
            throw new NotImplementedException();
        }

        public ThanTrang GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
