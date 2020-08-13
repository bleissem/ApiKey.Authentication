using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiKey.Authentication
{
    public class ApiKeyValidator: IApiKeyValidator
    {
        public bool IsValidKey(IApiKey apiKey, string key)
        {
            if ((apiKey?.Key == null) || String.IsNullOrWhiteSpace(key))
            {
                return false;
            }

            return String.Equals(apiKey.Key, key, apiKey.StringComparison);
           
        }
    }
}
