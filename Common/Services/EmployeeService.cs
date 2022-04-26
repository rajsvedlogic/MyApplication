using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyApplication.Common.Models;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;


using static MyApplication.Common.Models.EmployeeModal;


namespace MyApplication.Common.Services
{
    public class EmployeeService :Base.Service
    {
        public static readonly string EntityLogicalName = "az_employeeaz";

      
        public EmployeeService() : base(EntityLogicalName)
        {
        }

        public async Task<List<EmployeeModal>> GetAllEmployee()
        {
            QueryExpression query = new QueryExpression(EntityLogicalName);
            query.Criteria.AddCondition(new ConditionExpression("statecode", ConditionOperator.Equal, Convert.ToInt32(StatusReason.Active)));
            var result = await GetAll<EmployeeModal>(query);

            return result;
        }
        public async Task<List<DesignationModal>>GetAllDesignationId(Guid designation)
        {
            QueryExpression query = new QueryExpression(EntityLogicalName);
            query.Criteria.AddCondition(new ConditionExpression("az_designation", ConditionOperator.Equal, designation));
            query.AddOrder("az_name", OrderType.Ascending);
            var result = await GetAll<DesignationModal>(query);

            return result;
        }

        public async Task<Guid> CreateUpdate(EmployeeModal request)
        {
            Entity updatedEntity = new Entity(request.EntityLogicalName, request.id);
            if (Guid.Empty.Equals(request.id))
                updatedEntity = await Create(request);
            else
                updatedEntity = await base.Update(request.id, request);

            return updatedEntity.Id;
        }

        public  Task CreateUpdate(object value)
        {
            throw new NotImplementedException();
        }
    }
}
