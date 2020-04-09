using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsLogin : IIsLogin
    {
        public IEnumerable<IsLogin> GetAll => throw new NotImplementedException();

        public void Add(IsLogin _Gt)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(IsLogin _Gt)
        {
            throw new NotImplementedException();
        }

        public IsLogin GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
