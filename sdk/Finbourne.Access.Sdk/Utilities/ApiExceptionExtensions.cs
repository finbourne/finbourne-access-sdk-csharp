using System.Net;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;
using Newtonsoft.Json;

namespace Finbourne.Access.Sdk.Utilities
{
    /// <summary>
    /// Extension to deserialise LUSID exceptions contained within the ApiException.ErrorContent
    /// </summary>
    public static class ApiExceptionExtensions
    {
        /// <summary>
        /// Identify whether the API exception was caused by a request validation problem
        /// </summary>
        public static bool IsValidationProblem(this ApiException ex)
        {
            return ex.ErrorCode == (int) HttpStatusCode.BadRequest;
        }

        /// <summary>
        /// Try and get the details of a validation problem, if there are any
        /// </summary>
        public static bool TryGetValidationProblemDetails(this ApiException ex,
            out LusidValidationProblemDetails details)
        {
            if (IsValidationProblem(ex))
            {
                details = ValidationProblemDetails(ex);
                return true;
            }

            details = null;
            return false;
        }
        
        /// <summary>
        /// Return the details of a validation problem
        /// </summary>
        public static LusidValidationProblemDetails ValidationProblemDetails(this ApiException ex)
        {
            if (ex.ErrorContent == null)
            {
                return null;
            }
            
            //    ApiException.ErrorContent contains a JSON serialized ValidationProblemDetails
            return JsonConvert.DeserializeObject<LusidValidationProblemDetails>(ex.ErrorContent, new JsonConverter[]
            {
                new PropertyBasedConverter(),
            });
        }
        
        /// <summary>
        /// Return the details of a problem
        /// </summary>
        public static LusidProblemDetails ProblemDetails(this ApiException ex)
        {
            if (ex.ErrorContent == null)
            {
                return null;
            }

            //    ApiException.ErrorContent contains a JSON serialized ProblemDetails
            return JsonConvert.DeserializeObject<LusidProblemDetails>(ex.ErrorContent, new JsonConverter[]
            {
                new PropertyBasedConverter(),
            });
        }

        /// <summary>
        /// Extracts the requestId from an ApiException
        /// </summary>
        public static string GetRequestId(this ApiException ex)
        {
            if (ex.ProblemDetails() == null) return null;

            // Extract requestId from Insights link contained in the Instance property
            var instanceParts = ex.ProblemDetails().Instance.Split("/".ToCharArray());

            return instanceParts.Length < 7 ? null : instanceParts[6];
        }
    }
}
