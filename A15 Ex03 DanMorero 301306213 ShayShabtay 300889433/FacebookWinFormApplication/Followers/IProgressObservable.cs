using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    public interface IProgressObservable
    {
        /// <summary>
        /// Notify method from observer pattern.
        /// </summary>
        /// <param name="i_Percent"></param>
        void UpdateObserverProgress(int i_Percent); 

        /// <summary>
        /// Attach and detach methods from observer pattern.
        /// </summary>
        IProgressObserver ProgressObserver { get; set; }
    }
}
