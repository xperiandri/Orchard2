using System.Collections.Generic;
using DotLiquid;
using Orchard.Queries;

namespace Orchard.Liquid.Drops
{
    public class QueriesDrop : Drop, IIndexable
    {
        private readonly IQueryManager _queryManager;

        public QueriesDrop(IQueryManager queryManager)
        {
            _queryManager = queryManager;
        }
        
        public override object BeforeMethod(string method)
        {
            var query = _queryManager.GetQueryAsync(method.ToString()).GetAwaiter().GetResult();

            if (query == null)
            {
                return null;
            }

            var result = _queryManager.ExecuteQueryAsync(query, new Dictionary<string, object>()).GetAwaiter().GetResult();
            return result;
        }

        bool IIndexable.ContainsKey(object key)
        {
            return true;
        }
    }
}
