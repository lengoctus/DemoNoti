﻿using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Efmigrationshistory
    {
        public string MigrationId { get; set; } = null!;
        public string ProductVersion { get; set; } = null!;
    }
}
