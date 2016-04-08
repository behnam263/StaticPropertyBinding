using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticBindingTest
{


    public static class model
    {
        public static event EventHandler modelTitleChanged;

        private static string _modelTitle;
        public static string modelTitle
        {
            get { return _modelTitle; }
            set
            {
                if (value != _modelTitle)
                {
                    _modelTitle = value;

                    if (modelTitleChanged != null)
                        modelTitleChanged(null, EventArgs.Empty);
                }
            }
        }
    }
}
