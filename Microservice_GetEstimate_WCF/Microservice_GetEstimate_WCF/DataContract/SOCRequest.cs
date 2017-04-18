using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Micro_GetEstimate_WCF.DataContract
{
    [DataContract]
    public class SOCRequest  {
                
        private List<ProductInfo> products;

        [DataMember]
        public List<ProductInfo> Products
        {
            get { return products; }
            set { products = value; }
        }        

    }
}
