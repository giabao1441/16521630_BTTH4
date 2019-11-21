
using System;
using System.Collections.Generic;
using System.Text;
using Projmvvm_FlowerOnline.Models;
using Projmvvm_FlowerOnline.Interface;
using System.Collections.ObjectModel;
using BTTH_Tuan4.Helper;

namespace BTTH_Tuan4.Repository
{
    class LoaihoaRepository:iLoaihoaRepository
    {
        Database db;

        public LoaihoaRepository()
        {
            db = new Database();
        }

        public Loaihoa GetLoaihoaByID(int Maloai)
        {
            return db.GetLoaihoaByID(Maloai);
        }

        public ObservableCollection<Loaihoa> GetLoaihoas()
        {
            return new ObservableCollection<Loaihoa>( db.GetLoaihoas());
        }

        public bool Insert(Loaihoa lh)
        {
            return db.InsertLoaihoa(lh);
        }

        public bool Update(Loaihoa lh)
        {
            return db.UpdateLoaihoa(lh);

        }
        public bool Delete(Loaihoa lh)
        {
            return db.DeleteLoaihoa(lh);

        }
    }
}
