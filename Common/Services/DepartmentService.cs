using MyApplication.Common.Models;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static MyApplication.Common.Models.DepartmentModel;

namespace MyApplication.Common.Services
{
    public class DepartmentService : Base.Service
    {
        public static readonly string EntityLogicalName = "az_departmentaz";

        public DepartmentService() : base(EntityLogicalName)
        {
        }
        public async Task<List<DepartmentModel>> GetAllDepartment()
        {
            QueryExpression query = new QueryExpression(EntityLogicalName);
            query.Criteria.AddCondition(new ConditionExpression("statecode", ConditionOperator.Equal, Convert.ToInt32(StatusReason.Active)));
            var result = await base.GetAll<DepartmentModel>(query);

            return result;
        }
    }
}
