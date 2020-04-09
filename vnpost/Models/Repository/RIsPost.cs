using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsPost : IIsPost
    {
        

        public void Add(IsPost _Gt)
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
                IsPost Gt = db.IsPost.Where(m => m.PostId == id).FirstOrDefault();
                Gt.Deleted = true;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void Edit(IsPost _Gt)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                IsPost Gt = db.IsPost.Where(m => m.PostId == _Gt.PostId).FirstOrDefault();
                Gt.Title = _Gt.Title;
                Gt.Deleted = _Gt.Deleted;
                Gt.AvataIndex = _Gt.AvataIndex;
                Gt.Content = _Gt.Content;
                Gt.SpeciesId = _Gt.SpeciesId;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsPost> GetAll()
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();

                List<IsPost> a = db.IsPost.ToList();
                return a;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsTheme> GetAllChuDe()
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

        public IEnumerable<IsSpecies> GetAllLoaiChuDe()
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

        public IsPost GetOne(int id)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                return db.IsPost.Where(m => m.PostId == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
