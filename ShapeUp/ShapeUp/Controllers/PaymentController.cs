using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        private Token stripeToken;
        private TokenService tokenService;

        private string stripePublishableApiKey = "pk_test_51KPCVJGaEg6pakfZs5knHOXZKybwOTLc9xfoHwT0BNZFJe8ccyAPvv6VejtT79GAvs7OqkdbjDmpeH3mweI7FP7Y00nzh2tpJx";
        private string stripeSecretApiKey = "sk_test_51KPCVJGaEg6pakfZMXk3ctLRAl6jcGKFUyeNkDEKW5Agw9Rtjg9zs8l05bJ9NWP394pHf4zoJTE7CJuMhMP1Tk5200NlTRNaM8";
    }
}
