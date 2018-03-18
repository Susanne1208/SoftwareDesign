using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class OptionsViewModel : ViewModelBase, INotifyPropertyChanged
    {
        Options optionsModel = new Options();

        public OptionsViewModel() { }
        public OptionsViewModel(Options opt)
        {
            optionsModel = opt;
        }

        public double MusicVolume
        {
            get { return optionsModel.MusicVolume; }
            set
            {
                optionsModel.MusicVolume = value;
                NotifyPropertyChanged();
            }
        }

        public double SoundVolume
        {
            get { return optionsModel.SoundVolume; }
            set
            {
                optionsModel.SoundVolume = value;
                NotifyPropertyChanged();
            }
        }
    }
}
