using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArticleNr { get; set; }
        public int Price { get; set; }

        public override bool Equals(object other)
        {
            if(other.GetType() == typeof(Product))
            {
                return this.GetHashCode() == ((Product)other).GetHashCode();
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = 1187468573;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + ArticleNr.GetHashCode();
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
