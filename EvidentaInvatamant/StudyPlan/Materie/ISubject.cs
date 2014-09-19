﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISubject
    {
        int GetLargestSubjectLine();
        bool MatchesName(string name);
    }
}
