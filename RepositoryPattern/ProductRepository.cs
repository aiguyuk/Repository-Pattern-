using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class ProductRepository : IProductRepository
    {
        
        public bool Delete(string productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionsString);
            if (db.State == ConnecitonState.Closed)
                db.Open();
            return db.Query<Product>("select ProductId, ProductName, UnitPrice, UnitsInStock, Barcode from Products", commandType: CommandType.Text);
        }

        public bool Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
