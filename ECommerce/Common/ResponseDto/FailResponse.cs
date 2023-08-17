using ECommerce.Common.ResponseDto;
using ECommerce.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common
{
    public class FailResponse : Response
    {
        public FailResponse(string _message)
        {
            isSucceed = false;
            status = StatusConstant.FAIL;
            message = _message;
        }
    }
}
