//using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;

namespace MLearning.Core.Entities.json
{
    public class Loitem : INotifyPropertyChanged
    {
        public string lotext { get; set; }
        public string loimage { get; set; }

        byte[] _image_bytes;

        public event PropertyChangedEventHandler PropertyChanged;

        public byte[] image_bytes
        {
            get { return _image_bytes; }
            set { _image_bytes = value; OnPropertyChanged("image_bytes"); }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Loitemize
    {
        public List<Loitem> loitem { get; set; }
    }

    public class Loslide : INotifyPropertyChanged
    {
        public string lotitle { get; set; }
        public string loparagraph { get; set; }
        public string loimage { get; set; } //url


        byte[] _image_bytes;

        public event PropertyChangedEventHandler PropertyChanged;

        public byte[] image_bytes
        {
            get { return _image_bytes; }
            set { _image_bytes = value; OnPropertyChanged("image_bytes"); }
        }


        public int lotype { get; set; }
        public Loitemize loitemize { get; set; }
        public string lotext { get; set; }
        public string loauthor { get; set; }
        public string lovideo { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Lopage
    {
        public List<Loslide> loslide { get; set; }
    }

    public class LOContent
    {
        public Lopage lopage { get; set; }
    }
}
