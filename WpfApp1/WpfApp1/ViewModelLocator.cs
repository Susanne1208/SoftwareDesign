using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ViewModelLocator
    {
        public OptionsViewModel OptionsViewModel
        {
            get
            {
                return new OptionsViewModel(new Options());
            }
        }

    }
}
