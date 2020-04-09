using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IIsAdmin
    {
        IEnumerable<IsAdmin> GetAll { get; }
        IsAdmin GetOne(int id);
        void Add(IsAdmin _Gt);
        void Delete(int id);
        void Edit(IsAdmin _Gt);
    }
}
