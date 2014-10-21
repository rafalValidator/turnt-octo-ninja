using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyArchive.Util
{
    class ActivityLogger
    {
        ITextDisplay _textDisplay;

        public ActivityLogger(ITextDisplay textDisplay)
        {
            _textDisplay = textDisplay;
        }

        public void Show(string msg)
        {
            _textDisplay.Show(msg);
        }
    }
}
