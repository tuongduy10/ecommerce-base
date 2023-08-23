using ECommerce.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Dtos.ResponseDto
{
    public class SuccessResponse<T> : Response<T>
    {
        public SuccessResponse(string _message = "success")
        {
            isSuccess = true;
            status = StatusConstant.SUCCESS;
            message = _message;
        }
        public SuccessResponse(T _data)
        {
            isSuccess = true;
            status = StatusConstant.SUCCESS;
            data = _data;
        }
        public SuccessResponse(string _message, T _data)
        {
            isSuccess = true;
            status = StatusConstant.SUCCESS;
            message = _message;
            data = _data;
        }
    }
}
