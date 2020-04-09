using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsMenuSinger1 : IIsMenuSinger1
    {

        public void Add(int id1, int id2)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                int k = db.IsMenuSinger1.Where(m => m.BoN == id2).Count();
                //add mot nav voi bonav = null
                IsMenuSinger1 _Gt = new IsMenuSinger1();
                _Gt.ThemeId = id1;
                _Gt.Stt = k + 1;
                _Gt.BoN = id2;
                db.IsMenuSinger1.Add(_Gt);
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public int AddNavBegin(int id)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                //add mot nav voi bonav = null
                IsMenuSinger1 _Gt = new IsMenuSinger1();
                _Gt.ThemeId = id;
                _Gt.Stt = 1;
                _Gt.BoN = null;
                db.IsMenuSinger1.Add(_Gt);
                db.SaveChanges();
                // lay ra so vua addd
                var NavVuaThem = db.IsMenuSinger1.Where(m => m.ThemeId == id && m.Stt == 1).FirstOrDefault();//gap van de ve csdl tai vi tri nay
                NavVuaThem.BoN = NavVuaThem.MenuId;
                db.SaveChanges();
                return NavVuaThem.MenuId;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(IsMenuSinger1 _Gt)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int?> GetAll()
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            try
            {
                return db.IsMenuSinger1.OrderBy(m => m.BoN).Select(n => n.BoN).Distinct().ToList();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsTheme> GetAllSingerMenu(List<IsMenuSinger1> ik)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                List<IsTheme> kk = new List<IsTheme>();
                foreach (var ki in ik)
                {
                    kk.Add(db.IsTheme.Where(m => m.ThemeId == ki.ThemeId).FirstOrDefault());
                }
                return kk;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsTheme> GetAllTheme()
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            try
            {
                return db.IsTheme.Where(m => m.Deleted == false).ToList();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }

        }

        public IEnumerable<IsMenuSinger1> GetAllThemeHaveId(int id)
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            try
            {
                return db.IsMenuSinger1.Where(m => m.BoN == id).ToList();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IsMenuSinger1 GetOne(int id)
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            try
            {
                return db.IsMenuSinger1.Where(m => m.MenuId == id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
