using BTTH_Tuan4.Repository;
using Projmvvm_FlowerOnline.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTTH_Tuan4.ViewModels
{
    class HoaViewModel : INotifyPropertyChanged
    {
        
        private Hoa hoa;
        public HoaRepository hoaRepository;
        public ICommand AddHoa { get; private set; }
        public ICommand UpdateHoa { get; private set; }
        public ICommand DeleteHoa { get; private set; }
        

        public HoaViewModel()
        {
            hoa = new Hoa();
            hoaRepository = new HoaRepository();
            LoadHoa();
            AddHoa = new Command(Insert);
            UpdateHoa = new Command(Update, CanEx);
            DeleteHoa = new Command(Delete, CanEx);
        }
        private void LoadHoa()
        {
            HoaList = hoaRepository.GetHoas();
        }
        ObservableCollection<Hoa> hoaList;
        public ObservableCollection<Hoa> HoaList
        {
            get { return hoaList; }
            set
            {
                hoaList = value;
                RaisePropertyChanged("HoaList");
            }
        }
        private Hoa Hoa
        {
            get { return hoa; }
            set { hoa = value;
                RaisePropertyChanged("Hoa");
                ((Command)UpdateHoa).ChangeCanExecute();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        private bool CanEx()
        {
            if (hoa == null || hoa.Mahoa == 0)
                return false;
            else
                return true;
        }
        public void Insert()
        {
            hoaRepository.Insert(hoa);
            LoadHoa();
        }
        public void Update()
        {
            hoaRepository.Update(hoa);
            LoadHoa();
        }
        public void Delete()
        {
            hoaRepository.Delete(hoa);
            LoadHoa();
        }

        public int Maloai
        {
            get { return Hoa.Maloai; }
            set
            {
                Hoa.Maloai = value;
                RaisePropertyChanged("Maloai");
            }
        }

        public int Mahoa
        {
            get { return Hoa.Mahoa; }
            set
            {
                Hoa.Mahoa = value;
                RaisePropertyChanged("Mahoa");
            }
        }
        public string Tenhhoa
        {
            get { return Hoa.Tenhoa; }
            set
            {
                Hoa.Tenhoa = value;
                RaisePropertyChanged("Tenhhoa");
            }
        }
        public string Mota
        {
            get { return Hoa.Mota; }
            set
            {
                Hoa.Mota = value;
                RaisePropertyChanged("Mota");
            }
        }
        public double Gia
        {
            get { return Hoa.Gia; }
            set
            {
                Hoa.Gia = value;
                RaisePropertyChanged("Gia");
            }
        }
    }
}
