using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FerreteriaSL
{
    public static class CommonStringParser
    {
        public static string EscapeSQLQuery(string Query)
        {
            return Query.Replace("'", "\\'");
        }
    }
}
