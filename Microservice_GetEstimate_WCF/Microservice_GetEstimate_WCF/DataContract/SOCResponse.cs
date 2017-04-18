using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Micro_GetEstimate_WCF.DataContract
{
    [DataContract]
    public class SOCResponse
    {
        
        private SOCEstimate socEstimate;

        [DataMember]
        public SOCEstimate SOCEstimate
        {
            get { return socEstimate; }
            set { socEstimate = value; }
        }

       
        private List<ProductInfo> productlst;

        [DataMember]
        public List<ProductInfo> Productlst
        {
            get { return productlst; }
            set { productlst = value; }
        }        
    }
}
