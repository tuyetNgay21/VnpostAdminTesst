using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsNavSinger : IIsNavSinger
    {

        public void Add(IsNavSinger _Gt)
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
                IsNavSinger Gt = db.IsNavSinger.Where(m => m.NavbarSingerId == id).FirstOrDefault();
                Gt.Deleted = true;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void Edit(IsNavSinger _Gt)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                IsNavSinger Gt = db.IsNavSinger.Where(m => m.NavbarSingerId == _Gt.NavbarSingerId).FirstOrDefault();
                Gt.Title = _Gt.Title;
                Gt.Deleted = _Gt.Deleted;
                Gt.DateUpdate = DateTime.Now;
                Gt.ImageSinger = _Gt.ImageSinger;
                Gt.LinkImage = _Gt.LinkImage;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsNavSinger> GetAll()
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();

                List<IsNavSinger> a = db.IsNavSinger.ToList();
                return a;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IsNavSinger GetOne(int id)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                return db.IsNavSinger.Where(m => m.NavbarSingerId == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
