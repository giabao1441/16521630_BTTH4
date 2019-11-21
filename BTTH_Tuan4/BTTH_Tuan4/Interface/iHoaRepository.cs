using Projmvvm_FlowerOnline.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Projmvvm_FlowerOnline.Interface
{
    public interface iHoaRepository
    {
        ObservableCollection<Hoa> GetHoas();
        Hoa GetHoaByID(int Maloai);
        bool Insert(Hoa h);
        bool Update(Hoa h);
        bool Delete(Hoa h);

    }
}
