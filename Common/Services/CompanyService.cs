using MyApplication.Common.Models;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static MyApplication.Common.Models.CompanyModel;

namespace MyApplication.Common.Services
{
    public class CompanyService : Base.Service
    {
        public static readonly string EntityLogicalName = "az_companyaz";

        public CompanyService() : base(EntityLogicalName)
        {
        }

        public async Task<List<CompanyModel>> GetAllCompany()
        {
            QueryExpression query = new QueryExpression(EntityLogicalName);
            query.Criteria.AddCondition(new ConditionExpression("statecode", ConditionOperator.Equal, Convert.ToInt32(StatusReason.Active)));
            var result = await base.GetAll<CompanyModel>(query);

            return result;
        }

    }
}
