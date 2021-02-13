using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMaster
{
    class ErrorHandler
    {
        public static ErrorHandler instance;

        public void InitializeInstance() => instance = this;
    }
}
