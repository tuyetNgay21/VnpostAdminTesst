using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IInfomation
    {
        IEnumerable<Infomation> GetAll { get; }
        Infomation GetOne(int id);
        void Add(Infomation _Gt);
        void Delete(int id);
        void Edit(Infomation _Gt);
    }
}
