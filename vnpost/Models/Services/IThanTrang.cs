using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IThanTrang
    {
        IEnumerable<ThanTrang> GetAll { get; }
        ThanTrang GetOne(int id);
        void Add(ThanTrang _Gt);
        void Delete(int id);
        void Edit(ThanTrang _Gt);
    }
}
