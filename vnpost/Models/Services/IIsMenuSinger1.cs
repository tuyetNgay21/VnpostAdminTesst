using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IIsMenuSinger1
    {
        IEnumerable<int?> GetAll();
        IEnumerable<IsTheme> GetAllTheme();
        IEnumerable<IsMenuSinger1> GetAllThemeHaveId(int id);
        IEnumerable<IsTheme> GetAllSingerMenu(List<IsMenuSinger1> ik);
        IsMenuSinger1 GetOne(int id);
        void Add(int id1, int id2);
        int AddNavBegin(int id);
        void Delete(int id);
        void Edit(IsMenuSinger1 _Gt);
    }
}
