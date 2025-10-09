using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktuvit.Plugin.Model
{

    public class KtuvitLoginRequestResponse
    {
        public string d { get; set; }
    }
    public class KtuvitLoginRequestResult
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }
}
