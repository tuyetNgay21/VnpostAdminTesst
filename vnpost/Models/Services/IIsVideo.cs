using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IIsVideo
    {
        IEnumerable<IsVideo> GetAll { get; }
        IsVideo GetOne(int id);
        void Add(IsVideo _Gt);
        void Delete(int id);
        void Edit(IsVideo _Gt);
    }
}
