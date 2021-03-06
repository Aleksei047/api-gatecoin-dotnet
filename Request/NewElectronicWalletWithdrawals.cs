using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/Withdrawals/{DigiCurrency}", "POST", Summary = @"Request a transfer from the traders account to an external address. This is only available for crypto currencies.", Notes = @"")]
public class NewElectronicWalletWithdrawals : IReturn<CommonResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "The digital currency to withdraw", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "External address name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String AddressName {get; set; } 
[ApiMember(Name = "Amount", Description = "Amount to withdraw", ParameterType = "query", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "Comment", Description = "comment", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Comment {get; set; } 
[ApiMember(Name = "ExtraInfo", Description = "", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ExtraInfo {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

