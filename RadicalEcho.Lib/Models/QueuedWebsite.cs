using System;
using System.Collections.Generic;
using System.Text;

namespace RadicalEcho.Lib.Models
{
    public class QueuedWebsite
    {
        public string Url { get; set; }
        public WebsiteModel Parent { get; set; }
    }
}
