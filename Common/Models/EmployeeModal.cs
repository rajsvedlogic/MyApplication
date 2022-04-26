using MyApplication.Utils.Converters;
using Microsoft.Xrm.Sdk;
using System;
using System.Text.Json.Serialization;

namespace MyApplication.Common.Models
{
     public class EmployeeModal : Base.Model
    {
        public EmployeeModal() : base(Services.EmployeeService.EntityLogicalName)
        {
        }
        public enum StatusReason
        {
            Active,
            Inactive,
        }
        public EmployeeModal(Entity entity) : base(entity)
        { }


        [Base.Mapping("az_name")]
        public new string name { get; set; }


        [Base.Mapping("az_address")]
        public new string address { get; set; }

        [Base.Mapping("az_age")]
        public int age { get; set; }

        [Base.Mapping("az_designation")]
        [JsonConverter(typeof(GuidToModel<DesignationModal>))]
        public DesignationModal designation { get; set; }

        [Base.Mapping("az_dob")]
        public DateTime dob { get; set; }

        [Base.Mapping("az_email")]
        public new string email { get; set; }

        [Base.Mapping("az_gender")]
        public bool? gender { get; set; }

        [Base.Mapping("az_joiningdate")]
        public DateTime joiningdate { get; set; }

        [Base.Mapping("az_phonenumber")]
        public string phonenumber { get; set; }
    }
}
