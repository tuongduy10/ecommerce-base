using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace ECommerce.Dtos.UserDto
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDto : ControllerBase
    {
        public int userId { get; set; }
        public string userMail { get; set; }
        public string userFullName { get; set; }
        public DateTime userJointDate { get; set; }
        public string userAddress { get; set; }
        public string userWardCode { get; set; }
        public string userDistrictCode { get; set; }
        public string userCityCode { get; set; }
        public string userPhone { get; set; }
        public List<string> userRoles { get; set; }
        public bool status { get; set; }
        public bool isSystemAccount { get; set; }
        public bool isOnline { get; set; }
        public DateTime lastOnline { get; set; }
    }
}
