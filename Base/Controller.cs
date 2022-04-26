using System;
using System.Collections.Generic;
using System.Text;
//udf
using MyApplication.Core;

namespace MyApplication.Base
{
    public abstract class Controller
    {
        protected readonly Bootstrap Function;
        public Controller(Bootstrap wrapper)
        {
            Function = wrapper;
        }
    }
}
