using System;
using System.Collections.Generic;
using System.Text;

namespace ApiKey.Authentication
{
    public interface IApiKeyValidator
    {
        bool IsValidKey(IApiKey apiKey, string key);
    }
}
