using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IIsLogin
    {
        IEnumerable<IsLogin> GetAll { get; }
        IsLogin GetOne(int id);
        void Add(IsLogin _Gt);
        void Delete(int id);
        void Edit(IsLogin _Gt);
    }
}
