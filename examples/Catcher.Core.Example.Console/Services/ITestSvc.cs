﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Catcher.Core.Example.Console.Services
{
    public interface ITestSvc : IAuditable
    {
        string Test1(int a, int b);
        void Test2();
    }
}