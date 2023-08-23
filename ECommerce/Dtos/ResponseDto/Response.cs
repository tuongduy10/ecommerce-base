﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Dtos.ResponseDto
{
    public class Response<T>
    {
        public bool isSuccess { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }
}
