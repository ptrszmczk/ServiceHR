﻿using ServiceHR.DataAccessLayer.Models.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHR.DataAccessLayer.Models
{
    public class EmployeeModel : EntityModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Code { get; set; }
        public GenderModel Gender { get; set; }
        public DateTime? DateBirth  { get; set; }
        public string PESEL { get; set; }
        public string PhoneNumer { get; set; }
        public string EmailAddress { get; set; }
        public string IdentityCardNumber { get; set; }
        public DateTime? IssueDateIdentityCard { get; set; }
        public DateTime? ExpirationDateIdentityCard { get; set; }
        public string PasswordNumber { get; set; }
        public DateTime? IssueDatePassport { get; set; }
        public DateTime? ExpirationDatePassport { get; set; }
        public StatusModel Status { get; set; }
    }
}
