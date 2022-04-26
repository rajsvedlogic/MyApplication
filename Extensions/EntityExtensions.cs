using Microsoft.Xrm.Sdk;
namespace MyApplication.Extensions
{
    public static class EntityExtensions
    {
        public static Entity GetEntity(this EntityReference e)
        {
            var entity = new Entity(e.LogicalName) { Id = e.Id };
            entity["name"] = e.Name;
            entity["chps_name"] = e.Name; //experimental
            return entity;
        }
    }
}
