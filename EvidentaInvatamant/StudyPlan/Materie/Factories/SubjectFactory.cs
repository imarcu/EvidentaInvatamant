﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant.Materie
{
    class SubjectFactory:ISubjectFactory
    {
        public ISubject Make()
        {
            return new Subject();
        }
    }
}
