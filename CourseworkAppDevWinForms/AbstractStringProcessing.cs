using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_AppDev
{
    abstract class AbstractStringProcessing
    {
        public abstract string S { get; set; }
        public abstract int N { get; set; }
        public abstract void Encode();
        public abstract string Print();
        public abstract string InputCode();
        public abstract string OutputCode();
        public abstract string Sort();
    }
}
