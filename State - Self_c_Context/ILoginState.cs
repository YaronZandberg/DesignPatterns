using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Self_c_Context
{
    public interface ILoginState
    {
        void Login(string password);

        void Restart();
    }
}
