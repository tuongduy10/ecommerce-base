using ECommerce.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common.ResponseDto
{
    public class SuccessResponse<T> : Response
    {
        public T data { get; set; }
        public SuccessResponse(string _message = "success")
        {
            isSucceed = true;
            status = StatusConstant.SUCCESS;
            message = _message;
        }
        public SuccessResponse(T _data)
        {
            isSucceed = true;
            status = StatusConstant.SUCCESS;
            data = _data;
        }
        public SuccessResponse(string _message, T _data)
        {
            isSucceed = true;
            status = StatusConstant.SUCCESS;
            message = _message;
            data = _data;
        }
    }
}
