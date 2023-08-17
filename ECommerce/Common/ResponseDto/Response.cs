using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common.ResponseDto
{
    public class Response
    {
        public bool isSucceed { get; set; }
        public string status { get; set; }
        public string message { get; set; }
    }
}
