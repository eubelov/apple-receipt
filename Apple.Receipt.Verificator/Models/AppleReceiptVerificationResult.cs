﻿using Apple.Receipt.Models;
using Apple.Receipt.Verificator.Models.IAPVerification;

namespace Apple.Receipt.Verificator.Models
{
    public class AppleReceiptVerificationResult
    {
        public AppleReceiptVerificationResult(
            string errorMessage,
            IapVerificationResultStatus status,
            AppleAppReceipt? receipt = null
        )
        {
            Message = errorMessage;
            Status = status;
            Receipt = receipt;
        }

        public string Message { get; set; }

        public IapVerificationResultStatus? Status { get; set; }

        public AppleAppReceipt? Receipt { get; set; }
    }
}
