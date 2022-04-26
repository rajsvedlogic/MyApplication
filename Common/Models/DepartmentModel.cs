using MyApplication.Utils.Converters;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MyApplication.Common.Models
{
    public class DepartmentModel : Base.Model
    {
        public DepartmentModel() : base(Services.DepartmentService.EntityLogicalName)
        { }

        public enum StatusReason
        {
            Active,
            Inactive,
        }
        public DepartmentModel(Entity entity) : base(entity)
        {
        }

        [Base.Mapping("az_name")]
        public new string name { get; set; }

        [Base.Mapping("az_company")]
        [JsonConverter(typeof(GuidToModel<CompanyModel>))]
        public DesignationModal company { get; set; }

    }
}
