using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace XR.Mono.Perforce
{
    public class P4Exception : Exception {
        public P4Exception( string msg ) : base (msg) {

        }
    }
    
}
