﻿using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ebanx.net.Parameters.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentRequest : RequestBase
    {
        /// <summary>
        /// Customer name.
        /// </summary>
        [JsonProperty("name"), Required, MinLength(1), MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Three-letter code of the payment currency. Supported currencies:* BRL
        /// </summary>
        [JsonProperty("currency_code")]
        public string Currency_code { get; set; }

        /// <summary>
        /// The amount in the specified currency (currency_code). E.g.: 100.50
        /// </summary>
        [JsonProperty("amount_total")]
        public float AmountTotal { get; set; }

        /// <summary>
        /// The payment hash Merchant Payment Code (unique merchant ID).
        /// </summary>
        [JsonProperty("merchant_payment_code")]
        public string MerchantPaymentCode { get; set; }

        /// <summary>
        /// The code of the payment method. The supported codes are:
        ///amex: American Express credit card.
        ///boleto: Boleto bancário.
        ///diners: Diners credit card.
        ///discover: Discover credit card.
        ///elo: Elo credit card.
        ///hipercard: Hipercard credit card.
        ///mastercard: MasterCard credit card.
        ///visa: Visa credit card.
        ////// </summary>
        [JsonProperty("payment_type_code")]
        public string PaymentTypeCode { get; set; }

        /// <summary>
        /// Customers document.
        ///* Brazil: requires a valid CPF(natural person taxpayer ID) or CNPJ(business taxpayer ID).
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Customer’s IP adress. It may be used by an anti-fraud tool.
        /// </summary>
        [JsonProperty("customer_ip")]
        public string CustomerIp { get; set; }

        /// <summary>
        /// Customer’s zipcode.
        ///* Brazil: required.
        /// </summary>
        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        /// <summary>
        /// Customer address (street name).
        ///* Brazil: required.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Customer street number.
        ///* Brazil: required.
        /// </summary>
        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Extra address field for complimentary data.
        /// </summary>
        [JsonProperty("street_complement")]
        public string StreetComplement { get; set; }

        /// <summary>
        /// Customer city.
        ///* Brazil: required.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Customer state/region/province.
        ///* Brazil: required.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The two-letter country code for the customer country. The available codes are:
        ///* br: Brazil.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Customer phone number. It is required for all countries.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_1")]
        public string UserValue1 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_2")]
        public string UserValue2 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_3")]
        public string UserValue3 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_4")]
        public string UserValue4 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_5")]
        public string UserValue5 { get; set; }

        /// <summary>
        /// The due date of payments slips. Boletos issued in USD can have a maximum expiry period of three days; boletos issued in BRL can have an extended expiry date. The due date is based on local time of the country that the payment is generated.
        /// </summary>
        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// Generates a token for recurring billing. This is only available for merchants that have requested recurring billing on their contracts.
        /// </summary>
        [JsonProperty("create_token")]
        public bool CreateToken { get; set; }

        /// <summary>
        /// Choose the token you want to use for recurring billing. This is only available for merchants that have requested recurring billing on their contracts. Use this parameter only if create_token is true.
        /// NOTE: TOKENS EXPIRE AFTER 14 MONTHS OF ITS LAST USE.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The number of instalments of the payment (from 1 to 12, depending on your contract and the country).
        ///* Brazil: 1 to 12 (depending on your contract).
        /// </summary>
        [JsonProperty("instalments")]
        public int Instalments { get; set; }

        /// <summary>
        /// Object containing the customers credit card information.
        /// </summary>
        [JsonProperty("creditcard")]
        public CreditCardRequest CreditCard { get; set; }

        /// <summary>
        /// A note about the payment. The value of this parameter will be shown along with payment details.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The object containing the sub account’s name. Required for payments where the sub account feature is being used.
        /// </summary>
        [JsonProperty("sub_account")]
        public SubAccountRequest SubAccount { get; set; }

        /// <summary>
        /// Object containing the items of the order
        /// </summary>
        [JsonProperty("items")]
        public List<ItemRequest> Items { get; set; }

        /// <summary>
        /// Code for the customer’s bank. Only required for Colombia payments. You can retrieve the available codes from ws/getBankList operation.
        /// </summary>
        [JsonProperty("eft_code")]
        public string EftCode { get; set; }

        /// <summary>
        /// The URL to send notifications for this payment. If this field is filled, EBANX will notify using this URL instead of the configured one.
        /// Example: https://notify.example.com/
        /// </summary>
        [JsonProperty("notification_url")]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// The URL to redirect the customer after the payment in the EBANX Payment Page. If this field is filled, EBANX will redirect the customer using this URL instead of the configured one.
        /// Example: https://mywebsite.com/thankyou
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Optional parameter that can be used to identify the type of customer:
        /// business: Corporation, legal entity.
        ///* personal: Natural person.
        /// </summary>
        [JsonProperty("person_type")]
        public string PersonType { get; set; }

        /// <summary>
        /// A JSON object that represents the responsible. Required if person_type = business.
        /// </summary>
        [JsonProperty("responsible")]
        public ResponsibleRequest Responsible { get; set; }
    }
}
