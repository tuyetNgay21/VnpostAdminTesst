using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
   public interface IIsTheme
    {
        IEnumerable<IsTheme> GetAll();
        IsTheme GetOne(int id);
        void Add(IsTheme _Gt);
        void Delete(int id);
        void Edit(IsTheme _Gt);
    }
}
