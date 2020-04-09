using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IIsPost
    {

        IEnumerable<IsPost> GetAll();
        IEnumerable<IsTheme> GetAllChuDe();
        IEnumerable<IsSpecies> GetAllLoaiChuDe();
        IsPost GetOne(int id);
        void Add(IsPost _Gt);
        void Delete(int id);
        void Edit(IsPost _Gt);
    }
}
