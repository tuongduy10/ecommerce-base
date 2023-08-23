using ECommerce.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Dtos.ResponseDto
{
    public class FailResponse<T> : Response<T>
    {
        public FailResponse(string _message)
        {
            isSuccess = false;
            status = StatusConstant.FAIL;
            message = _message;
        }
    }
}
