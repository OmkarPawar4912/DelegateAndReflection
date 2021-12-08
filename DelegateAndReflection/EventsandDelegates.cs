using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAndReflection
{
    public class EventsandDelegates
    {
        public event Action OnChange = delegate { };
        public void Raise()
        {
            OnChange();
        }
    }
}
