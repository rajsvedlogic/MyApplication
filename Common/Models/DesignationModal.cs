using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MyApplication.Common.Models;
using MyApplication.Utils.Converters;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;


namespace MyApplication.Common.Models
{
   public class DesignationModal : Base.Model
    { 

        public DesignationModal() : base(Services.EmployeeService.EntityLogicalName)
        {
        }
        public enum StatusReason
        {
            Active,
            Inactive,
        }
        public DesignationModal(Entity entity) : base(entity)
        { }

        [Base.Mapping("az_name")]
        public new string name { get; set; }


        [Base.Mapping("az_department")]
        [JsonConverter(typeof(GuidToModel<DepartmentModel>))]
        public DesignationModal designation { get; set; }
    }
}
