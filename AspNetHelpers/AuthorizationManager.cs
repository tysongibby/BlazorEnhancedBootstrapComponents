using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System;
using Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components;
using Models;
using Repositories;
using Repositories.Interfaces;

namespace AspNetHelpers
{
    /// <summary>
    /// Helper for managing user authorization status, user data and credentials.
    /// </summary>
    public class AuthorizationManager
    {
        //[Inject]
        //public IWebHostingEnvironment HostingEnvironment { get; set; }
        [Inject]
        private ICustomerRepository CustomerRepository { get; set; } = new CustomerRepository();

        /// <summary>
        /// Retrieves the Subject from the user's X509Certificate2 if connection is HTTPS and is not dev environment.
        /// In the dev environment, gets the developer's certificate subject from Authorization.DeveloperCertificate.
        /// (Developer's certificate subject must be manually added to the Authorization.DeveloperCertificate method)
        /// </summary>
        /// <returns>Returns string of User's X509Certificate2.Subject</returns>
        public string GetUserCertificateSubject(HttpContext httpContext)
        {
            if (httpContext is null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            try
            {
                Customer user = new Customer();
                // If using https secure connection then get user's certificate name from HttpContext
                // if running on (non-https) get user's certificate name from 
                // Authentication.DeveloperCertificate class for developer
                string certSubject = string.Empty;
                if (httpContext.Request.IsHttps)
                {
                    // Get certificate name from user's certifcate information
                    X509Certificate2 x509Cert = httpContext.Connection.ClientCertificate;
                    if (x509Cert is not null && string.IsNullOrWhiteSpace(x509Cert.Subject))
                    {
                        certSubject = x509Cert.Subject;
                    }
                    else
                    {
                        certSubject = GetDeveloperCertificateSubject();
                    }
                }
                else
                {
                    certSubject = GetDeveloperCertificateSubject();
                }
                // add certificate information to ApplicationUser
                return certSubject;
            }
            catch (Exception e)
            {
                throw new UnauthorizedAccessException($"AuthorizationManager.GetUserCertificateSubject: {e.Message}", e.InnerException);
            }
        }

        /// <summary>
        /// Creates PdmssUser using the user's X509Certificate2.Subject to pull the needed user data from the database.                
        /// </summary>
        /// <returns>Returns a PdmssUser</returns>
        public ApplicationUser GetPdmssUser(HttpContext httpContext)
        {
            if (httpContext is null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            try
            {
                string certSubject = GetUserCertificateSubject(httpContext);
                Customer customer = CustomerRepository.Get(certSubject);
                return new ApplicationUser(customer);
            }
            catch (Exception e)
            {
                throw new UnauthorizedAccessException($"AuthorizationManager.GetPdmsUser: {e.Message}", e.InnerException);
            }
        }

        /// <summary>
        /// Returns the developmers certificate subject.
        /// <remarks>YOU NEED TO UPDATE THIS METHOD WITH YOUR X509Certificate2.Subject</remarks>
        /// </summary>
        /// <returns>String of developer's X509Certificate2.Subject</returns>
        public string GetDeveloperCertificateSubject()
        {
            //return "ANDERSON.GARY.R.1364054870";
            //return "KERSHAW.STEVEN.1499431100";
            //return "COOK.STEVEN.T.1268138672";
            //return "CARDALL.CURT.ALLEN.1158517856";
            //return "JOHNS.LAURENCE.BLAINE.1268065519";
            //return "STANLEY.MARTIN.1406911230";
            //return "SLEVE.GORDON.N.1268255032";
            return "GIBBY.HENRY.TYSON.1222765567";
            //return "JAMES.DOUGLAS.W.1231545316";
            //return "ELKINS.BRIAN.J.1228622091";
        }
    }
}

