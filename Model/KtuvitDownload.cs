using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktuvit.Plugin.Model
{

    public class  KtuvitSubtitleDetails
    {
        public string Title { get; set; }
        public string SubtitleID { get; set; }
    }
    public class KtuvitDownloadRequestResponse
    {
        public string d { get; set; }
    }
    public class KtuvitDownloadRequestResult
    {
        public int ValidIn { get; set; }
        public string DownloadIdentifier { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }
}
