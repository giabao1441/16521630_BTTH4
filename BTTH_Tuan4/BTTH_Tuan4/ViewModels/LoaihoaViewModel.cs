using BTTH_Tuan4.Repository;
using Projmvvm_FlowerOnline.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTTH_Tuan4.ViewModels
{
    class LoaihoaViewModel: INotifyPropertyChanged
    {
        private Loaihoa loaihoa;
        public LoaihoaRepository loaihoaRepository;
        public ICommand AddLoaihoa { get; private set; }
        public ICommand UpdateLoaihoa { get; private set; }
        public ICommand DeleteLoaihoa { get; private set; }

        public LoaihoaViewModel()
        {
            loaihoa = new Loaihoa();
            loaihoaRepository = new LoaihoaRepository();
            LoadLoaihoa();
            AddLoaihoa = new Command(Insert);
            UpdateLoaihoa = new Command(Update, CanEx);
            DeleteLoaihoa = new Command(Delete, CanEx);
        }

      

        private bool CanEx()
        {
            if (Loaihoa == null || Loaihoa.Maloai == 0)
                return false;
            else
                return true;
        }
        private void Delete()
        {
            loaihoaRepository.Delete(loaihoa);
            LoadLoaihoa();
        }
        private void Update()
        {
            loaihoaRepository.Update(loaihoa);
            LoadLoaihoa();
        }
        private void Insert()
        {
            loaihoaRepository.Insert(loaihoa);
            LoadLoaihoa();
        }
        public Loaihoa Loaihoa
        {
            get { return loaihoa; }
            set
            {
                loaihoa = value;
                RaisePropertyChanged("Loaihoa");
                ((Command)UpdateLoaihoa).ChangeCanExecute();
            }
        }

        public int Maloai
        {
            get { return loaihoa.Maloai; }
            set
            {
                loaihoa.Maloai = value;
                RaisePropertyChanged("Maloai");
            }
        } 

        public string Tenloai
        {
            get { return loaihoa.Tenloai; }
            set
            {
                loaihoa.Tenloai = value;
                RaisePropertyChanged("Tenloai");
            }
        }
        private void LoadLoaihoa()
        {
            LoaihoaList = loaihoaRepository.GetLoaihoas();
        }

        ObservableCollection<Loaihoa> loaihoaList;
        public ObservableCollection<Loaihoa> LoaihoaList
        {
            get { return loaihoaList; }
            set { loaihoaList = value;
                RaisePropertyChanged("LoaihoaList");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
