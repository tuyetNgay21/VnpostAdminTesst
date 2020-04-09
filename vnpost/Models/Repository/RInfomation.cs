using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RInfomation : IInfomation
    {
        public IEnumerable<Infomation> GetAll => throw new NotImplementedException();

        public void Add(Infomation _Gt)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Infomation _Gt)
        {
            throw new NotImplementedException();
        }

        public Infomation GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
