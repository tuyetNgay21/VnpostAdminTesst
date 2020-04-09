using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IIsNavSinger
    {
        IEnumerable<IsNavSinger> GetAll();
        IsNavSinger GetOne(int id);
        void Add(IsNavSinger _Gt);
        void Delete(int id);
        void Edit(IsNavSinger _Gt);
    }
}
