using System;
using ServiceStack;
using VanillaOnEcr.ServiceModel;

namespace VanillaOnEcr.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
