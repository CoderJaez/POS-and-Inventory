﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Repository;
namespace PurpleYam_POS.Model
{
    public class SaleTransactionModel
    {
        public string  TransactionNo { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [MinLength(11)]//09124561077
        public string ContactNo { get; set; }
        [Required]
        public decimal DownPayment { get; set; }
        public decimal Balance { get; set; }
        public decimal Vat { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalAmount { get; set; }
        [Required]
        [CashTendered]
        public decimal CashTendered { get; set; }
        public decimal Change { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ClaimStatus { get; set; }

    }
}
