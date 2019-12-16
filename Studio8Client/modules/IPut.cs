using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Studio8Client.modules
{
    public interface IPut
    {
        bool Put(string message);
    }
}
