﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Classes
{
    public interface IEnumerable<T>
    {
        public IEnumerator GetEnumerator();
         
    }
}
