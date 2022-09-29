using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class BusinessException : Exception
    {
        public BusinessException()
        {
        }

        public BusinessException(string messege)
            : base(messege)
        {
        }
    }
}
