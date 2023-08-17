﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeCode { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
