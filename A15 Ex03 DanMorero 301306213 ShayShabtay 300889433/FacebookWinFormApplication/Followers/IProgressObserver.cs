using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    public interface IProgressObserver
    {
        void UpdateProgress(int i_Percent);
    }
}
