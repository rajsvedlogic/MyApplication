using MyApplication.Common.Models;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static MyApplication.Common.Models.DesignationModal;

namespace MyApplication.Common.Services
{
      public class DesignationService : Base.Service
    {
        public static readonly string EntityLogicalName = "az_designationaz";

        public DesignationService() : base(EntityLogicalName)
        {
        }
        public async Task<List<DesignationModal>>GetAllDesignation()
        {
            QueryExpression query = new QueryExpression(EntityLogicalName);
            query.Criteria.AddCondition(new ConditionExpression("statecode", ConditionOperator.Equal, Convert.ToInt32(StatusReason.Active)));
            var result = await base.GetAll<DesignationModal>(query);

            return result;

        }

        public Task GetAllDesination(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task GetAllDesignationId(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
