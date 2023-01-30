using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetHelpers
{
    public class QueryStringManager
    {
        public NameValueCollection Parse(string queryString)
        {
            if (string.IsNullOrWhiteSpace(queryString))
            {
                throw new ArgumentNullException(nameof(queryString));
            }

            NameValueCollection queryParameters = new();
            string[] queryParts = queryString.Split('&');
            foreach (string part in queryParts)
            {
                string _part = part.Replace("?", string.Empty);
                string[] parameter = _part.Split('=');
                if (parameter.Count() > 1)
                {
                    queryParameters.Add(parameter[0], parameter[1]);
                }
                else
                {
                    queryParameters.Add(parameter[0], "");
                }

            }
            return queryParameters;
        }        

    }
}
