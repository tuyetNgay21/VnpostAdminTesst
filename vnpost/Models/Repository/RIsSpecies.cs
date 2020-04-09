using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsSpecies : IIsSpecies
    {
        

        public void Add(IsSpecies _Gt)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                if(_Gt.ThemeDab==0)
                {
                    _Gt.ThemeDab = _Gt.SpeciesId;
                }
                db.Add(_Gt);
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(int id)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                IsSpecies Gt = db.IsSpecies.Where(m => m.SpeciesId == id).FirstOrDefault();
                Gt.Deleted = true;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void Edit(IsSpecies _Gt)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                IsSpecies Gt = db.IsSpecies.Where(m => m.SpeciesId == _Gt.ThemeId).FirstOrDefault();
                Gt.Isname = _Gt.Isname;
                Gt.IsTitle = _Gt.IsTitle;
                Gt.Deleted = _Gt.Deleted;
                Gt.AvatarSpecies = _Gt.AvatarSpecies;
                Gt.ThemeId = _Gt.ThemeId;
                Gt.ThemeDab = _Gt.ThemeDab;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsSpecies> GetAll()
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();

                List<IsSpecies> a = db.IsSpecies.ToList();
                return a;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsTheme> GetAllTheme()
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();

                List<IsTheme> a = db.IsTheme.ToList();
                return a;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IsSpecies GetOne(int id)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                return db.IsSpecies.Where(m => m.SpeciesId == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
