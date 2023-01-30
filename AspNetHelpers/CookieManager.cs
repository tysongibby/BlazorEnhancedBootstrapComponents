using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspNetHelpers
{
    /// <summary>
    /// Helper for creating, retrieving, deleting, and determining existential status of cookies.
    /// </summary>
    public class CookieManager
    {
        /// <summary>
        /// Creates and saves a cookie with the expiry time set in minutes. If no expiry is given, expiration of cookie is set to 30 seconds.
        /// </summary>
        /// <param name="httpContext">HttpContext for the cookie to be created.</param>
        /// <param name="key">Name of the lookup key for value to be stored in cookie.</param>
        /// <param name="value">Value to be stored in cookie to be created.</param>
        /// <param name="expiryTime">Expiry time in minutes for the cookie to be created.</param>
        public void Set(HttpContext httpContext, string key, string value, int? expiryTime)
        {
            if (httpContext is null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            CookieOptions cookieOptions = new CookieOptions();

            if (expiryTime is not null)
            {
                cookieOptions.Expires = DateTime.Now.AddMinutes((double)expiryTime);
            }
            else
            {
                cookieOptions.Expires = DateTime.Now.AddSeconds(30);
            }

            httpContext.Response.Cookies.Append(key, value, cookieOptions);
        }

        /// <summary>
        /// Returns cookie for corresponding key in HttpContext. If cookie does not exist, null is returned.
        /// </summary>
        /// <param name="httpContext">HttpContext for cookie in question.</param>
        /// <param name="key">Lookup key for cookie in question.</param>
        /// <returns></returns>
        public string Get(HttpContext httpContext, string key)
        {
            if (httpContext is null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (Exists(httpContext, key))
            {
                return httpContext.Request.Cookies[key];
            }
            else
            {
                return null;
            }


        }

        /// <summary>
        /// Deletes cookie. Returns true if cookies has been successfully deleted, returns false if the cookie has not been deleted.
        /// </summary>
        /// <param name="httpContext">HttpContext for the cookie to be deleted.</param>
        /// <param name="key">Name of lookup key for the cookie to be deleted.</param>
        public bool Remove(HttpContext httpContext, string key)
        {
            if (httpContext is null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            bool deleted = false;
            if (Exists(httpContext, key))
            {
                httpContext.Response.Cookies.Delete(key);
                deleted = true;
            }
            return deleted;
        }

        /// <summary>
        /// If a cookie exists true is returned, else false is returned. Also, returns false if cookie is empty or only whitespace.
        /// </summary>
        /// <param name="httpContext">Http context for the cookie in question.</param>
        /// <param name="key">Lookup key for the cookie in question.</param>
        /// <returns></returns>
        public bool Exists(HttpContext httpContext, string key)
        {
            if (httpContext is null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            bool exists = false;
            if (!string.IsNullOrWhiteSpace(httpContext.Request.Cookies[key]))
            {
                exists = true;
            }
            return exists;
        }
    }
}




