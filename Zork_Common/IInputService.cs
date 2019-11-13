using System;
using System.Collections.Generic;
using System.Text;

namespace Zork_Common
{
    public interface IInputService
    {
        event EventHandler<string> InputReceived;
    }
}

// polling system si more frequent than event system