using Core.Common;
using System;

namespace Core.Models
{
    public class Details : Entity
    {
        public string Url { get; private set; }
        public string BearerToken { get; private set; }
        public ENV Env { get; private set; }
        public DateTime ExpiresAt { get; private set; }
        public string ApplicationInsights { get; private set; }

        public Details(string url, string bearerToken, ENV env, string appInsights)
        {
            Url = url;
            BearerToken = bearerToken;
            Env = env;
            ApplicationInsights = appInsights;

            ProcessToken();
        }

        public void SetToken(string token)
        {
            BearerToken = token;

            ProcessToken();
        }

        /// <summary>
        /// Calculate ex. enddate or other components of a bearer token 
        /// </summary>
        public void ProcessToken()
        {
        }
    }
}
