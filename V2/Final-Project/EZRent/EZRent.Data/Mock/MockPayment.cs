using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;


namespace EZRent.Data.Mock
{
    public static class MockPayment
    {
        public static List<Payment> list = new List<Payment>()
            {
                new Payment {Id=1, Amount=1500, BankId = 1, DatePosted = new DateTime(2018,02,01), PropertyId=1, StatusId=1},
                new Payment {Id=2, Amount=1800, BankId = 2, DatePosted = new DateTime(2018,02,01), PropertyId=1, StatusId=1},
                new Payment {Id=3, Amount=1200, BankId = 3, DatePosted = new DateTime(2018,02,01), PropertyId=1, StatusId=1},
            };
        }
    }