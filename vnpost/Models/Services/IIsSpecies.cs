using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;

namespace vnpost.Models.Services
{
    public interface IIsSpecies
    {

        IEnumerable<IsSpecies> GetAll();
        IEnumerable<IsTheme> GetAllTheme();
        IsSpecies GetOne(int id);
        void Add(IsSpecies _Gt);
        void Delete(int id);
        void Edit(IsSpecies _Gt);
    }
}
