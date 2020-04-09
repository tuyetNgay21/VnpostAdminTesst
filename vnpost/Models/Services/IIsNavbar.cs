using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IIsNavbar
    {
        IEnumerable<IsNavbar> GetAll();
        IEnumerable<IsNavbar> GetNavBo(int id);
        IsNavbar GetOne(int id);
        IEnumerable<IsNavSinger> GetAllSingger();
        IEnumerable<int?> ChuoiMaTHanhTruot();
        IEnumerable<IsNavSinger> GetAllSinggerChiTiet(List<IsNavbar> ik);
        void Add(int id1, int id2);
        int AddNavBegin(int id);
        void Delete(int id);
        void Edit(IsNavbar _Gt);
    }
}
