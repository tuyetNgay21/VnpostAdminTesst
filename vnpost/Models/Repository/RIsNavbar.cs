using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vnpost.Models;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Models.Repository
{
    public class RIsNavbar : IIsNavbar
    {
     
        public void Add(int id1, int id2)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                int k = db.IsNavbar.Where(m => m.BoNavBar == id2).Count();
                //add mot nav voi bonav = null
                IsNavbar _Gt = new IsNavbar();
                _Gt.NavbarSingerId = id1;
                _Gt.Stt = k+1;
                _Gt.BoNavBar = id2;
                db.IsNavbar.Add(_Gt);
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
                IsNavbar _Gt = new IsNavbar();
                _Gt.NavbarSingerId = id;
                _Gt.Stt = 1;
                _Gt.BoNavBar = null;
                db.IsNavbar.Add(_Gt);
                db.SaveChanges();
                // lay ra so vua addd
                var NavVuaThem = db.IsNavbar.Where(m => m.NavbarSingerId == id && m.Stt == 1).FirstOrDefault();//gap van de ve csdl tai vi tri nay
                NavVuaThem.BoNavBar = NavVuaThem.NavbarId;
                db.SaveChanges();
                return NavVuaThem.NavbarId;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<int?> ChuoiMaTHanhTruot()
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            try
            {
               var li= db.IsNavbar.OrderBy(m=>m.BoNavBar).Select(m=>m.BoNavBar).Distinct().ToList();
                return li;
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

        public void Edit(IsNavbar _Gt)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IsNavbar> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IsNavSinger> GetAllSingger()
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            try
            {
                return db.IsNavSinger.Where(m=>m.Deleted==false).ToList();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsNavSinger> GetAllSinggerChiTiet(List<IsNavbar> ik)
        {
            try
            {
                TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
                List<IsNavSinger> kk = new List<IsNavSinger>();
                foreach(var ki in ik)
                {
                    kk.Add(db.IsNavSinger.Where(m => m.NavbarSingerId == ki.NavbarSingerId).FirstOrDefault());
                }
                return kk;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsNavbar> GetNavBo(int id)
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            try
            {
                return db.IsNavbar.Where(m => m.BoNavBar==id).ToList();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IsNavbar GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
