using BTTH_Tuan4.Helper;
using Projmvvm_FlowerOnline.Interface;
using Projmvvm_FlowerOnline.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BTTH_Tuan4.Repository
{
    class HoaRepository : iHoaRepository
    {
        Database db;

        public HoaRepository()
        {
            db = new Database();
        }

        public Hoa GetHoaByID(int Maloai)
        {
            return db.GetHoaByID(Maloai);
        }

        public ObservableCollection<Hoa> GetHoas()
        {
            return new ObservableCollection<Hoa>(db.GetHoas());
        }

        public bool Insert(Hoa h)
        {
            return db.InsertHoa(h);
        }

        public bool Update(Hoa h)
        {
            return db.UpdateHoa(h);

        }
        public bool Delete(Hoa h)
        {
            return db.DeleteHoa(h);
        }          
    }
    }
