using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsTheme : IIsTheme
    {
        
        public IEnumerable<IsTheme> GetAll() {
            try
            {
             TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();

                List<IsTheme> a =db.IsTheme.ToList();
                return a;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void Add(IsTheme _Gt)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();

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
                IsTheme Gt = db.IsTheme.Where(m => m.ThemeId == id).FirstOrDefault();
                Gt.Deleted = true;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void Edit(IsTheme _Gt)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                IsTheme Gt= db.IsTheme.Where(m=>m.ThemeId==_Gt.ThemeId).FirstOrDefault();
                Gt.Isname = _Gt.Isname;
                Gt.IsTitle = _Gt.IsTitle;
                Gt.Deleted = _Gt.Deleted;
                Gt.AvatarTheme = _Gt.AvatarTheme;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IsTheme GetOne(int id)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                return db.IsTheme.Where(m => m.ThemeId == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
