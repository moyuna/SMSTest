using System;
using System.Collections.Generic;

using Azure;
using Azure.Communication;
using Azure.Communication.Sms;


string connectionString = "endpoint=https://customermessage.unitedstates.communication.azure.com/;accesskey=XdLbLsurCTGBJugl032YUMn6KkYMSHzUxFdZ4lzRJB+3tWtiHGZfefjfO7upu1vVblgK123M82aJToyEaisPRA==";

SmsClient smsClient = new SmsClient(connectionString);
SmsSendResult sendResult = smsClient.Send(
	from: "+18332645385",
	to: "+529982320511",
	message: "Prueba SMS"
);

Console.WriteLine($"Sms id: {sendResult.Successful}");
Console.WriteLine($"Sms id: {sendResult.MessageId}");
Console.WriteLine($"Sms id: {sendResult.HttpStatusCode}");


Console.ReadKey();