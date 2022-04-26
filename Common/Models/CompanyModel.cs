using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication.Common.Models
{
    public class CompanyModel : Base.Model
    {

        public CompanyModel() : base(Services.CompanyService.EntityLogicalName)
        {
        }

        public enum StatusReason
        {
            Active,
            Inactive,
        }

        public CompanyModel(Entity entity) : base(entity)
        {}


        [Base.Mapping("az_name")]
        public new string name { get; set; }
    }
}

