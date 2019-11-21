using Projmvvm_FlowerOnline.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;


namespace BTTH_Tuan4.Helper
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public Database()
        {
            try
            {
                //tao csdl
                using (var connection = new 
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    //tao bang
                    connection.CreateTable<Loaihoa>();
                    connection.CreateTable<Hoa>();
                }
            }
            catch(SQLiteException ex)
            {
                
            }
        }
        #region "Loại hoa"
        public List<Loaihoa>GetLoaihoas()
        {
            try
            {
                using (var connection = new 
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Loaihoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }

        public Loaihoa GetLoaihoaByID(int Maloai)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var dsh = from lhs in connection.Table<Loaihoa>().ToList()
                              where lhs.Maloai == Maloai
                              select lhs
                              ;
                    return dsh.ToList<Loaihoa>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }

        public bool InsertLoaihoa(Loaihoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(lh);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        public bool UpdateLoaihoa(Loaihoa lh)
        {
            try
            {
                using( var connection = new SQLiteConnection(System.IO.Path.Combine(folder)))
                {
                    connection.Update(lh);
                    return true;
                }
            }
            catch(SQLiteException ex)
            {
                return false;
            }
        }

        public bool DeleteLoaihoa(Loaihoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "dlhoa.db")))
                {
                    connection.Delete(lh);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
        #endregion

        #region "Hoa"
        public List<Hoa> GetHoas()
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }

        public Hoa GetHoaByID(int Maloai)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var dsh = from lhs in connection.Table<Hoa>().ToList()
                              where lhs.Maloai == Maloai
                              select lhs
                              ;
                    return dsh.ToList<Hoa>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }

        public bool InsertHoa(Hoa h)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        public bool UpdateHoa(Hoa h)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder)))
                {
                    connection.Update(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        public bool DeleteHoa(Hoa h)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "dlhoa.db")))
                {
                    connection.Delete(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
        #endregion
    }
}