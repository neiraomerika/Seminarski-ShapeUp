using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShapeUp.Interface;
using ShapeUp.Model.Models;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        public PaymentController(IUplataService uplataService)
        {
            _uplataService = uplataService;
        }

        private Token stripeToken;
        private TokenService tokenService;

        private string stripePublishableApiKey = "pk_test_51KPCVJGaEg6pakfZs5knHOXZKybwOTLc9xfoHwT0BNZFJe8ccyAPvv6VejtT79GAvs7OqkdbjDmpeH3mweI7FP7Y00nzh2tpJx";
        private string stripeSecretApiKey = "sk_test_51KPCVJGaEg6pakfZMXk3ctLRAl6jcGKFUyeNkDEKW5Agw9Rtjg9zs8l05bJ9NWP394pHf4zoJTE7CJuMhMP1Tk5200NlTRNaM8";
        private IUplataService _uplataService;

        public bool IsTransactionSuccess { get; set; }

        [HttpPost]
        [Route("ProccessPayment")]
        public async Task<IActionResult> ProccessPayment(MCreditCard creditCard)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            await Task.Run(() =>
            {
                var Token = CreateToken(creditCard);
                if (Token != null)
                    IsTransactionSuccess = MakePayment(Token, creditCard.Amount, creditCard.Currency, creditCard.MentorstvoId, creditCard.Description);
            });

            if (IsTransactionSuccess)
                return Ok();
            else
                return StatusCode(500);

            return StatusCode(500);
        }

        private string CreateToken (MCreditCard creditCard)
        {
            try
            {
                StripeConfiguration.SetApiKey(stripePublishableApiKey);
                var service = new ChargeService();

                var tokenOptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = creditCard.Number,
                        ExpYear = creditCard.ExpYear,
                        ExpMonth = creditCard.ExpMonth,
                        Cvc = creditCard.Cvc,
                        Name = creditCard.Name,
                        AddressState = creditCard.AddressState,
                        AddressCountry = creditCard.AddressCountry,
                        AddressLine1 = creditCard.AddressLine1,
                        Currency = creditCard.Currency,
                    }
                };

                tokenService = new TokenService();
                stripeToken = tokenService.Create(tokenOptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool MakePayment(string token, long? amount, string currency, int mentorstvoId, string description)
        {
            try
            {
                StripeConfiguration.SetApiKey(stripeSecretApiKey);
                var options = new ChargeCreateOptions
                {
                    Amount = amount,
                    Currency = currency,
                    Description = description,
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "miralem.omerika@gmail.com",
                };

                var service = new ChargeService();
                Charge charge = service.Create(options);
                _uplataService.CreateUplata(mentorstvoId, true, charge.Id, amount);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetCharges()
        {
            StripeConfiguration.SetApiKey(stripeSecretApiKey);
            var service = new ChargeService();
            ChargeListOptions options = new ChargeListOptions();
            
            options.Limit = 100;
            var response = await service.ListAsync(options);
            return Ok(response);
        }
    }
}
