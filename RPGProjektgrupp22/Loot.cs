﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public interface Loot
    {
        public int Gold { get; }
        public Equipable Item { get; }
    }
}
