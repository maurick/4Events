﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;

namespace _4Events.ViewModel
{
    class VerhuurViewModel
    {
        public Account Account { get; set; }
        public List<Verhuur> AccountVerhuur { get; set; }
        public List<Exemplaar> ExemplaarList { get; set; }
    }
}
