using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vermelhinha
{
    public interface IJavaScriptExecutor
    {
        object ExecuteAsyncScript(string script, params object[] args);
        object ExecuteScript(string script, params object[] args);
    }
}
