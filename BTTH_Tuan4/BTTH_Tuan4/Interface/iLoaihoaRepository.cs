using Projmvvm_FlowerOnline.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Projmvvm_FlowerOnline.Interface
{
    public interface iLoaihoaRepository
    {
        ObservableCollection<Loaihoa> GetLoaihoas();
        Loaihoa GetLoaihoaByID(int Maloai);
        bool Insert(Loaihoa lh);
        bool Update(Loaihoa lh);
        bool Delete(Loaihoa lh);

    }
}
